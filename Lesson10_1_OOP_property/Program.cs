using System.Security.Cryptography.X509Certificates;

namespace Lesson10_1_OOP_property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urunler urunler1 = new Urunler();
            urunler1.Id = 1;
            urunler1.Adi = "Monitör";
            urunler1.Fiyat = 9000; // alış fiyatı
            urunler1.Adet = 45;
            // urunler1.SatisFiyati = urunler1.Fiyat * 1.25;
            urunler1.SatisFiyati = urunler1.Fiyat;
            urunler1.EklenmeTarih = DateTime.Now;

            Console.WriteLine(urunler1.Id);
            Console.WriteLine(urunler1.Adi);
            Console.WriteLine(urunler1.Fiyat);
            Console.WriteLine(urunler1.EklenmeTarih);

            Urunler urunler2 = new Urunler();
            urunler2.Id = 2;
            urunler2.Adi = "klavye";
            urunler2.Fiyat = 750;
            urunler2.Adet = 15;
            urunler2.EklenmeTarih = DateTime.Now;
            UrunDoldur(urunler2);

            
        }
        public static void UrunDoldur(Urunler urunler)
        {
            Console.WriteLine("---" + urunler.Adi + "---");
            Console.WriteLine("Id: " + urunler.Id);
            Console.WriteLine("Alış fiyatı: " + urunler.Fiyat);
            Console.WriteLine("Satış fiyatı: " + urunler.SatisFiyati);
            Console.WriteLine("Stok: " + urunler.Fiyat);
            Console.WriteLine("Eklenme Tarihi: "+ urunler.EklenmeTarih);
        }
    }
}
