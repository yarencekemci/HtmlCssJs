using Lesson11_1_OOP_Ornek.Entity;

namespace Lesson11_1_OOP_Ornek.Management
{
    internal class Musteriler
    {

        public string Guncelle(MusteriEntity musteriGuncelle)
        {
            throw new NotImplementedException();
        }
        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }
        public string Kaydet(MusteriEntity musteriKaydet)
        {
            string bosMesaj = string.Empty;
            if (musteriKaydet == null)
            {
                bosMesaj = "Adi bos olamaz.";
            }
            if(bosMesaj != string.Empty)
            {
                return bosMesaj;
            }
            return musteriKaydet.Adi + "\n adli kisi" ;
            
        }
    }
}
