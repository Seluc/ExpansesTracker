using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Dapper;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

using static GroupProj.Constants;
using static GroupProj.Анастасия.monthly.add_costs_m1;
using static GroupProj.Анастасия.add_costs_1;
using GroupProj.Classes;

namespace GroupProj.Кирилл {
  public partial class MainForm : Form {
    enum Currencies {
      KZT,
      USD,
      EUR
    }
    public static int Currency;
    public static int UserID;
    public static int CurrentAccount;

    public MainForm() {
      InitializeComponent();

      var macAddr = (from nic in NetworkInterface.GetAllNetworkInterfaces() 
                     where nic.OperationalStatus == OperationalStatus.Up
                     select nic.GetPhysicalAddress().ToString())
                     .FirstOrDefault();

      var isReg = false;
      using (var con = new SqlConnection(ConStr)) {
        isReg = con.Query<string>("select Address from Users where Address = @Address", new { Address = macAddr }).ToList().Count >= 1 ? true : false;
      }

      if (!isReg) {
        var id = 0;
        using (var con = new SqlConnection(ConStr)) {
          id = con.Query<int>("insert into Users (Address, Openned_Acc) output inserted.Id values (@Address, @Openned_Acc)", new { Address = macAddr, Openned_Acc = 1 }).ToList()[0];
        }
        CurrentAccount = 1;
        UserID = id;
        Currency = 0;
      } else {
        using (var con = new SqlConnection(ConStr)) {
          var user = con.Query<Users>("select Id, Openned_Acc from Users where Address = @Address", new { Address = macAddr }).ToList()[0];
          UserID = user.Id;
          CurrentAccount = user.Openned_Acc;
        }
      }

      switch (CurrentAccount) {
        case 1: radioButton1.Checked = true; break;
        case 2: radioButton2.Checked = true; break;
        case 3: radioButton3.Checked = true; break;
        case 4: radioButton4.Checked = true; break;
        case 5: radioButton5.Checked = true; break;
        case 6: radioButton6.Checked = true; break;
        case 7: radioButton7.Checked = true; break;
        case 8: radioButton8.Checked = true; break;
        case 9: radioButton9.Checked = true; break;
        case 10: radioButton10.Checked = true; break;
        case 11: radioButton11.Checked = true; break;
        case 12: radioButton12.Checked = true; break;
        case 13: radioButton13.Checked = true; break;
        case 14: radioButton14.Checked = true; break;
        case 15: radioButton15.Checked = true; break;
        case 16: radioButton16.Checked = true; break;
        case 17: radioButton17.Checked = true; break;
        case 18: radioButton18.Checked = true; break;
      }

      Render();
    }


    private void radioButton_CheckedChanged(object sender, EventArgs e) {
      var bttn = (RadioButton)sender;

      if (bttn.Checked) {
        var num = Int32.Parse(bttn.Text.Split(' ')[1]);

        ChangeCurrAcc(num);
        Render();
      }
    }

    private void bttnChangeCurrency_Click(object sender, EventArgs e) {
      decimal firstInRUB = 0;
      decimal secondInRUB = 0;

      var isFirstDone = false;
      var isDone = false;
      using (var xmlR = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp")) {
        while (xmlR.Read() && !isDone) {
          if (xmlR.NodeType == XmlNodeType.Element &&
              xmlR.Name == "Valute" &&
              xmlR.HasAttributes) {
            while (xmlR.MoveToNextAttribute() && !isDone) {

              if (xmlR.Name == "ID") {
                switch (Currency) {
                  case (int)Currencies.KZT: {
                    if (xmlR.Value == "R01235" && !isFirstDone) { // доллар
                      xmlR.MoveToElement();

                      secondInRUB = GetInRUB(xmlR);

                      isFirstDone = true;
                    } else if (xmlR.Value == "R01335" && isFirstDone) { // тенге
                      xmlR.MoveToElement();

                      firstInRUB = GetInRUB(xmlR);

                      isDone = true;
                      Currency = (int)Currencies.USD;
                    }
                  }
                  break;
                  case (int)Currencies.USD: {
                    if (xmlR.Value == "R01235" && !isFirstDone) { // доллар
                      xmlR.MoveToElement();

                      firstInRUB = GetInRUB(xmlR);

                      isFirstDone = true;
                    } else if (xmlR.Value == "R01239" && isFirstDone) { // евро
                      xmlR.MoveToElement();

                      secondInRUB = GetInRUB(xmlR);

                      isDone = true;
                      Currency = (int)Currencies.EUR;
                    }
                  }
                  break;
                  case (int)Currencies.EUR: {
                    if (xmlR.Value == "R01239" && !isFirstDone) { // евро
                      xmlR.MoveToElement();

                      firstInRUB = GetInRUB(xmlR);

                      isFirstDone = true;
                    } else if (xmlR.Value == "R01335" && isFirstDone) { // тенге
                      xmlR.MoveToElement();

                      secondInRUB = GetInRUB(xmlR);

                      isDone = true;
                      Currency = (int)Currencies.KZT;
                    }
                  }
                  break;
                }
              }
            }
          }
        }
      }

      using(var con = new SqlConnection(ConStr)) {
        con.Execute("update Data set Amount = (Amount * @firstInRUB) / @secondInRUB where UID = @UID and Account = @Account",
                    new { UID = UserID, Account = CurrentAccount, firstInRUB = firstInRUB, secondInRUB = secondInRUB });
      }

      Render();
    }

    private decimal GetInRUB(XmlTextReader xmlR) {
      var content = xmlR.ReadOuterXml();
      var valueStr = content.Split(new char[] { '<', '>' })[20];
      var valueStrs = valueStr.Split(',');
      valueStr = valueStrs[0] + '.' + valueStrs[1];

      var value = decimal.Parse(valueStr);
      var nomenal = Int32.Parse(content.Split(new char[] { '<', '>' })[12]);

      return value / nomenal;
    }


    private void ChangeCurrAcc(int currAcc) {
      using (var con = new SqlConnection(ConStr)) {
        con.Execute("update Users set Openned_Acc = @Openned_Acc where Id = @Id", new { Id = UserID, Openned_Acc = currAcc });
      }
    }


    private void Render() {
      decimal summary = 0;
      rtbOneTime.Text = "Одноразовый доход/расход\n\n";
      rtbMonthly.Text = "Ежемесячный доход/расход\n\n";
      var strCurrency = String.Empty;

      var OneTimeData = new List<Data>();
      var MonthlyData = new List<Data>();

      using (var con = new SqlConnection(ConStr)) {
        CurrentAccount = con.Query<int>("select Openned_Acc from Users where Id = @Id", new { Id = UserID }).ToList()[0];

        OneTimeData = con.Query<Data>("select Amount, Comment, Date from Data where UID = @UID and Account = @Account and Type = @Type", new { UID = UserID, Account = CurrentAccount, Type = 0 }).ToList();
        MonthlyData = con.Query<Data>("select Amount, Comment, Date from Data where UID = @UID and Account = @Account and Type = @Type", new { UID = UserID, Account = CurrentAccount, Type = 1 }).ToList();
      }

      var isStrCurrReady = false;
      if (OneTimeData.Count > 0) {
        switch (Currency) {
          case (int)Currencies.KZT: strCurrency = "₸"; break;
          case (int)Currencies.USD: strCurrency = "$"; break;
          case (int)Currencies.EUR: strCurrency = "€"; break;
        }
        isStrCurrReady = true;
      
        foreach (var item in OneTimeData) {
          summary += item.Amount;

          rtbOneTime.Text += $"{item.Comment}\t{item.Amount.ToString("0.00")}{strCurrency}\t{item.Date}\n";
        }
      } else {
        rtbOneTime.Text = "Пусто";
      }

      if (MonthlyData.Count > 0) {
        if(!isStrCurrReady)
          switch (Currency) {
            case (int)Currencies.KZT: strCurrency = "₸"; break;
            case (int)Currencies.USD: strCurrency = "$"; break;
            case (int)Currencies.EUR: strCurrency = "€"; break;
          }

        foreach (var item in MonthlyData) {
          summary += item.Amount;

          rtbMonthly.Text += $"{item.Comment}\t{item.Amount.ToString("0.00")}{strCurrency}\t{item.Date}\n";
        }
      } else {
        rtbMonthly.Text = "Пусто";
      }

      rtbSummary.Text = summary.ToString("0.00") + ' ' + strCurrency + '\n';
      rtbSummary.Text += summary > 0 ? "Вы зарабатываете больше чем тратите." : "Вы тратите больше чем зарабатываете. Пора начать экономить.";
      if (summary == 0) rtbSummary.Text = "Пусто";
    }


    private void bttnAddMonthly_Click(object sender, EventArgs e) {
      this.Hide();
      Анастасия.monthly.add_costs_m1 Add_Costs_m1 = new Анастасия.monthly.add_costs_m1();
      Add_Costs_m1.Show();
    }
    private void bttnAddOneTime_Click(object sender, EventArgs e) {
      this.Hide();
      Анастасия.add_costs_1 Add_Costs_1 = new Анастасия.add_costs_1();
      Add_Costs_1.Show();
    }

    private void bttnOneTime_Click(object sender, EventArgs e) {

    }

    private void btHistory_Click(object sender, EventArgs e) {

    }

    private void rtbMonthly_TextChanged(object sender, EventArgs e) {

    }

    private void bttnAddOneTime_Click_1(object sender, EventArgs e) {
      this.Hide();
      Наргиз.Form1 delete = new Наргиз.Form1();
      delete.Show();
    }
  }
}

