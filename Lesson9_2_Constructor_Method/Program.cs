namespace Lesson9_2_Constructor_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            constructor (yapıcı) method nedir?
            her class altında oluşturulabilen bir method çeşididir.
            1- değer döndürme değişkenleri ya da void anahtar kelimesi içermeyen ve class ile aynı adı taşıyan method olmalıdır.
            2- overload olabilirler (aşırı yüklenmiş method)
            3- class newlnwdigi gibi (instance - örnekleme) yapıldığı gibi kullanılır, bir method gibi bağımsız adı yazılarak kullanılamaz

            */

            Musteriler musterClass = new Musteriler();
            Musteriler musterClass2 = new Musteriler("constructor method tek değişken");

            Console.ReadLine();
        }
    }
}
