namespace Lesson12_1_Abstract
{
    public abstract class Araba
    {
        public string Adi { get; set; }

        private DateTime _tarih;

        public DateTime Tarih
        {
            get { return _tarih; }
            set { value = DateTime.Now; }
        }


        //abstract tanımlı class içinde interface gibi gövdesiz method tanımlanabilir

        public abstract void AcilirTavan(); //interface gibi gövdesiz ama abstract class altında olduğundan abstract olarak tanımlanmalıdır
        public abstract void FullPaket();
        public abstract void MaliyetHesapla();
        public bool Kaydet() // abstract altında ihtiyaç doğrultusunda klasik method tanımlaması yapılabilir
        {
            return true;
        }

        public void Guncelle()
        {
            
        }

        
               
    }
}
