namespace Pratik36
{
    public class Singer
    {
        public string AdSoyad { get; set; } = default!;
        public string MuzikTuru { get; set; } = default!;
        public int CikisYili { get; set; }
        public string AlbumSatislari { get; set; } = default!;

        public override string ToString()
        {
            return $"Ad Soyad: {AdSoyad}, Müzik Türü: {MuzikTuru}, Çıkış Yılı: {CikisYili}, Albüm Satışları: {AlbumSatislari}";
        }
    }
}
