namespace pazar17
{
  partial class Form1
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
      this.txtBox1 = new System.Windows.Forms.TextBox();
      this.txtBox2 = new System.Windows.Forms.TextBox();
      this.btnTopla = new System.Windows.Forms.Button();
      this.btnCikart = new System.Windows.Forms.Button();
      this.btnCarp = new System.Windows.Forms.Button();
      this.btnBol = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtBox1
      // 
      this.txtBox1.ForeColor = System.Drawing.SystemColors.WindowText;
      this.txtBox1.Location = new System.Drawing.Point(187, 29);
      this.txtBox1.Name = "txtBox1";
      this.txtBox1.Size = new System.Drawing.Size(100, 20);
      this.txtBox1.TabIndex = 0;
      // 
      // txtBox2
      // 
      this.txtBox2.Location = new System.Drawing.Point(187, 101);
      this.txtBox2.Name = "txtBox2";
      this.txtBox2.Size = new System.Drawing.Size(100, 20);
      this.txtBox2.TabIndex = 1;
      // 
      // btnTopla
      // 
      this.btnTopla.Location = new System.Drawing.Point(123, 154);
      this.btnTopla.Name = "btnTopla";
      this.btnTopla.Size = new System.Drawing.Size(97, 81);
      this.btnTopla.TabIndex = 2;
      this.btnTopla.Text = "Topla";
      this.btnTopla.UseVisualStyleBackColor = true;
      this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
      // 
      // btnCikart
      // 
      this.btnCikart.Location = new System.Drawing.Point(259, 154);
      this.btnCikart.Name = "btnCikart";
      this.btnCikart.Size = new System.Drawing.Size(97, 81);
      this.btnCikart.TabIndex = 3;
      this.btnCikart.Text = "Çıkart";
      this.btnCikart.UseVisualStyleBackColor = true;
      this.btnCikart.Click += new System.EventHandler(this.btnCikart_Click);
      // 
      // btnCarp
      // 
      this.btnCarp.Location = new System.Drawing.Point(123, 262);
      this.btnCarp.Name = "btnCarp";
      this.btnCarp.Size = new System.Drawing.Size(97, 81);
      this.btnCarp.TabIndex = 4;
      this.btnCarp.Text = "Çarp";
      this.btnCarp.UseVisualStyleBackColor = true;
      this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
      // 
      // btnBol
      // 
      this.btnBol.Location = new System.Drawing.Point(259, 262);
      this.btnBol.Name = "btnBol";
      this.btnBol.Size = new System.Drawing.Size(97, 81);
      this.btnBol.TabIndex = 5;
      this.btnBol.Text = "Böl";
      this.btnBol.UseVisualStyleBackColor = true;
      this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.ForeColor = System.Drawing.Color.Red;
      this.label1.Location = new System.Drawing.Point(146, 36);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(33, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Sayı1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.ForeColor = System.Drawing.Color.Red;
      this.label2.Location = new System.Drawing.Point(146, 108);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(33, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Sayı2";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::pazar17.Properties.Resources.impala2;
      this.ClientSize = new System.Drawing.Size(467, 375);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnBol);
      this.Controls.Add(this.btnCarp);
      this.Controls.Add(this.btnCikart);
      this.Controls.Add(this.btnTopla);
      this.Controls.Add(this.txtBox2);
      this.Controls.Add(this.txtBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtBox1;
    private System.Windows.Forms.TextBox txtBox2;
    private System.Windows.Forms.Button btnTopla;
    private System.Windows.Forms.Button btnCikart;
    private System.Windows.Forms.Button btnCarp;
    private System.Windows.Forms.Button btnBol;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}

