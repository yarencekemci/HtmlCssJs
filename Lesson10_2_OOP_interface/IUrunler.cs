namespace Lesson10_2_OOP_interface
{
    public interface IUrunler
    {
        //interface imza, arayüz olarak projelerde görebilirsiniz
        //interface sadece kalıtım vermek için kullanılır(implement), new ile çağrılıp kullanılamaz
        //methodlar sadece gövdesiz olarak yazılır, hiç bir methodun kod yapısı burda yazılmaz

        public string Kaydet(string adi, double fiyat, DateTime tarih);//implement edecek method
        public string Guncelle(int id, string adi, double fiyat);//implement edecek method
        public string List(bool aktif);

    }
}
