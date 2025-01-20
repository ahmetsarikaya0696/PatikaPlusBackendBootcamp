// List of singers with their details
using Pratik36;

List<Singer> sarkicilar =
[
    new Singer { AdSoyad = "Sertab Erener", MuzikTuru = "Pop", CikisYili = 1992, AlbumSatislari = "10 milyon" },
    new Singer { AdSoyad = "Sezen Aksu", MuzikTuru = "Pop", CikisYili = 1976, AlbumSatislari = "20 milyon" },
    new Singer { AdSoyad = "Tarkan", AlbumSatislari = "15 milyon", MuzikTuru = "Pop", CikisYili = 1992 },
    new Singer { AdSoyad = "Sibel Can", AlbumSatislari = "5 milyon", MuzikTuru = "Arabesk", CikisYili = 1987 },
    new Singer { AdSoyad = "Sıla", AlbumSatislari = "7 milyon", MuzikTuru = "Pop", CikisYili = 2000 },
    new Singer { AdSoyad = "Serdar Ortaç", AlbumSatislari = "3 milyon", MuzikTuru = "Pop", CikisYili = 1994 },
    new Singer { AdSoyad = "Sagopa K", AlbumSatislari = "2 milyon", MuzikTuru = "Rap", CikisYili = 1998 },
    new Singer { AdSoyad = "Sibel Tüzün", AlbumSatislari = "1 milyon", MuzikTuru = "Pop", CikisYili = 2006 },
    new Singer { AdSoyad = "Funda Arar", AlbumSatislari = "4 milyon", MuzikTuru = "Arabesk", CikisYili = 2000 },
    new Singer { AdSoyad = "Hande Yener", AlbumSatislari = "6 milyon", MuzikTuru = "Pop", CikisYili = 2000 },
    new Singer { AdSoyad = "Hadise", AlbumSatislari = "8 milyon", MuzikTuru = "Pop", CikisYili = 2004 },
    new Singer { AdSoyad = "Haluk Levent", AlbumSatislari = "3 milyon", MuzikTuru = "Rock", CikisYili = 1992 },
    new Singer { AdSoyad = "Gülben Ergen", AlbumSatislari = "5 milyon", MuzikTuru = "Pop", CikisYili = 1992 },
    new Singer { AdSoyad = "Gökhan Tepe", AlbumSatislari = "2 milyon", MuzikTuru = "Pop", CikisYili = 2004 },
    new Singer { AdSoyad = "Gökhan Özen", AlbumSatislari = "3 milyon", MuzikTuru = "Pop", CikisYili = 2002 },
    new Singer { AdSoyad = "Gülşen", AlbumSatislari = "7 milyon", MuzikTuru = "Pop", CikisYili = 2004 },
    new Singer { AdSoyad = "Neşet Ertaş", AlbumSatislari = "1 milyon", MuzikTuru = "Türk Halk Müziği", CikisYili = 1960 },
];

// Filtering singers whose names start with 'S'
var sarkicilarS = sarkicilar.Where(s => s.AdSoyad.StartsWith("S")).ToList();
PrintList(sarkicilarS);

// Filtering singers with album sales greater than 10 million
var sarkicilar10Milyon = sarkicilar.Where(s => int.Parse(s.AlbumSatislari.Split(' ')[0]) > 10).ToList();
PrintList(sarkicilar10Milyon);

// Filtering pop singers who debuted before 2000 and sorting them by name
var sarkicilarPop2000 = sarkicilar.Where(s => s.CikisYili < 2000 && s.MuzikTuru == "Pop")
                                  .OrderBy(s => s.AdSoyad).ToList();
PrintList(sarkicilarPop2000);

// Finding the best-selling singer
var enCokSatanSarkici = sarkicilar.OrderByDescending(s => int.Parse(s.AlbumSatislari.Split(' ')[0])).First();
Console.WriteLine(enCokSatanSarkici);
Console.WriteLine("----------");

// Finding the newest singer
var enYeniSarkici = sarkicilar.OrderByDescending(s => s.CikisYili).First();
Console.WriteLine(enYeniSarkici);

// Method to print the contents of a list
void PrintList<T>(List<T> list)
{
    // Check if the list has any elements
    if (list.Any())
    {
        // Print each element in the list
        list.ForEach(x => Console.WriteLine(x));
    }
    else
    {
        // Print a message if the list is empty
        Console.WriteLine("Listede eleman bulunamadı!");
    }

    // Print a separator line
    Console.WriteLine("----------");
}