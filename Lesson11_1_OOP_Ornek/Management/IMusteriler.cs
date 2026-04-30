using Lesson11_1_OOP_Ornek.Entity;

namespace Lesson11_1_OOP_Ornek.Management
{
    internal interface IMusteriler
    {
        string Kaydet(MusteriEntity musteri);
        string Guncelle(MusteriEntity musteriGuncelle);
        bool Sil(int id);

    }
}
