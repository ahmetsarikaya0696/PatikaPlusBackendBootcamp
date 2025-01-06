// 1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
int i = 0;
while (i < 10)
{
    Console.WriteLine($"{i + 1}) Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}

Console.WriteLine("--------------------");
// 2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
i = 1;
while (i <= 20)
{
    Console.WriteLine(i);
    i++;
}

Console.WriteLine("--------------------");
// 3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
i = 1;
while (i <= 20)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }

    i++;
}

Console.WriteLine("--------------------");
// 4-> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
i = 50;
int toplam = 0;
while (i <= 150)
{
    toplam += i;
    i++;
}
Console.WriteLine($"Toplam : {toplam}");

Console.WriteLine("--------------------");
// 5-> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int tekToplam = 0;
int ciftToplam = 0;
i = 1;
while (i <= 120)
{
    if (i % 2 == 0)
    {
        ciftToplam += i;
    }
    else
    {
        tekToplam += i;
    }

    i++;
}

Console.WriteLine($"Çift sayıların toplamı : {ciftToplam}\r\nTek sayıların toplamı : {tekToplam}");