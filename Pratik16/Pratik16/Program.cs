using Pratik16;

// Create a square with side length 4 and calculate its area
BaseGeometrikSekil kare = new Kare(4);
Console.WriteLine($"Karenin alanı : {kare.AlanHesapla()}");

// Create a rectangle with width 3 and height 4 and calculate its area
BaseGeometrikSekil dikdortgen = new Dikdortgen()
{
    Genislik = 3,
    Yukseklik = 4,
};
Console.WriteLine($"Dikdörtgenin alanı : {dikdortgen.AlanHesapla()}");

// Create a right triangle and calculate its area
BaseGeometrikSekil dikUcgen = new DikUcgen();
Console.WriteLine($"Dik üçgenin alanı : {dikUcgen.AlanHesapla()}");
