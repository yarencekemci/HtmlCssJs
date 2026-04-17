namespace Lesson8_1_Class;

internal class Ogrenci
{
    /*
     Access Modifiers — Erişim Belirleyiciler 
    public, internal, protected, ve private
     */
    public void BilgileriGetir(string isim, string adres)
    {
        Console.WriteLine("Adı:" +isim);
        Console.WriteLine("Soyadı" +adres);
    }
    public int YasHesapla(DateTime dogumTarih)
    {
        int hesapla = DateTime.Now.Year - dogumTarih.Year;
        return hesapla;
    }
}
