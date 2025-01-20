namespace Pratik37
{
    public class Series
    {
        public string Ad { get; set; } = default!;
        public int YapimYili { get; set; } = default!;
        public string Tur { get; set; } = default!;
        public int YayinlanmayaBaslamaYili { get; set; } = default!;
        public List<string> Yonetmenler { get; set; } = [];
        public string YayinlandigiIlkPlatform { get; set; } = default!;
    }
}
