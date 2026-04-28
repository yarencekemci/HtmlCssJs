using System.Threading.Channels;

namespace Lesson10_1_OOP_property
{
    public class Urunler
    {
        public void Kaydet()
        {
            Console.WriteLine("Kayıt işlemi için method");
        }

        //ürün için özellik(property) ler mevcut ve aşağıdaki gibi tanımlanır
        public int Id { get; set; }
        public string Adi { get; set; }      
        public DateTime EklenmeTarih { get; set; }
        public double Fiyat { get; set; }
        public int Adet { get; set; }
        // public double SatisFiyati { get; set; }
        private double _satisFiyati;

        public double SatisFiyati 
        {
            get //SatisFiyati çağrıldığında bu alana düşer
            { return _satisFiyati; }
            set 
            {
                
                //_satisFiyati = value * 1.25;
                //fiyat
                //1000 altında ise %20 uygula,
                //1000-5000 ise %21,
                //5000-7000 ise %22,
                //7000-9000 ise %23,
                //9.000 -10.000  ise %24
                //10.000  üstü ise %25
                if (value > 0 && value < 1000)
                {
                    _satisFiyati = value * 1.20;
                }
                else if (value >= 1000 && value < 5000)
                {
                    _satisFiyati = value * 1.21;
                }
                else if (value >= 5000 && value < 7000)
                {
                    _satisFiyati = value * 1.22;
                }
                else if (value >= 7000 && value < 9000)
                {
                    _satisFiyati = value * 1.23;
                }
                else if (value >= 9000 && value < 10000)
                {
                    _satisFiyati = value * 1.24;
                }
                else
                {
                    _satisFiyati = value * 1.25;
                }
            } //? Düzenleme
        }

    }
}
