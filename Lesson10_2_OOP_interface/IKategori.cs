namespace Lesson10_2_OOP_interface
{
    public interface IKategori
    {
        //DI - Dependency Injection
        // Kaydet, Güncelle, IdIleGetir adındaki methodları bu interface sayfasında kodlayınız ve kategori adında bir class oluşturarak bu interface (IKategori) sayfasını kategori class'ına implement ediniz.
        //kaydet- adi aciklama
        //guncelle- id, adi, aciklama
        //IdIleGetir - id parametreleri olacak

        void Kaydet(string adi, string aciklama);
        void Guncelle(int id, string adi, string aciklama);
        int IdIleGetir(int id);

        //interface önemli özellikler
        //1)erişim belirleyici tanımlamaya gerek yoktur
        //2)method gövdesi (kodlama yapılan alan - süslü parantezlerle) yoktur
        //3)sadece kalıtım vermek için (implement etmek için) kullanılır. kesinlikle new edilerek instance (örnekleme) ile kullanılamaz
        //4)bir class'a birden fazla interface implement edilebilir


    }
}
