namespace pazar17
{
  partial class Form4
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
      this.btnParametresiz = new System.Windows.Forms.Button();
      this.btnParametreli = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtBox2 = new System.Windows.Forms.TextBox();
      this.txtBox1 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnParametresiz
      // 
      this.btnParametresiz.Location = new System.Drawing.Point(252, 190);
      this.btnParametresiz.Name = "btnParametresiz";
      this.btnParametresiz.Size = new System.Drawing.Size(97, 81);
      this.btnParametresiz.TabIndex = 20;
      this.btnParametresiz.Text = "Parametresiz Hesapla";
      this.btnParametresiz.UseVisualStyleBackColor = true;
      this.btnParametresiz.Click += new System.EventHandler(this.btnParametresiz_Click);
      // 
      // btnParametreli
      // 
      this.btnParametreli.Location = new System.Drawing.Point(116, 190);
      this.btnParametreli.Name = "btnParametreli";
      this.btnParametreli.Size = new System.Drawing.Size(97, 81);
      this.btnParametreli.TabIndex = 19;
      this.btnParametreli.Text = "Parametreli Hesapla";
      this.btnParametreli.UseVisualStyleBackColor = true;
      this.btnParametreli.Click += new System.EventHandler(this.btnParametreli_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(111, 146);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 13);
      this.label2.TabIndex = 18;
      this.label2.Text = "Yakıt Fiyatı (L)";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(121, 96);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 13);
      this.label1.TabIndex = 17;
      this.label1.Text = "Depo Litresi";
      // 
      // txtBox2
      // 
      this.txtBox2.Location = new System.Drawing.Point(190, 139);
      this.txtBox2.Name = "txtBox2";
      this.txtBox2.Size = new System.Drawing.Size(100, 20);
      this.txtBox2.TabIndex = 16;
      // 
      // txtBox1
      // 
      this.txtBox1.ForeColor = System.Drawing.SystemColors.WindowText;
      this.txtBox1.Location = new System.Drawing.Point(190, 93);
      this.txtBox1.Name = "txtBox1";
      this.txtBox1.Size = new System.Drawing.Size(100, 20);
      this.txtBox1.TabIndex = 15;
      // 
      // Form4
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::pazar17.Properties.Resources.impala2;
      this.ClientSize = new System.Drawing.Size(465, 375);
      this.Controls.Add(this.btnParametresiz);
      this.Controls.Add(this.btnParametreli);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtBox2);
      this.Controls.Add(this.txtBox1);
      this.Name = "Form4";
      this.Text = "Form4";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnParametresiz;
    private System.Windows.Forms.Button btnParametreli;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtBox2;
    private System.Windows.Forms.TextBox txtBox1;
  }
}