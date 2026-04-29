using Lesson11_1_OOP_Ornek.Entity;

namespace Lesson11_1_OOP_Ornek.Management
{
    internal class Urunler : IUrunler
    {
        public UrunlerEntity GetirIdIle(int id)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(UrunlerEntity urunGuncelle)
        {
            throw new NotImplementedException();
        }

        public string Kaydet(UrunlerEntity urunKaydet)
        {
            string bosMesaj = string.Empty; // string degisken icin bos verir
            if (string.IsNullOrEmpty(urunKaydet.Adi))
            {
                bosMesaj = "Ürün adi bos olamaz";
            }
            if (urunKaydet.SatisFiyat <= 0)
            {
                bosMesaj = "Ürün fiyatı 0'dan büyük olmalı";
            }
            if (urunKaydet.Stok <= 0)
            {
                bosMesaj = "\n ürün stok değeri 0'dan büyük olmalıdır";
            }
            if (bosMesaj != string.Empty)
            {
                return bosMesaj;
            }
            return urunKaydet.Adi + "olan ürün \n" + urunKaydet.SatisFiyat + "fiyat ile \n" + urunKaydet.Stok + " adet satildi";
            //Kaydet işlemi müşteri ve sipariş için burada yapıldığı gibi yapılacaktır.
        }

        public List<UrunlerEntity> List()
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            foreach (var urun in urunler)
            {
                if (urun.Id == id)
                {
                    urunler.Remove(urun); //urunu listeden siliyor
                    return true;
                }
            }

            return false; //döngü biter ama hiç eşleşme bulunmazsa

        }
    }
}
