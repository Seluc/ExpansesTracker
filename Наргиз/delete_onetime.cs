using Dapper;
using GroupProj.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GroupProj.Constants;

namespace GroupProj.Наргиз {
  public partial class delete_onetime : Form {
    enum Currencies {
      KZT,
      USD,
      EUR
    }
    public static int Currency;
    public static List<Data> OneTimeData;
    string strCurrency = String.Empty;

    public delete_onetime() {
      InitializeComponent();


      using (var con = new SqlConnection(ConStr)) {
        OneTimeData = con.Query<Data>("select Id, Amount, Comment, Date from Data where UID = @UID and Account = @Account and Type = @Type", new { UID = Кирилл.MainForm.UserID, Account = Кирилл.MainForm.CurrentAccount, Type = 0}).ToList();
      }

      var isStrCurrReady = false;

      if (OneTimeData.Count > 0) {
        if (!isStrCurrReady)
          switch (Currency) {
            case (int)Currencies.KZT: strCurrency = "₸"; break;
            case (int)Currencies.USD: strCurrency = "$"; break;
            case (int)Currencies.EUR: strCurrency = "€"; break;
          }

        foreach (var item in OneTimeData) {

          lbOneTime.Items.Add($"{item.Comment}\t{item.Amount.ToString("0.00")}{strCurrency}\t{item.Date}\n");
        }

      }
    }

    private void back_but_Click(object sender, EventArgs e) {
      this.Hide();
      Кирилл.MainForm mainform = new Кирилл.MainForm();
      mainform.Show();
    }

    private void delete_onetime_Load(object sender, EventArgs e) {

    }

    private void back_but_MouseEnter(object sender, EventArgs e) {
      back_but.BackColor = Color.Teal;
    }

    private void back_but_MouseLeave(object sender, EventArgs e) {
      back_but.BackColor = Color.LightGray;
    }

    private void lbOneTime_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void btDelete_Click(object sender, EventArgs e) {

      string del = lbOneTime.SelectedItem.ToString();
      if (MessageBox.Show("Вы точно хотите удалить \t" + del + "?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes) {
        var id = (long)-1;

        foreach (var item in OneTimeData) {
          if (lbOneTime.SelectedItem.ToString().Contains($"{item.Comment}\t{item.Amount.ToString("0.00")}{strCurrency}\t{item.Date}\n"))
            id = item.Id;
        }

        lbOneTime.Items.RemoveAt(lbOneTime.SelectedIndex);

        using (var con = new SqlConnection(Constants.ConStr)) {
          con.Execute("Delete from Data Where Id = @Id", new { Id = id });
        }
      }

    }
  }
}
