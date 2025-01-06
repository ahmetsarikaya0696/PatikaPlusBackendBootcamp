// 1.Konsola "Merhaba Dünya" yazdıran bir program yazın.
using System.Net.WebSockets;

Console.WriteLine("Merhaba Dünya");

// 2. Kullanıcıdan iki tam sayı alın ve bu sayıların toplamını konsola yazdırın.
Console.Write("1. Sayi : ");
int.TryParse(Console.ReadLine(), out int num1);

Console.Write("2. Sayi : ");
int.TryParse(Console.ReadLine(), out int num2);

Console.WriteLine($"Toplam : {num1 + num2}");

// 3. Kullanıcıdan yaşını isteyin. Eğer yaş 18 veya daha büyükse "Yetişkinsiniz" yazdırın, aksi takdirde "Çocuksunuz" yazdırın.
Console.Write("Yaş : ");
int.TryParse(Console.ReadLine(), out int age);
if (age > 18)
{
    Console.WriteLine("Yetişkinsiniz");
}
else
{
    Console.WriteLine("Çocuksunuz");
}

// 4.Kullanıcıdan bir tam sayı alın. Eğer sayı çift ise "Çift sayıdır" yazdırın, tek ise "Tek sayıdır" yazdırın.
Console.Write("Sayi : ");
int.TryParse(Console.ReadLine(), out int num);
if (num % 2 == 0)
{
    Console.WriteLine("Çift sayıdır");
}
else
{
    Console.WriteLine("Tek sayıdır");
}

// 5. Kullanıcıdan bir sıcaklık değeri alın (Celsius cinsinden). Eğer sıcaklık 0'dan küçükse "Donuyor", 0 ile 30 arasında ise "Normal", 30'dan büyükse "Sıcak" yazdırın.
Console.Write("Sıcaklık : ");
int.TryParse(Console.ReadLine(), out int tempreture);
if (tempreture < 0)
{
    Console.WriteLine("Donuyor");
}
else if (tempreture <= 30)
{
    Console.WriteLine("Normal");
}
else
{
    Console.WriteLine("Sıcak");
}

// 6. Kullanıcıdan 1 ile 7 arasında bir sayı alın. Bu sayı günlerden birini temsil ediyor. Sayıya göre "Pazartesi", "Salı", vb. gün adlarını yazdırın. Geçersiz bir sayı girildiğinde "Geçersiz gün" yazdırın.
Console.Write("1-7 arası bir sayı giriniz : ");
int.TryParse(Console.ReadLine(), out int num3);
if(num3 == 1)
{
    Console.WriteLine("Pazartesi");
}
else if(num3 == 2)
{
    Console.WriteLine("Salı");
}
else if (num3 == 3)
{
    Console.WriteLine("Çarşamba");
}
else if (num3 == 4)
{
    Console.WriteLine("Perşembe");
}
else if (num3 == 5)
{
    Console.WriteLine("Cuma");
}
else if (num3 == 6)
{
    Console.WriteLine("Cumartesi");
}
else if (num3 == 7)
{
    Console.WriteLine("Pazar");
}
else
{
    Console.WriteLine("Geçersiz gün");
}


// 7. Kullanıcıdan bir not (0-100 arasında) alın. Notun aralığına göre "Başarılı", "Orta", "Başarısız" yazdırın. (0-60 başarısız, 61-80 orta, 81-100 başarılı)
Console.Write("0-100 arası bir sayı giriniz : ");
int.TryParse(Console.ReadLine(), out int score);
if(score < 0 || score > 100)
{
    Console.WriteLine("Geçersiz not girdiniz.");
    return;
}

if(score >= 81)
{
    Console.WriteLine("Başarılı");
}
else if(score >= 61)
{
    Console.WriteLine("Orta");
}
else if(score >= 0)
{
    Console.WriteLine("Başarısız");
}

// 8. Kullanıcıdan bir ay numarası (1-12) alın ve bu ayın kaç gün olduğunu yazdırın. Şubat ayı için 28 gün, diğer aylar için gün sayısını kontrol edin.
/*
1 => Ocak: 31 gün
2 => Şubat: 28 gün
3 => Mart: 31 gün
4 => Nisan: 30 gün
5 => Mayıs: 31 gün
6 => Haziran: 30 gün
7 => Temmuz: 31 gün
8 => Ağustos: 31 gün
9 => 1Eylül: 30 gün
10 => Ekim: 31 gün
11 => Kasım: 30 gün
12 => Aralık: 31 gün
 */
Console.Write("1-12 arası bir ay numarası giriniz : ");
int.TryParse(Console.ReadLine(), out int monthNumber);
if(monthNumber == 1 || monthNumber == 3 || monthNumber == 5 || monthNumber == 7 || monthNumber == 8 || monthNumber == 10 || monthNumber == 12)
{
    Console.WriteLine("31 gün");
}
else if(monthNumber == 4 || monthNumber == 6 || monthNumber == 9 || monthNumber == 11)
{
    Console.WriteLine("30 gün");
}
else if(monthNumber == 2)
{
    Console.WriteLine("28 gün");
}
else
{
    Console.WriteLine("Geçersiz ay numarası");
}

// 9. Kullanıcıdan bir şifre isteyin. Eğer şifre "12345" ise "Giriş Başarılı" yazdırın, değilse "Giriş Başarısız" yazdırın.
Console.Write("Password : ");
string? password = Console.ReadLine();
if(password == "1234")
{
    Console.WriteLine("Giriş Başarılı");
}
else
{
    Console.WriteLine("Giriş Başarısız");
}

// 10. Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) alın. Seçilen işleme göre sonucu hesaplayın ve yazdırın. Eğer geçersiz bir işlem girilirse "Geçersiz işlem" yazdırın.
Console.WriteLine("Toplama için 1\r\nÇıkarma için 2\r\nÇarpma için 3\r\nBölme için 4 giriniz");
int.TryParse(Console.ReadLine(), out int operatorNumber);

Console.WriteLine("1. Sayi : ");
int.TryParse(Console.ReadLine(), out num1);

Console.WriteLine("2. Sayi : ");
int.TryParse(Console.ReadLine(), out num2);

if (operatorNumber == 1) Console.WriteLine($"Toplam = {num1 + num2}");
else if (operatorNumber == 2) Console.WriteLine($"Fark = {num1 - num2}");
if (operatorNumber == 3) Console.WriteLine($"Çarpım = {num1 * num2}");
else if (operatorNumber == 4) Console.WriteLine($"Bölüm = {num1 / num2}");