using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProj.Наргиз {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void back_but_Click(object sender, EventArgs e) {
      this.Hide();
      Кирилл.MainForm mainform = new Кирилл.MainForm();
      mainform.Show();
    }

    private void back_but_MouseEnter(object sender, EventArgs e) {
      back_but.BackColor = Color.Teal;
    }

    private void back_but_MouseLeave(object sender, EventArgs e) {
      back_but.BackColor = Color.LightGray;
    }

    private void btDelMonthly_Click(object sender, EventArgs e) {
      this.Hide();
      delete_monthly delete_month = new delete_monthly();
      delete_month.Show();
    }

    private void btDelOnetime_Click(object sender, EventArgs e) {
      this.Hide();
      delete_onetime delete_onetime = new delete_onetime();
      delete_onetime.Show();
    }
  }
}
