namespace GroupProj.Наргиз {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.btDelMonthly = new System.Windows.Forms.Button();
      this.btDelOnetime = new System.Windows.Forms.Button();
      this.back_but = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(221, 150);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(388, 22);
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = "удалить из";
      this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // btDelMonthly
      // 
      this.btDelMonthly.Location = new System.Drawing.Point(221, 255);
      this.btDelMonthly.Name = "btDelMonthly";
      this.btDelMonthly.Size = new System.Drawing.Size(158, 50);
      this.btDelMonthly.TabIndex = 1;
      this.btDelMonthly.Text = "Ежемесячного";
      this.btDelMonthly.UseVisualStyleBackColor = true;
      this.btDelMonthly.Click += new System.EventHandler(this.btDelMonthly_Click);
      // 
      // btDelOnetime
      // 
      this.btDelOnetime.Location = new System.Drawing.Point(451, 255);
      this.btDelOnetime.Name = "btDelOnetime";
      this.btDelOnetime.Size = new System.Drawing.Size(158, 50);
      this.btDelOnetime.TabIndex = 2;
      this.btDelOnetime.Text = "Разового";
      this.btDelOnetime.UseVisualStyleBackColor = true;
      this.btDelOnetime.Click += new System.EventHandler(this.btDelOnetime_Click);
      // 
      // back_but
      // 
      this.back_but.Location = new System.Drawing.Point(721, 390);
      this.back_but.Name = "back_but";
      this.back_but.Size = new System.Drawing.Size(61, 49);
      this.back_but.TabIndex = 3;
      this.back_but.Text = "<";
      this.back_but.UseVisualStyleBackColor = true;
      this.back_but.Click += new System.EventHandler(this.back_but_Click);
      this.back_but.MouseEnter += new System.EventHandler(this.back_but_MouseEnter);
      this.back_but.MouseLeave += new System.EventHandler(this.back_but_MouseLeave);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.back_but);
      this.Controls.Add(this.btDelOnetime);
      this.Controls.Add(this.btDelMonthly);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Удалить";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button btDelMonthly;
    private System.Windows.Forms.Button btDelOnetime;
    private System.Windows.Forms.Button back_but;
  }
}