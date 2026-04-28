namespace Lesson10_2_OOP_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Urunler urunler = new Urunler();
            //IUrunler x = new IUrunler(); interface new ile çağrılıp kullanılamaz, sadece kalıtım (implement) vermek için kullanılır
            //IKategori kategori = new IKategori(); //hata -- "abstract ya da interface olan bir sayfayı instance olarak tanımlayamazsınız" hatası verir
            //Abstraction (soyutlama), karmaşık bir sistemin gereksiz detaylarını gizleyerek, sadece temel işlevlere veya öz modele odaklanma sürecidir.
            // Abstraction in Object-Oriented Programming (OOP) is the design principle of hiding complex implementation details and exposing only essential features, simplifying interaction with systems.


            Kategori getirKategori = new Kategori();
            getirKategori.IdIleGetir(10);
        }
    }
}
