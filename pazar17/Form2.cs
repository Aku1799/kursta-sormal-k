using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pazar17
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    private void btnCikart_Click(object sender, EventArgs e)
    {
      int karealan = Alan();

      MessageBox.Show("Kare Alanı: " + karealan);
    }

    int Alan()
    {
      int sayi1 = int.Parse(txtBox1.Text);
      int sonuc = sayi1 * sayi1;

      return sonuc;
    }

    private void btnTopla_Click(object sender, EventArgs e)
    {
      int sayi1 = int.Parse(txtBox1.Text);

      int sonuc = KareAlanı(sayi1);

      MessageBox.Show("Kare Alanı: " + sonuc);
    }

    int KareAlanı(int s1)
    {
      return s1 * s1;
    }
  }
}
