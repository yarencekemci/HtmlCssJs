using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11_1_OOP_Ornek.Entity
{
    internal class SiparisEntity : BaseEntity
    {
        public int Id { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string UrunBilgisi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
    }
}
