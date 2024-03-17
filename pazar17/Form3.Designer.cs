namespace pazar17
{
  partial class Form3
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
      this.txtBox2 = new System.Windows.Forms.TextBox();
      this.txtBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnParametresiz = new System.Windows.Forms.Button();
      this.btnParametreli = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtBox2
      // 
      this.txtBox2.Location = new System.Drawing.Point(176, 175);
      this.txtBox2.Name = "txtBox2";
      this.txtBox2.Size = new System.Drawing.Size(100, 20);
      this.txtBox2.TabIndex = 9;
      // 
      // txtBox1
      // 
      this.txtBox1.ForeColor = System.Drawing.SystemColors.WindowText;
      this.txtBox1.Location = new System.Drawing.Point(176, 129);
      this.txtBox1.Name = "txtBox1";
      this.txtBox1.Size = new System.Drawing.Size(100, 20);
      this.txtBox1.TabIndex = 8;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(113, 136);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 13);
      this.label1.TabIndex = 11;
      this.label1.Text = "Ürün Fiyatı";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(57, 182);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(113, 13);
      this.label2.TabIndex = 12;
      this.label2.Text = "Yapılması İstenen Zam";
      // 
      // btnParametresiz
      // 
      this.btnParametresiz.Location = new System.Drawing.Point(238, 226);
      this.btnParametresiz.Name = "btnParametresiz";
      this.btnParametresiz.Size = new System.Drawing.Size(97, 81);
      this.btnParametresiz.TabIndex = 14;
      this.btnParametresiz.Text = "Parametresiz Hesapla";
      this.btnParametresiz.UseVisualStyleBackColor = true;
      this.btnParametresiz.Click += new System.EventHandler(this.btnParametresiz_Click);
      // 
      // btnParametreli
      // 
      this.btnParametreli.Location = new System.Drawing.Point(102, 226);
      this.btnParametreli.Name = "btnParametreli";
      this.btnParametreli.Size = new System.Drawing.Size(97, 81);
      this.btnParametreli.TabIndex = 13;
      this.btnParametreli.Text = "Parametreli Hesapla";
      this.btnParametreli.UseVisualStyleBackColor = true;
      this.btnParametreli.Click += new System.EventHandler(this.btnParametreli_Click);
      // 
      // Form3
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::pazar17.Properties.Resources.impala2;
      this.ClientSize = new System.Drawing.Size(468, 374);
      this.Controls.Add(this.btnParametresiz);
      this.Controls.Add(this.btnParametreli);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtBox2);
      this.Controls.Add(this.txtBox1);
      this.Name = "Form3";
      this.Text = "Form3";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox txtBox2;
    private System.Windows.Forms.TextBox txtBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnParametresiz;
    private System.Windows.Forms.Button btnParametreli;
  }
}