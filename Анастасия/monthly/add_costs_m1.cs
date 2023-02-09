using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProj.Анастасия.monthly
{
  public partial class add_costs_m1 : Form
  {
    public add_costs_m1()
    {
      InitializeComponent();
    }

    private void incom_Click(object sender, EventArgs e)
    {
      this.Hide();
      add_costs_m2 Add_Costs_m2 = new add_costs_m2();
      Add_Costs_m2.Show();

    }

    private void expens_Click(object sender, EventArgs e)
    {
      this.Hide();
      add_costs_m3 Add_Costs_m3 = new add_costs_m3();
      Add_Costs_m3.Show();
    }


    private void back_but_Click(object sender, EventArgs e)
    {
      this.Hide();
      Кирилл.MainForm mainform = new Кирилл.MainForm();
      mainform.Show();
    }





    private void back_but_MouseEnter(object sender, EventArgs e)
    {
      back_but.BackColor = Color.Teal;
    }

    private void back_but_MouseLeave(object sender, EventArgs e)
    {
      back_but.BackColor = Color.LightGray;
    }

    private void expens_MouseEnter(object sender, EventArgs e)
    {
      expens.BackColor = Color.Teal;
    }

    private void expens_MouseLeave(object sender, EventArgs e)
    {
      expens.BackColor = Color.LightGray;

    }

    private void incom_MouseEnter(object sender, EventArgs e)
    {
      incom.BackColor = Color.Teal;
    }

    private void incom_MouseLeave(object sender, EventArgs e)
    {
      incom.BackColor = Color.LightGray;
    }


  }
}
