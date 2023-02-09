namespace GroupProj.Анастасия
{
  partial class add_costs_3
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
      this.summ = new System.Windows.Forms.RichTextBox();
      this.coments = new System.Windows.Forms.RichTextBox();
      this.add_button = new System.Windows.Forms.Button();
      this.back_but2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // summ
      // 
      this.summ.Location = new System.Drawing.Point(13, 54);
      this.summ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.summ.Name = "summ";
      this.summ.Size = new System.Drawing.Size(394, 50);
      this.summ.TabIndex = 22;
      this.summ.Text = "";
      this.summ.TextChanged += new System.EventHandler(this.summ_TextChanged);
      this.summ.Enter += new System.EventHandler(this.summ_Enter);
      this.summ.Leave += new System.EventHandler(this.summ_Leave);
      // 
      // coments
      // 
      this.coments.Location = new System.Drawing.Point(13, 124);
      this.coments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.coments.Name = "coments";
      this.coments.Size = new System.Drawing.Size(774, 211);
      this.coments.TabIndex = 23;
      this.coments.Text = "";
      this.coments.TextChanged += new System.EventHandler(this.coments_TextChanged);
      this.coments.Enter += new System.EventHandler(this.coments_Enter);
      this.coments.Leave += new System.EventHandler(this.coments_Leave);
      // 
      // add_button
      // 
      this.add_button.Location = new System.Drawing.Point(13, 362);
      this.add_button.Name = "add_button";
      this.add_button.Size = new System.Drawing.Size(212, 76);
      this.add_button.TabIndex = 24;
      this.add_button.Text = "добавить";
      this.add_button.UseVisualStyleBackColor = true;
      this.add_button.Click += new System.EventHandler(this.add_button_Click);
      this.add_button.MouseEnter += new System.EventHandler(this.add_button_MouseEnter);
      this.add_button.MouseLeave += new System.EventHandler(this.add_button_MouseLeave);
      // 
      // back_but2
      // 
      this.back_but2.Location = new System.Drawing.Point(726, 389);
      this.back_but2.Name = "back_but2";
      this.back_but2.Size = new System.Drawing.Size(61, 49);
      this.back_but2.TabIndex = 26;
      this.back_but2.Text = "❮";
      this.back_but2.UseVisualStyleBackColor = true;
      this.back_but2.Click += new System.EventHandler(this.back_but2_Click);
      this.back_but2.MouseEnter += new System.EventHandler(this.back_but2_MouseEnter);
      this.back_but2.MouseLeave += new System.EventHandler(this.back_but2_MouseLeave);
      // 
      // add_costs_3
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.back_but2);
      this.Controls.Add(this.add_button);
      this.Controls.Add(this.coments);
      this.Controls.Add(this.summ);
      this.Name = "add_costs_3";
      this.Text = "добавить одноразовый расход";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RichTextBox summ;
    private System.Windows.Forms.RichTextBox coments;
    private System.Windows.Forms.Button add_button;
    private System.Windows.Forms.Button back_but2;
  }
}