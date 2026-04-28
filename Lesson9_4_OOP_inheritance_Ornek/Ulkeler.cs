namespace Lesson9_4_OOP_inheritance_Ornek
{
    public class Ulkeler
    {
        public string Tarih(string tarihAciklama)
        {
            return "ülke tarihi: " + tarihAciklama;
        }

        public double YillikHasilat(double deger, string paraBirimi)
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
            Console.WriteLine("Başkent: " +baskent);
        }

        public void BilinenDaglar(params string[] dag)
        {
            for (int i = 0; i < dag.Length; i++)
            {
                Console.WriteLine("bilinen {0}.dağ:{1}", i + 1, dag[i]);
            }
        }
    }
}
