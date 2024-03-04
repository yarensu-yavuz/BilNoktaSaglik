namespace YarenSuYavuz2.Models
{
    public class Urun
    {
        public char UrunAd { get; set; }
        public char UrunIcerik { get; set; }
        public char UrunMarka { get; set; }
        public char UrunKod { get; set; }
        public char SonKullanmaTarihi { get; set; }
        public int KategoriID_FK { get; set; }
        public int TedarikciID_FK { get; set; }
    }
}
