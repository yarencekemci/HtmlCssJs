namespace Lesson11_1_OOP_Ornek.Entity
{
    internal class UrunlerEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public decimal BirimFiyat { get; set; }
        public  decimal SatisFiyat { get; set; }
        public int Stok { get; set; }
        
    }
}
