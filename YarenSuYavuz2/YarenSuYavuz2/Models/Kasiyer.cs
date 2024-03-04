namespace YarenSuYavuz2.Models
{
    public class Kasiyer
    {
        public char KasiyerAdi { get; set; }
        public char KasiyerTel { get; set; }
        public char CikisTarihi { get; set; }
        public char DevamEdiyoMu { get; set; }
        public char KasiyerİseGirisTarihi { get; set; }
        public char Cikistarihi { get; set; }
        public int KasiyerID_FK { get; set; }
        public int SatilanUrunler_FK { get; set; }

    }
}
