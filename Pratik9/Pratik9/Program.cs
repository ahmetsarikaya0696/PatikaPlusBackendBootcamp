bool isValid = false;
// Geçerli lokasyonlar dizisi
string[] validLocations = { "bodrum", "marmaris", "çeşme" };
string? userInputLocation = string.Empty;

do
{
    // Kullanıcıdan lokasyon seçmesini iste
    Console.Write("Bodrum, Marmaris ya da Çeşme lokasyonlarından birini seçiniz : ");
    userInputLocation = Console.ReadLine()?.ToLower();

    // Girilen lokasyonun geçerli olup olmadığını kontrol et
    if (validLocations.Contains(userInputLocation))
    {
        isValid = true;
    }
    else
    {
        // Konsolu temizle ve hata mesajı göster
        Console.Clear();
        Console.WriteLine("Hatalı bir lokasyon girdiniz. Geçerli lokasyonlar: Bodrum, Marmaris, Çeşme");
    }

} while (!isValid); // Geçerli bir lokasyon girilene kadar devam et

// Kullanıcıdan tatil için kaç kişi olduğunu sor
Console.Write("Kaç kişilik bir tatil planlıyorsunuz? ");
int.TryParse(Console.ReadLine(), out int personCount);

// isValid'i sıfırla
isValid = false;
string? userInputTransportationWay = string.Empty;

do
{
    // Kullanıcıdan ulaşım şekli seçmesini iste
    Console.Write("Tatile hangi yolla gitmek istiyorsunuz? (1 ya da 2 giriniz)" +
    "1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )" +
    "2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");

    userInputTransportationWay = Console.ReadLine();

    // Girilen ulaşım yolunun geçerli olup olmadığını kontrol et
    if (userInputTransportationWay == "1" || userInputTransportationWay == "2")
    {
        isValid = true;
    }
    else
    {
        // Konsolu temizle ve hata mesajı göster
        Console.Clear();
        Console.WriteLine("Hatalı girdi! Geçerli girdiler: 1,2");
    }

} while (!isValid); // Geçerli bir ulaşım şekli seçilene kadar devam et

int totalPrice = 0;

// Lokasyona göre toplam fiyatı hesapla
switch (userInputLocation)
{
    case "bodrum":
        totalPrice += 4000;
        break;
    case "çeşme":
        totalPrice += 3000;
        break;
    case "marmaris":
        totalPrice += 5000;
        break;
}

// Ulaşım şekline göre toplam fiyatı hesapla
if (userInputTransportationWay == "1")
{
    totalPrice += personCount * 1500;
}
else
{
    totalPrice += personCount * 4000;
}

// Toplam tatil maliyetini yazdır
Console.WriteLine($"Tatil maliyetiniz : {totalPrice} TL ' dir.");
