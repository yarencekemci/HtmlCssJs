namespace Lesson9_1_Static_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urunler urunClass = new Urunler(); //instance (örnekleme)
            urunClass.Kaydet();
            //static tanımlı bir method örneklenemez
            //kullanicilar kulClass = new Kullanicilar(); Kullanicilar class'ı static tanımlı olduğundan bu şekilde kullanımına izin vermez
            //static için new yapılmaz, class adı yazılarak ardında method direkt çağırılır. 

            Kullanicilar.GetirAdSoyad();

            Siparisler siparisClass = new Siparisler();
            siparisClass.SiparisListesi();

            Siparisler.SiparisAdeti(); //SiparisAdet() methodu static tanımlı olduğundan sadece static tanımlı olan methodları class'ını newlemeden method bu şekilde kullanabilirsiniz 
            // static için bazı kurallar
            /*
             1- static method için altında static olmayan method kullanılamaz
             2- static olan bir class altında method'lar static olmalıdır ama static olmayan class altında static method yazılabilir
             */
        }
    }
}
