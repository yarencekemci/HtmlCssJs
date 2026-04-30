using Lesson11_1_OOP_Ornek.Entity;
using Lesson11_1_OOP_Ornek.Management;


namespace Lesson11_1_OOP_Ornek;

internal class Program
{
    static void Main(string[] args)
    {


        UrunIslemleri();
        MusteriIslemleri();
        Console.ReadLine();

    }
    static void MusteriIslemleri()
    {
        //3 müşteri ekleyen IMusteriler, Musteriler sayfa yapıları ile tanımlayarak bu kısımda çağırıp kullanınız.?


        Musteriler musteriEkle = new Musteriler();

        MusteriEntity musteri = new MusteriEntity();
        musteri.Id = 1;
        musteri.Adi = "Yaren";
        musteri.Soyadi = "X";
        musteri.Meslek = "Bilgi İslem";
        musteri.Il = "İstanbul";
        musteri.Ilce = "Kartal";
        musteri.Telefon = " 05555555 ";
        musteri.Adres = "Merkez";

        MusteriEntity musteri1 = new MusteriEntity();
        musteri1.Id = 1;
        musteri1.Adi = "Sevde";
        musteri1.Soyadi = "Isıl";
        musteri1.Meslek = "Muhasebe";
        musteri1.Il = "İstanbul";
        musteri1.Ilce = "Büyükcekmece";
        musteri1.Telefon = " 02234234 ";
        musteri1.Adres = "Merkez";

        MusteriEntity musteri2 = new MusteriEntity();
        musteri2.Id = 1;
        musteri2.Adi = "Remzi";
        musteri2.Soyadi = "Yagcı";
        musteri2.Meslek = "Muhasebe";
        musteri2.Il = "İstanbul";
        musteri2.Ilce = "Büyükcekmece";
        musteri2.Telefon = " 235234234 ";
        musteri2.Adres = "Merkez";



    }


    static void UrunIslemleri()
    {
        /*

    */
        //IUrunler iurunler =  new IUrunler(); interface olarak sayfa tipi tanımlanmış ve bu nedenle new lenemez.
        BaseEntity baseEntity = new BaseEntity(); // kalıtım veren class newlenebilir çünkü sayfa özelliği class olarak oluşturulmuş
                                                  // Urunler sınıfı class olarak tanımlandığı için nesnesi oluşturulabilir.
        Urunler urunler = new Urunler();


        // Property Kullanımı:
        // Entity katmanı altındaki class'lar, diğer class'lar içinde property olarak tanımlanabilir.
        // Böylece nesneler arasında ilişki kurulabilir.


        // Management Katmanı:
        // Bu katmanda interface'ler tanımlanır.
        // Ayrıca CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştiren class'lar bulunur.
        // Bu class'lar ilgili interface'leri implement ederek işlemleri somut hale getirir.

        UrunlerEntity urunlerEkle = new UrunlerEntity();
        urunlerEkle.Id = 1; //BaseEntity'den alır - kalıtımdan alır
        urunlerEkle.Adi = "Monitor"; // UrunlerEntity
        urunlerEkle.Stok = 15; // UrunlerEntity
        urunlerEkle.EklenmeTarihi = DateTime.Now; // UrunlerEntity
        urunlerEkle.BirimFiyat = 9000; // UrunlerEntity
        urunlerEkle.SatisFiyat = 14000; // UrunlerEntity = Kalıtım alan class

        Console.WriteLine(urunler.Kaydet(urunlerEkle));

        UrunlerEntity urunlerEkle1 = new UrunlerEntity();
        urunlerEkle1.Id = 2; //BaseEntity'den alır - kalıtımdan alır
        urunlerEkle1.Adi = "Klavye";
        urunlerEkle1.Stok = 9;
        urunlerEkle1.EklenmeTarihi = DateTime.Now; //BaseEntity'den alır - kalıtımdan alır
        urunlerEkle1.BirimFiyat = 2250;
        urunlerEkle1.SatisFiyat = 3750;

        Console.WriteLine(urunler.Kaydet(urunlerEkle1));
    }
}

