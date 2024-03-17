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
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnTopla_Click(object sender, EventArgs e)
    {
      int sayi1 = int.Parse(txtBox1.Text);
      int sayi2 = int.Parse(txtBox2.Text);

      int sonuc = Topla(sayi1,sayi2);
      MessageBox.Show("İşlem Sonucu: " + sonuc);

    }

    int Topla (int s1, int s2)
    {
      return s1 + s2;
    }

    private void btnCikart_Click(object sender, EventArgs e)
    {
      int sayi1 = int.Parse(txtBox1.Text);
      int sayi2 = int.Parse(txtBox2.Text);

      int sonuc = Cikart(sayi1, sayi2);
      MessageBox.Show("İşlem Sonucu: " + sonuc);
    }
    int Cikart(int s1, int s2)
    {
      if (s1>s2)
      {
        return s1 - s2;
      }
      else
      {
        return s2 - s1;
      }
     
    }

    private void btnCarp_Click(object sender, EventArgs e)
    {
      int sayi1 = int.Parse(txtBox1.Text);
      int sayi2 = int.Parse(txtBox2.Text);

      int sonuc = Carp(sayi1, sayi2);
      MessageBox.Show("İşlem Sonucu: " + sonuc);
    }
    int Carp(int s1, int s2)
    {
      return s1 * s2;
    }

    private void btnBol_Click(object sender, EventArgs e)
    {
      double sayi1 = Convert.ToDouble(txtBox1.Text);
      double sayi2 = Convert.ToDouble(txtBox2.Text);

      double sonuc = Bol(sayi1, sayi2);
      MessageBox.Show("İşlem Sonucu: " + sonuc);
    }
    double Bol(double s1, double s2)
    {
      return s1 / s2;
    }

  }
}
