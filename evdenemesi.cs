    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvDenemeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try

            { 
            //Console.Write("1. Sayıyı Giriniz ");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sayıyı Giriniz ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int sonuc = sayi1 + sayi2;

            //Console.WriteLine("Sonuc: " + sonuc);


            //Console.Write("1. Sayıyı Giriniz ");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sayıyı Giriniz ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz işlem nedir? (+,-,*,/)");
            //char islem = Convert.ToChar(Console.ReadLine());

            //switch (islem)
            //{
            //    case '+':
            //        int toplam = sayi1 + sayi2;
            //        Console.WriteLine("İşlemin sonucu:"+toplam);
            //        break;
            //    case '-':
            //        int cıkartma = sayi1 - sayi2;
            //        Console.WriteLine("İşlemin sonucu:" + cıkartma);
            //        break;
            //    case '*':
            //        int carpma = sayi1 * sayi2;
            //        Console.WriteLine("İşlemin sonucu:" + carpma);
            //        break;
            //    case '/':
            //        int bolme = sayi1 / sayi2;
            //        Console.WriteLine("İşlemin sonucu:" + bolme);
            //        break;

            //    default:
            //        Console.WriteLine("İstenen değer girilmedi");
            //        break;
            //}



            //Console.WriteLine("1-> Çay , 2-> Kahve, 3-> Su");
            //Console.Write("Seçmek istediğiniz ürünün numarasını giriniz:");
            //int urun = int.Parse(Console.ReadLine());

            //switch (urun)
            //{
            //    case 1:
            //        Console.WriteLine("Çay seçtiniz");
            //        break;
            //    case 2:
            //        Console.WriteLine("Kahve seçtiniz");
            //        break;
            //    case 3:
            //        Console.WriteLine("Su seçtiniz");
            //        break;

            //    default:
            //        Console.WriteLine("Yanlış tuşa bastınız");
            //        break;
            //}


            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 10 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //for (int i = 0; i < 50; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int toplam = 0;

            //for (int i = 1; i < 500; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        toplam+= i;

            //    }


            //}

            //Console.WriteLine("Toplam Sonucu" + toplam);

            //Console.Write("Bitiş değeri kaç olsun? ");
            //int bitis = int.Parse(Console.ReadLine());
            //Console.Write("İlk bölme değeri kaç olsun? ");
            //int b1 = int.Parse(Console.ReadLine());
            //Console.Write("İkinci bölme değeri kaç olsun? ");
            //int b2 = int.Parse(Console.ReadLine());
            //int adet = 0;

            //int toplam = 0;
            //for (int i = 1; i < bitis; i++) 
            //{
            //    if (i%b1 == 0 && i%b2 == 0)
            //    {
            //        toplam += i;
            //        Console.WriteLine("Sayi" + i);
            //        adet++;
            //    }


            //}

            //Console.WriteLine("İşlem Sonucu" +toplam);
            //Console.WriteLine("Sayı Adedi" + adet);

            //Random rnd = new Random();
            //int sayi = 0 , toplam10 = 0, toplam23=0 ;

            //for (int i = 1; i < 100; i++)
            //{
            //    sayi = rnd.Next(1,50);
            //    if (sayi %10 == 0)
            //    {
            //        toplam10 += i;
            //    }
            //    if (sayi %2 == 0 && sayi%3==0)
            //    {
            //        toplam23 += i;
            //    }

            //}
            //int sonuc = toplam10 - toplam23;
            //Console.WriteLine("İşlem Sonucu; " + sonuc);

            //Random rnd = new Random();
            //int baslangic = 1, sayi = 0, adet = 0;

            //while (baslangic <= 25) 
            //{ 
            //    sayi = rnd.Next(1,100);
            //    if (sayi%3==0 || sayi%5==0)
            //    {
            //        Console.WriteLine(sayi);
            //        adet++;
            //    }    

            //    baslangic++;
            //}

            ////Console.Write("Ve için-> a, Veya için ->b");
            ////char secim = Convert.ToChar(Console.ReadLine());  SORSORSORSORSORSORSORSORSOR

            //Console.Write("İlk değerini giriniz: ");
            //int ilk = int.Parse(Console.ReadLine());
            //Console.Write("Sınır değerini giriniz: ");
            //int sinir = int.Parse(Console.ReadLine());
            //Console.Write("Kaç sayı olsun giriniz: ");
            //int rastgele = int.Parse(Console.ReadLine());
            //Console.Write("İlk bölme değeri kaç olsun? ");
            //int b1 = int.Parse(Console.ReadLine());
            //Console.Write("İkinci bölme değeri kaç olsun? ");
            //int b2 = int.Parse(Console.ReadLine());
            //int sayi = 0 , toplam= 0, adet=0;


            //int baslangic = 1;

            //Random random = new Random();

            //while (baslangic<=rastgele)
            //{
            //    sayi=random.Next(ilk,sinir);
            //    if (sayi%b1==0 && sayi%b2==0)
            //    {
            //      toplam += sayi;
            //      adet++;
            //      Console.WriteLine("Sayılar:" +sayi);
            //    }
            //    baslangic++;

            //}

            //Console.WriteLine("İşlem Sonucu: " + toplam);

            //Console.Write("Hangi mevsim aylarını görmek istiyorsunuz? ");
            //string mevsimler = Console.ReadLine();

            //string[] aylar = { "ocak", "şubat","mart","nisan","mayıs","haziran","temmuz","ağustos","eylül","ekim","kasım","aralık"};

            //switch (mevsimler)
            //{
            //    case "kış":
            //        Console.WriteLine(aylar[11] + " " + aylar[0] + " " + aylar[1]);
            //        break;
            //    case "ilkbahar":
            //        Console.WriteLine(aylar[2] + " " + aylar[3] + " " + aylar[4]);
            //        break;
            //    case "yaz":
            //        Console.WriteLine(aylar[5] + " " + aylar[6] + " " + aylar[7]);
            //        break;
            //    case "sonbahar":
            //        Console.WriteLine(aylar[8] + " " + aylar[9] + "  " + aylar[10]);
            //        break;
            //    default:
            //        Console.WriteLine("Yanlış ifade girdiniz!");
            //        break;
            //}

            Console.WriteLine("Dizi boyutu kaç olsun? ");
            int sayi = int.Parse(Console.ReadLine());

            int[] sayilar = new int[sayi];

            Random rastgele = new Random();
            int adet = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rastgele.Next(1, 200);
            }

            foreach (var item in sayilar)
            {
                if (item >= 100 && item <= 200)
                {
                    adet++;
                }
            }
            Console.WriteLine("100-200 arası sayı adedi: " + adet);







            Console.ReadKey();
        }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);   
            }
        }
    }
}
