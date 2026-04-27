namespace Lesson9_1_Static_Class
{
    public class Siparisler
    {
        public void SiparisListesi()
        {
            SiparisAdeti();
        }
        private DateTime SiparisTarihi()
        {
            return DateTime.Now;
        }

        public static int SiparisAdeti()
        {
            return 105;
        }

    }
}
