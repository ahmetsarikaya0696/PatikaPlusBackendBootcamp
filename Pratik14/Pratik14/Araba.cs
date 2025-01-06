namespace Pratik14
{
    public class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        private int kapiSayisi;

        public int KapiSayisi
        {
            get { return kapiSayisi; }
            set
            {
                if (value != 2 || value != 4)
                {
                    Console.WriteLine("Kapı sayısı 2 veya 4 olmalıdır!");
                    kapiSayisi = -1;
                    return;
                }

                kapiSayisi = value;
            }
        }

    }
}
