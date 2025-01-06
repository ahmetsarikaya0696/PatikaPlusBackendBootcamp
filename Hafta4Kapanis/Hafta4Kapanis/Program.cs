// This program allows the user to create either a Telefon or Bilgisayar object based on their input.
// It collects various details about the product and then displays the information.
// The user can choose to create multiple products in a loop until they decide to exit.

using Hafta4Kapanis;

bool baskaUrun = false;
do
{
    Console.Clear();

    bool isValid = false;
    string? choice = string.Empty;
    do
    {
        Console.Write("Telefon üretmek için 1 bilgisayar üretmek için 2'ye basın : ");
        choice = Console.ReadLine();
        if (choice == "1" || choice == "2") isValid = true;
    } while (!isValid);

    Console.Write("Ürün Açıklaması : ");
    string aciklama = Console.ReadLine();

    Console.Write("Ürün Adı : ");
    string ad = Console.ReadLine();

    Console.Write("Ürün İşletim Sistemi : ");
    string isletimSistemi = Console.ReadLine();

    Console.Write("Ürün Seri No : ");
    string seriNo = Console.ReadLine();

    BaseMakine makine;

    if (choice == "1")
    {
        Console.Write("Tr Lisanslı mı? (Evet için 'e' hayır için herhangi bir tuşa basınız) : ");
        bool trLisanslı = Console.ReadLine().ToLower() == "e" ? true : false;

        makine = new Telefon()
        {
            Aciklama = aciklama,
            Ad = ad,
            IsletimSistemi = isletimSistemi,
            SeriNo = seriNo,
            TrLisanli = trLisanslı
        };
    }
    else
    {
        Console.Write("Bluetooth var mı? (Evet için 'e' hayır için herhangi bir tuşa basınız) : ");
        bool bluetooth = Console.ReadLine().ToLower() == "e" ? true : false;

        Console.Write("Usb Giriş Sayisi : ");
        int.TryParse(Console.ReadLine(), out int usbGirisSayisi);

        makine = new Bilgisayar()
        {
            Aciklama = aciklama,
            Ad = ad,
            IsletimSistemi = isletimSistemi,
            SeriNo = seriNo,
            Bluetooth = bluetooth,
            UsbGirisSayisi = usbGirisSayisi
        };
    }

    makine.BilgileriYazdir();

    Console.Write("Başka bir ürün üretmek ister misiniz? (Evet için 'e' hayır için herhangi bir tuşa basınız) : ");
    baskaUrun = Console.ReadLine().ToLower() == "e" ? true : false;
} while (baskaUrun);

Console.WriteLine("İyi günler\r\nUygulama kapatılıyor...");