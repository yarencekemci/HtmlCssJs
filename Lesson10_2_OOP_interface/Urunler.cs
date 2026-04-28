namespace Lesson10_2_OOP_interface
{
    internal class Urunler : IUrunler,IKategori
    //Yukarıda Urunler sınıfına iki farklı interface (IUrunler ve IKategori) implement edilmiştir. C#’ta bir sınıf aynı anda birden fazla interface’i implement edebilir. Ancak klasik sınıf kalıtımında (class inheritance) bir sınıf yalnızca tek bir sınıftan miras alabilir; birden fazla sınıftan kalıtım verilmesi mümkün değildir.
    //1)Inheritance işleminde sadece bir tane izin verirken, implement için birden fazla verilebilir



    //bu şekilde interface kalıtım verirken implement olur, implement edilen sayfa altında bulunan method, değişken, property'ler bu class altında gözükmelidir bu da implement esnasında oto yapılır
    {
        public string Guncelle(int id, string adi, double fiyat)
        {
            throw new NotImplementedException();
        }

        public string Kaydet(string adi, double fiyat, DateTime tarih)
        {
            throw new NotImplementedException();
        }
        public string List(bool aktif)
        {
            throw new NotImplementedException();
        }
    }
}
