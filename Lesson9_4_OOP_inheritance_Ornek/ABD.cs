namespace Lesson9_4_OOP_inheritance_Ornek
{
    public class ABD:Ulkeler
    {
        public void KantonSayisi(byte sayi)
        {
            Console.WriteLine("ülke için girilen kanton sayısı: " + sayi);
        }
        public void DenizKiyiSayisi(byte sayi)
        {
            Console.WriteLine("ülke için girilen deniz kıyı sayısı: " + sayi);
        }
    }
}
