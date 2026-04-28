namespace Lesson9_4_OOP_inheritance_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Turkiye turkiye = new Turkiye();
            

            turkiye.Bayrak("kırmızı,beyaz");
            turkiye.Baskent("Ankara");
            turkiye.DenizKiyiSayisi(4);
            turkiye.DenizleriBaglayanBogaz("Çanakkale Boğazı\n İstanbul Boğazı");
            turkiye.BilinenDaglar("Kaz", "Erciyes", "Agri");

            ABD abd = new ABD();
            abd.Bayrak("kırmızı,beyaz,mavi");
            abd.Baskent("Washington, D.C.");
            abd.DenizKiyiSayisi(39);
            abd.DenizKiyiSayisi(5); //?


            Isvicre isvicre = new Isvicre();
            isvicre.Tarih("İsviçre, resmî adıyla İsviçre Konfederasyonu, Batı, Orta ve Güney Avrupa'nın kesişme noktasında bulunan bir ülkedir. Federal otoritelerin merkezi Bern ile birlikte 26 kantondan oluşan bir federal cumhuriyettir.");
            isvicre.YillikHasilat(115000000000,"ABD dolar");
            isvicre.Baskent("Bern");
            isvicre.BilinenDaglar("The Matterhorn", "Matterhorn", "Eiger");

            Ingiltere ıngiltere = new Ingiltere();
        }
    }
}
