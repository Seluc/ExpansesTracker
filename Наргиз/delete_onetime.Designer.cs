
namespace GroupProj.Наргиз {
  partial class delete_onetime {
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
      this.lbOneTime = new System.Windows.Forms.ListBox();
      this.back_but = new System.Windows.Forms.Button();
      this.btDelete = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lbOneTime
      // 
      this.lbOneTime.FormattingEnabled = true;
      this.lbOneTime.ItemHeight = 16;
      this.lbOneTime.Location = new System.Drawing.Point(55, 39);
      this.lbOneTime.Name = "lbOneTime";
      this.lbOneTime.Size = new System.Drawing.Size(328, 388);
      this.lbOneTime.TabIndex = 0;
      this.lbOneTime.SelectedIndexChanged += new System.EventHandler(this.lbOneTime_SelectedIndexChanged);
      // 
      // back_but
      // 
      this.back_but.Location = new System.Drawing.Point(718, 389);
      this.back_but.Name = "back_but";
      this.back_but.Size = new System.Drawing.Size(61, 49);
      this.back_but.TabIndex = 1;
      this.back_but.Text = "<";
      this.back_but.UseVisualStyleBackColor = true;
      this.back_but.Click += new System.EventHandler(this.back_but_Click);
      this.back_but.MouseEnter += new System.EventHandler(this.back_but_MouseEnter);
      this.back_but.MouseLeave += new System.EventHandler(this.back_but_MouseLeave);
      // 
      // btDelete
      // 
      this.btDelete.Location = new System.Drawing.Point(587, 322);
      this.btDelete.Name = "btDelete";
      this.btDelete.Size = new System.Drawing.Size(192, 40);
      this.btDelete.TabIndex = 2;
      this.btDelete.Text = "Удалить";
      this.btDelete.UseVisualStyleBackColor = true;
      this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
      // 
      // delete_onetime
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btDelete);
      this.Controls.Add(this.back_but);
      this.Controls.Add(this.lbOneTime);
      this.Name = "delete_onetime";
      this.Text = "Удалить";
      this.Load += new System.EventHandler(this.delete_onetime_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lbOneTime;
    private System.Windows.Forms.Button back_but;
    private System.Windows.Forms.Button btDelete;
  }
}