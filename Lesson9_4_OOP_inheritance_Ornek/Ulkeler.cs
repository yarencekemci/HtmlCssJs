namespace Lesson9_4_OOP_inheritance_Ornek
{
    public class Ulkeler
    {
        public string Tarih(string tarihAciklama)
        {
            return "ülke tarihi: " + tarihAciklama;
        }

        public double YillikHasilat(double deger)
        {
            Console.WriteLine("girilen yıllık hasılat: ");
            return deger;
        }

        public void Bayrak(string bayrakRenkleri)
        {
            Console.WriteLine("girilen bayrak renkleri: " +bayrakRenkleri);
        }

        public void Baskent(string baskent)
        {
            Console.WriteLine("");
        }
    }
}
