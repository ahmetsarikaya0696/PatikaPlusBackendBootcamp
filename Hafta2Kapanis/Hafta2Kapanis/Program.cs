//1 - Aşağıdaki çıktıyı yazan bir program.

//Merhaba
//Nasılsın ?
//İyiyim
//Sen nasılsın ?
Console.WriteLine("Merhaba\r\nNasılsın ?\r\nİyiyim\r\nSen nasılsın ?");
Console.WriteLine("--------------------");
//2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
string text = "text";
int num = 4;
Console.WriteLine($"Metinsel veri : {text}\r\nTam sayı verisi : {num}");

Console.WriteLine("--------------------");
//3 - Rastgele bir sayı üretip , ekrana yazdırınız.
Random random = new Random();
int randomNumber = random.Next();
Console.WriteLine($"Rastgele sayı : {randomNumber}");

Console.WriteLine("--------------------");
//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
Random random2 = new Random();
int randomNumber2 = random.Next();
Console.WriteLine($"Rastgele sayı : {randomNumber2}\r\nMod3 : {randomNumber2 % 3}");

Console.WriteLine("--------------------");
//5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
Console.Write("Yaş : ");
int.TryParse(Console.ReadLine(), out int age);
if (age > 18)
{
    Console.WriteLine("+");
}
else if (age < 18)
{
    Console.WriteLine("-");
}
else
{
    Console.WriteLine("18 Yaşındasınız");
}

Console.WriteLine("--------------------");
//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}

Console.WriteLine("--------------------");
//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
Console.Write("Name 1 : ");
string? name1 = Console.ReadLine();

Console.Write("Name 2 : ");
string? name2 = Console.ReadLine();

Console.WriteLine($"Before\r\nName 1 : {name1}\r\nName 2 : {name2}");

// Değerlerin yeri değiştirildi
string? temp = name1;
name1 = name2;
name2 = temp;

Console.WriteLine($"After\r\nName 1 : {name1}\r\nName 2 : {name2}");

Console.WriteLine("--------------------");
//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
BenDegerDondurmem();

Console.WriteLine("--------------------");
//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
int Sum(int num1, int num2)
{
    return num1 + num2;
}
int sum = Sum(1, 2);
Console.WriteLine($"Toplam : {sum}");

Console.WriteLine("--------------------");
//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
string BoolToString(bool b)
{
    return b ? "true" : "false";
}
Console.WriteLine(BoolToString(true));

Console.WriteLine("--------------------");
// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
int GetMaxAge(int age1, int age2, int age3)
{
    int maxAge = age1;
    if (age2 > age1)
    {
        maxAge = age2;
    }
    if (age3 > maxAge)
    {
        maxAge = age3;
    }
    return maxAge;
}
int maxAge = GetMaxAge(21, 10, 17);
Console.WriteLine($"En yaşlının yaşı : {maxAge}");


Console.WriteLine("--------------------");
//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
int GetMaxNumber(int[] numbers)
{
    int maxNumber = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > maxNumber)
        {
            maxNumber = numbers[i];
        }
    }
    return maxNumber;
}
int maxNumber = GetMaxNumber([1, 2, 43, 54, 324, 67, 123, -44, 0]);
Console.WriteLine($"Max number : {maxNumber}");


Console.WriteLine("--------------------");
//13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
void ChangeNames(ref string name1, ref string name2)
{
    string? temp = name1;
    name1 = name2;
    name2 = temp;
}
string nameX = "ahmet";
string nameY = "volkan";
Console.WriteLine($"Before\r\nName X : {nameX}\r\nName Y : {nameY}");
ChangeNames(ref nameX, ref nameY);
Console.WriteLine($"After\r\nName X : {nameX}\r\nName Y : {nameY}");

Console.WriteLine("--------------------");
//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
bool IsEven(int num)
{
    return num % 2 == 0;
}
bool isEven = IsEven(1);
Console.WriteLine($"isEven : {isEven}");

Console.WriteLine("--------------------");
//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
// X = V * t formülüne göre yapıldı
int GetDistance(int speed, int time)
{
    return speed * time;
}
int distance = GetDistance(100, 5);
Console.WriteLine($"Distance : {distance}");

Console.WriteLine("--------------------");
//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
double GetAreaOfCircle(int r)
{
    return 3.14d * r * r;
}
double areaOfCircle = GetAreaOfCircle(5);
Console.WriteLine($"are of circle : {areaOfCircle}");

Console.WriteLine("--------------------");
//17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
string sentence = "Zaman bir GeRi SayIm";
Console.WriteLine(sentence.ToLower());
Console.WriteLine(sentence.ToUpper());

Console.WriteLine("--------------------");
//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
string greeting = "    Selamlar   ";
Console.WriteLine($"Before : {greeting}");
greeting = greeting.Trim();
Console.WriteLine($"After : {greeting}");
