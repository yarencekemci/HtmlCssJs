namespace Lesson9_3_OOP_Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Nesne Yönelimli Programlama (OOP) -Object-Oriented Programming-, verileri ve fonksiyonları "nesne" (object) adı verilen yapılar içinde kapsülleyerek gerçek dünya varlıklarını modelleyen bir yazılım yaklaşımıdır.
            Kalıtım (Inheritance) 
            Property - Özellik
            Interface - Arayüz, imza
            Abstract - Soyutlama
            Polimorfizm - Çok biçimlilik
             */

            Kullanicilar kullaniciClass = new Kullanicilar();
            kullaniciClass.EklenmeTarihi();
            kullaniciClass.GuncellenmeTarihi();

            Urunler urunlerClass = new Urunler();
            urunlerClass.EklemeTarihi();
            urunlerClass.GuncellenmeTarihi();
        }
    }
}
