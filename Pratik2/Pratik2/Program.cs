// Prompt user for their T.C. identification number and store the input
Console.Write("T.C. Kimlik numarası : ");
string? tc = Console.ReadLine();

// Prompt user for their first name and store the input
Console.Write("Adi : ");
string? name = Console.ReadLine();

// Prompt user for their last name and store the input
Console.Write("Soyadi : ");
string? surname = Console.ReadLine();

// Prompt user for their phone number and store the input
Console.Write("Telefon Numarasi : ");
string? phoneNumber = Console.ReadLine();

// Prompt user for their age and store the input
Console.Write("Yaş : ");
string? age = Console.ReadLine();

// Prompt user for the price of the first product and try parsing it as an integer
Console.Write("İlk aldıgi Ürünün Fiyati : ");
double.TryParse(Console.ReadLine(), out double firstPrice);

// Prompt user for the price of the second product and try parsing it as an integer
Console.Write("İkinci aldıgi Ürünün Fiyati : ");
double.TryParse(Console.ReadLine(), out double secondPrice);

// Calculate the total price of the two products
double sum = firstPrice + secondPrice;

// Calculate the Patika points earned (10% of the total price)
double patikaPoint = sum * 0.1d;

Console.WriteLine("--------------------------------------------------");

// Display the registration information and the earned points
Console.WriteLine($"{tc} Tc numarali {name} {surname} isimli kisi için kayit oluşturulmuştur.\r\n" +
    $"{phoneNumber} telefon numarasına bildirim mesajı gönderilmiştir.\r\n" +
    $"{sum} Toplam harcama karşılığı kazanılan 10% patika puan miktarı => {patikaPoint} TL'dir.");


// Telefon numarasını string aldım çünkü telefon numarasıyla herhangi bir sayısal işlem yapılmıyor.
// Ürün fiyatlarını double aldım çünkü virgüllü fiyat girilebilir diye düşündüm.