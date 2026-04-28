namespace Lesson10_2_OOP_interface
{
    internal class Urunler : IUrunler//bu şekilde interface kalıtım verirken implement olur, implement edilen sayfa altında bulunan method, değişken, property'ler bu class altında gözükmelidir bu da implement esnasında oto yapılır
    {
        public string Guncelle(int id, string adi, double fiyat)
        {
            throw new NotImplementedException();
        }

        public string Kaydet(string adi, double fiyat, DateTime tarih)
        {
            throw new NotImplementedException();
        }
    }
}
