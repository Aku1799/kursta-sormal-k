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
  public partial class Form4 : Form
  {
    public Form4()
    {
      InitializeComponent();
    }

    private void btnParametreli_Click(object sender, EventArgs e)
    {
      double litre = Convert.ToDouble(txtBox1.Text);
      double yakit = Convert.ToDouble(txtBox2.Text);

      double sonuc = benzin(litre, yakit);
      MessageBox.Show("Tutar: " + sonuc);

    }

    double benzin(double depo, double fiyat)
    {
      return depo * fiyat;
    }

    private void btnParametresiz_Click(object sender, EventArgs e)
    {
      double tutar = benzin1();

      MessageBox.Show("Ödemeniz gereken tutar: " + tutar);
    }

    double benzin1()
    {
      double litre = Convert.ToDouble(txtBox1.Text);
      double yakit = Convert.ToDouble(txtBox2.Text);

      return litre * yakit;
      
    }
  }
}
