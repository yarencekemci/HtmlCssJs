using Lesson11_1_OOP_Ornek.Entity;

namespace Lesson11_1_OOP_Ornek.Management
{
    internal interface IUrunler
    {
        // kaydet-güncelle-sil-list- GetirIdİle gibi methodlar olacak
        string Kaydet(UrunlerEntity urun);

        string Guncelle(UrunlerEntity urunGuncelle);

        bool Sil(int id);

        UrunlerEntity GetirIdIle(int id);

        List<UrunlerEntity> List();
    }
}
