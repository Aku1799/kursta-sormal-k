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
  public partial class Form3 : Form
  {
    public Form3()
    {
      InitializeComponent();
    }

    private void btnParametresiz_Click(object sender, EventArgs e)
    {
      double zamlifiyat = hesaplama();

      MessageBox.Show("Yeni Fiyat: " + zamlifiyat);

    }

    double hesaplama()
    {
      double urunf = Convert.ToDouble(txtBox1.Text);
      double zam = Convert.ToDouble(txtBox2.Text);

      double yenif = urunf + (urunf * (zam / 100));
      
      return yenif;

    }

    private void btnParametreli_Click(object sender, EventArgs e)
    {
      double sayi1 = Convert.ToDouble(txtBox1.Text);
      double sayi2 = Convert.ToDouble(txtBox2.Text);

      double yfiyat = fiyat(sayi1, sayi2);

      MessageBox.Show("Yeni Fiyat: " + yfiyat);


    }

    double fiyat(double urunf , double zam)
    {

      double sonuc = urunf + (urunf * (zam / 100));

      return sonuc;
    }
  }
}
