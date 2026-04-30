using Lesson11_1_OOP_Ornek.Entity;

namespace Lesson11_1_OOP_Ornek.Management
{
    internal class Urunler : IUrunler
    {
        public void Deneme()
        {
            //Eğer IUrunler altında bir method varsa implement edilen classta (Urunler olmak zorundadır) ama urunler class'ında olan method IUrunler'de(interface) te yoksa hata vermez ama bu şekilde kodlanması önerilmez.
            //Deneme methodu IUrunler altında yok ve hata da vermez ama bu şekilde bir method kodlanması Interface yapısı kısmı olarak yok saymış olursunuz.
         }
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
            return urunKaydet.Adi + "\t olan ürün \n" + urunKaydet.BirimFiyat + " alış fiyati ile \n " + urunKaydet.Stok + "adet eklendi \n Eklenme Tarihi: " + urunKaydet.EklenmeTarihi;
            //Kaydet işlemi müşteri ve sipariş için burada yapıldığı gibi yapılacaktır.
        }

        public List<UrunlerEntity> List()
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
