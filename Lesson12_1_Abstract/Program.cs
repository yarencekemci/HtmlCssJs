namespace Lesson12_1_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // abstract - kalıtım vermek için kullanılan sınıf türüdür
            // hem gövdeli hem gövdesiz (abstract) metotlar içerebilir
            // tek başına new ile örneklenemez (instance oluşturulamaz)

            // polymorphism (çok biçimlilik) - aynı isimli metodun farklı davranışlar sergilemesi
            // inheritance + override veya overload ile sağlanır

            // override (ezme) - base class’taki bir metodu, child class’ta yeniden yazmaktır
            // aynı imza ile olur, davranış değiştirilir (runtime)

            // overload (aşırı yükleme) - aynı isimli metodun farklı parametrelerle tanımlanmasıdır
            // compile time’da belirlenir

            // override vs overload farkı:
            // override -> kalıtım gerekir, aynı imza, farklı davranış (runtime)
            // overload -> kalıtım şart değil, farklı parametre, aynı isim (compile time)

            Mercedes mercedes = new Mercedes();
            mercedes.FullPaket();

            BMW bmw = new BMW();
            bmw.FullPaket();
            bmw.Tarih = Convert.ToDateTime("01.05.2026");
            bmw.Kaydet();
        }
    }
}
