using Dapper;
using GroupProj.Анастасия.monthly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProj.Анастасия
{
  public partial class add_costs_m2 : Form
  {
    public add_costs_m2()
    {
      InitializeComponent();

      summ.Text = "введите сумму";
      summ.ForeColor = Color.Gray;
      coments.Text = "введите коментарий";
      coments.ForeColor = Color.Gray;

    }






    private void add_button_Click(object sender, EventArgs e)
    {
      DateTime dateTime = DateTime.Now;
      String sum = summ.Text;
      String coment = coments.Text;

      using(var con = new SqlConnection(Constants.ConStr)) {
        con.Execute("insert into Data (UID, Type, Account, Amount, Comment, Currency, Date) values (@UID, @Type, @Account, @Amount, @Comment, @Currency, @Date)", 
                    new { UID = Кирилл.MainForm.UserID, Type = 1, Account = Кирилл.MainForm.CurrentAccount, Amount = Decimal.Parse(sum), Comment = coment, Currency = Кирилл.MainForm.Currency, Date = dateTime });
      }

      this.Hide();
      Кирилл.MainForm mainform = new Кирилл.MainForm();
      mainform.Show();
    }
    private void coments_TextChanged(object sender, EventArgs e)
    {
      String coment = coments.Text;


    }
    private void summ_TextChanged(object sender, EventArgs e)
    {
      String sum = summ.Text;
    }




    private void back_but2_Click(object sender, EventArgs e)
    {
      this.Hide();
      add_costs_m1 Add_Costs_m1 = new add_costs_m1();
      Add_Costs_m1.Show();
    }




    private void back_but2_MouseEnter(object sender, EventArgs e)
    {
      back_but2.BackColor = Color.Teal;
    }

    private void back_but2_MouseLeave(object sender, EventArgs e)
    {
      back_but2.BackColor = Color.LightGray;
    }

    private void add_button_MouseEnter(object sender, EventArgs e)
    {
      add_button.BackColor = Color.Teal;
    }

    private void add_button_MouseLeave(object sender, EventArgs e)
    {
      add_button.BackColor = Color.LightGray;
    }

    private void summ_Enter(object sender, EventArgs e)
    {
      if (summ.Text == "введите сумму")
      {
        summ.Text = "";
        summ.ForeColor = Color.Black;
      }
    }

    private void summ_Leave(object sender, EventArgs e)
    {
      if (summ.Text == "")
      {
        summ.Text = "введите сумму";
        summ.ForeColor = Color.Gray;

      }
    }

    private void coments_Enter(object sender, EventArgs e)
    {
      if (coments.Text == "введите коментарий")
      {
        coments.Text = "";
        coments.ForeColor = Color.Black;
      }
    }

    private void coments_Leave(object sender, EventArgs e)
    {
      if (coments.Text == "")
      {
        coments.Text = "введите коментарий";
        coments.ForeColor = Color.Gray;

      }
    }

    private void add_cost_m2_Load(object sender, EventArgs e)
    {

    }
  }

}

