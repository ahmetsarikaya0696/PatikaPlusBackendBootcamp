using Pratik14;

Araba araba = new Araba()
{
    Marka = "Tesla",
    Model = "Model S",
    KapiSayisi = 1,
    Renk = "Kırmızı"
};
// Kapı sayısı 2 veya 4 olmalıdır! yazacaktır

Console.WriteLine($"Kapi sayisi : {araba.KapiSayisi}"); // Kapi sayisi : -1 yazacaktır

