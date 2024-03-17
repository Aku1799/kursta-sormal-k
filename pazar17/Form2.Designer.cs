namespace pazar17
{
  partial class Form2
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
      this.label1 = new System.Windows.Forms.Label();
      this.btnCikart = new System.Windows.Forms.Button();
      this.btnTopla = new System.Windows.Forms.Button();
      this.txtBox1 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(67, 78);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(86, 13);
      this.label1.TabIndex = 14;
      this.label1.Text = "Karenin 1 Köşesi";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnCikart
      // 
      this.btnCikart.Location = new System.Drawing.Point(239, 182);
      this.btnCikart.Name = "btnCikart";
      this.btnCikart.Size = new System.Drawing.Size(97, 81);
      this.btnCikart.TabIndex = 11;
      this.btnCikart.Text = "Parametresiz Hesapla";
      this.btnCikart.UseVisualStyleBackColor = true;
      this.btnCikart.Click += new System.EventHandler(this.btnCikart_Click);
      // 
      // btnTopla
      // 
      this.btnTopla.Location = new System.Drawing.Point(103, 182);
      this.btnTopla.Name = "btnTopla";
      this.btnTopla.Size = new System.Drawing.Size(97, 81);
      this.btnTopla.TabIndex = 10;
      this.btnTopla.Text = "Parametreli Hesapla";
      this.btnTopla.UseVisualStyleBackColor = true;
      this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
      // 
      // txtBox1
      // 
      this.txtBox1.ForeColor = System.Drawing.SystemColors.WindowText;
      this.txtBox1.Location = new System.Drawing.Point(159, 71);
      this.txtBox1.Name = "txtBox1";
      this.txtBox1.Size = new System.Drawing.Size(100, 20);
      this.txtBox1.TabIndex = 8;
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::pazar17.Properties.Resources.impala2;
      this.ClientSize = new System.Drawing.Size(461, 374);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCikart);
      this.Controls.Add(this.btnTopla);
      this.Controls.Add(this.txtBox1);
      this.Name = "Form2";
      this.Text = "Form2";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnCikart;
    private System.Windows.Forms.Button btnTopla;
    private System.Windows.Forms.TextBox txtBox1;
  }
}