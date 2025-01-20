using Pratik37;

// List of TV series
List<Series> diziler =
[
    new Series() // First series entry
    {
        Ad = "Avrupa Yakası", // Title
        YapimYili = 2004, // Production year
        Tur = "Komedi", // Genre
        YayinlanmayaBaslamaYili = 2004, // Start year of airing
        Yonetmenler = ["Yüksel Aksu"], // Directors
        YayinlandigiIlkPlatform = "Kanal D" // First platform aired
    },
    new Series() // Second series entry
    {
        Ad = "Yalan Dünya",
        YapimYili = 2012,
        Tur = "Komedi",
        YayinlanmayaBaslamaYili = 2012,
        Yonetmenler = ["Gülseren Buda Başkaya"],
        YayinlandigiIlkPlatform = "Fox TV"
    },
    new Series() // Third series entry
    {
        Ad = "Jet Sosyete",
        YapimYili = 2018,
        Tur = "Komedi",
        YayinlanmayaBaslamaYili = 2018,
        Yonetmenler = ["Gülseren Buda Başkaya"],
        YayinlandigiIlkPlatform = "TV8"
    },
    new Series() // Fourth series entry
    {
        Ad = "Behzat Ç. Bir Ankara Polisiyesi",
        YapimYili = 2010,
        Tur = "Dram",
        YayinlanmayaBaslamaYili = 2010,
        Yonetmenler = ["Serkan Acar"],
        YayinlandigiIlkPlatform = "Star TV"
    },
    new Series() // Fifth series entry
    {
        Ad = "Kurtlar Vadisi",
        YapimYili = 2003,
        Tur = "Dram",
        YayinlanmayaBaslamaYili = 2003,
        Yonetmenler = ["Raci Şaşmaz"],
        YayinlandigiIlkPlatform = "Show TV"
    },
    new Series() // Sixth series entry
    {
        Ad = "Muhteşem Yüzyıl",
        YapimYili = 2011,
        Tur = "Dram",
        YayinlanmayaBaslamaYili = 2011,
        Yonetmenler = ["Yağmur Taylan", "Durul Taylan"],
        YayinlandigiIlkPlatform = "Star TV"
    },
    new Series() // Seventh series entry
    {
        Ad = "Diriliş: Ertuğrul",
        YapimYili = 2014,
        Tur = "Dram",
        YayinlanmayaBaslamaYili = 2014,
        Yonetmenler = ["Metin Günay"],
        YayinlandigiIlkPlatform = "TRT 1"
    },
    new Series() // Eighth series entry
    {
        Ad = "Çukur",
        YapimYili = 2017,
        Tur = "Dram",
        YayinlanmayaBaslamaYili = 2017,
        Yonetmenler = ["Sinan Öztürk"],
        YayinlandigiIlkPlatform = "Show TV"
    }
];

// Filtering comedy series
var komediDizileri = diziler.Where(dizi => dizi.Tur == "Komedi") // Select only comedy series
                            .OrderBy(dizi => dizi.Ad) // Order by title
                            .ThenBy(dizi => dizi.Yonetmenler.First()) // Then order by first director
                            .Select(dizi => new { Ad = dizi.Ad, Tur = dizi.Tur, Yonetmenler = dizi.Yonetmenler }) // Select relevant fields
                            .ToList();

// Displaying comedy series
foreach (var komediDizisi in komediDizileri)
{
    Console.WriteLine($"Ad : {komediDizisi.Ad}\r\nTur : {komediDizisi.Tur}\r\nYonetmenler : {string.Join(", ", komediDizisi.Yonetmenler)}"); // Print series details
    Console.WriteLine("----------"); // Separator
}