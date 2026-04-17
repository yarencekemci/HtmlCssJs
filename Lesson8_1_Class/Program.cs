namespace Lesson8_1_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenciClass = new Ogrenci();//örnekleme(instance) 
            ogrenciClass.BilgileriGetir("Ahmet", "İstanbul Kartal Ellinci sokak");
            //******************************************************************
            Console.WriteLine("Adınızı giriniz?");
            string ad = Console.ReadLine();

            Console.WriteLine("Doğum tarihini gg.aa.yyyy formatında giriniz?");
            DateTime dTarihi = Convert.ToDateTime(Console.ReadLine());

            ogrenciClass.BilgileriGetir(ad, null);
            int yas = ogrenciClass.YasHesapla(dTarihi);
            Console.WriteLine("Yaşınız Hesaplandı:" + yas);

        }
    }
}
