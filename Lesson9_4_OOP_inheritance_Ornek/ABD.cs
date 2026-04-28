namespace Lesson9_4_OOP_inheritance_Ornek
{
    public class ABD: Denizli_Ulkeler
    {
        public ABD()
        {
            Console.WriteLine("ABD");
        }
        public void KantonSayisi(byte sayi)
        {
            Console.WriteLine("ülke için girilen kanton sayısı: " + sayi);
        }
        
        // aşağıdaki method DenizliUlkeler kalıtım veren class'a taşındı, burada tutmaya gerek yok
        //public void DenizKiyiSayisi(byte sayi)
        //{
        //    Console.WriteLine("ülke için girilen deniz kıyı sayısı: " + sayi);
        //}

    }
}
