namespace Lesson9_4_OOP_inheritance_Ornek
{
    public class Turkiye:Ulkeler
    {
        /// <summary>
        /// birden fazla boğaz varsa \n ile ayırın
        /// </summary>
        /// <param name="bogazAdi"></param>
        public void DenizleriBaglayanBogaz(string bogazAdi)
        {
            Console.WriteLine(bogazAdi);
        }
        public void DenizKiyiSayisi(byte sayi)
        {
            Console.WriteLine("ülke için girilen deniz kıyı sayısı: " + sayi);
        }
    }
}
