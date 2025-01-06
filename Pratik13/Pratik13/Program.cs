using Pratik13;

// Class : Bu örneğimizde 'Kitap' bir class'tır. (Bina planı gibi düşünebiliriz)
// Property : Kitap class'ında Ad, YazarAdi, YazarSoyadi, SayfaSayisi, Yayinevi ve KayitTarihi property'leridir. Fieldları encapsulate ederler.
// New : Kitap class'ından bir nesne oluşturmak için 'new' anahtar kelimesi kullanılır. (Bina inşa etmek gibi düşünebiliriz)
Kitap kitap1 = new Kitap()
{
    Ad = "Adı Aylin",
    YazarAdi = "Ayşe",
    YazarSoyadi = "Kulin",
    SayfaSayisi = 398,
    Yayinevi = "Remzi Kitabevi"
};
Kitap kitap2 = new Kitap("Adı Aylin", "Ayşe", 398, "Remzi Kitabevi");