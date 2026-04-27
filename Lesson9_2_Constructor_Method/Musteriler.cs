namespace Lesson9_2_Constructor_Method
{
    public class Musteriler
    {
        /// <summary>
        /// parametresiz yapıcı method
        /// </summary>
        public Musteriler() //constructor method herhangi bir değişken(değer döndüren) ya da void (değer döndürmeyen) içermez
        {
            Console.WriteLine("Yapıcı method hiçbir parametresi olmayan çalıştı");
        }

        /// <summary>
        /// tek parametreli yapıcı method
        /// </summary>
        /// <param name="isim"></param>
        public Musteriler(string isim)
        {
            Console.WriteLine("string değişken-parametre olan yapısı method:" +isim);
        }

        /// <summary>
        /// 2 parametreli yapıcı method
        /// </summary>
        /// <param name="isim"></param>
        /// <param name="tarih"></param>
        public Musteriler(string isim, DateTime tarih) 
        {
            
        }

        public int SiparisSayisi()
        {
            return 10;
        }
    }
}
