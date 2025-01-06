namespace Hafta5Kapanis
{
    public class Araba
    {
        public DateOnly UretimTarihi { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public string SeriNumarasi { get; set; } = default!;
        public string Marka { get; set; } = default!;
        public string Model { get; set; } = default!;
        public string Renk { get; set; } = default!;
        private int kapiSayisi;

        public int KapiSayisi
        {
            get { return kapiSayisi; }
            set 
            {
                if (value < 0) throw new ArgumentException("Kapı sayısı negatif olamaz.");

                kapiSayisi = value;
            }
        }

    }
}
