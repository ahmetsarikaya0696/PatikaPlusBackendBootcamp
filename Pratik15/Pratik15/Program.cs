using Pratik15;

Ogretmen ogretmen = new Ogretmen()
{
    Ad = "Sertan",
    Soyad = "Bozkuş",
    Maas = 99999.99m
};

ogretmen.DisplayAdSoyadMaas();

Ogrenci ogrenci = new Ogrenci()
{
    Ad = "Ahmet",
    Soyad = "Sarıkaya",
    OgrenciNumarasi = "12345"
};

ogrenci.DisplayAdSoyadOgrenciNo();