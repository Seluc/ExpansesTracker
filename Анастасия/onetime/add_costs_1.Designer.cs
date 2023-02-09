namespace GroupProj.Анастасия
{
  partial class add_costs_1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.incom = new System.Windows.Forms.Button();
      this.expens = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.back_but = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // incom
      // 
      this.incom.Location = new System.Drawing.Point(126, 277);
      this.incom.Name = "incom";
      this.incom.Size = new System.Drawing.Size(140, 58);
      this.incom.TabIndex = 0;
      this.incom.Text = "доход";
      this.incom.UseVisualStyleBackColor = true;
      this.incom.Click += new System.EventHandler(this.incom_Click);
      this.incom.MouseEnter += new System.EventHandler(this.incom_MouseEnter);
      this.incom.MouseLeave += new System.EventHandler(this.incom_MouseLeave);
      // 
      // expens
      // 
      this.expens.Location = new System.Drawing.Point(468, 277);
      this.expens.Name = "expens";
      this.expens.Size = new System.Drawing.Size(140, 58);
      this.expens.TabIndex = 1;
      this.expens.Text = "расход";
      this.expens.UseVisualStyleBackColor = true;
      this.expens.Click += new System.EventHandler(this.expens_Click);
      this.expens.MouseEnter += new System.EventHandler(this.expens_MouseEnter);
      this.expens.MouseLeave += new System.EventHandler(this.expens_MouseLeave);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(181, 144);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(388, 26);
      this.textBox1.TabIndex = 2;
      this.textBox1.Text = "что вы хотите добавить?";
      this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // back_but
      // 
      this.back_but.BackColor = System.Drawing.SystemColors.Control;
      this.back_but.Location = new System.Drawing.Point(727, 389);
      this.back_but.Name = "back_but";
      this.back_but.Size = new System.Drawing.Size(61, 49);
      this.back_but.TabIndex = 3;
      this.back_but.Text = "❮";
      this.back_but.UseVisualStyleBackColor = false;
      this.back_but.Click += new System.EventHandler(this.back_but_Click);
      this.back_but.MouseEnter += new System.EventHandler(this.back_but_MouseEnter);
      this.back_but.MouseLeave += new System.EventHandler(this.back_but_MouseLeave);
      // 
      // add_costs_1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.back_but);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.expens);
      this.Controls.Add(this.incom);
      this.Name = "add_costs_1";
      this.Text = "одноразовые";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button incom;
    private System.Windows.Forms.Button expens;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button back_but;
  }
}