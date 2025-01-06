// Print "Kendime inanıyorum, ben bu yazılım işini hallederim!" 10 times on the console.
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i + 1}) Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

Console.WriteLine("--------------------");
// Print numbers from 1 to 20 on the console.
for (int i = 1; i < 21; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("--------------------");
// Print even numbers between 1 and 20 on the console.
for (int i = 1; i < 21; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("--------------------");
// Calculate and print the sum of numbers between 50 and 150.
int toplam = 0;
for (int i = 50; i <= 150; i++)
{
    toplam += i;
}
Console.WriteLine($"Toplam {toplam}");

Console.WriteLine("--------------------");
// Calculate and print the sum of odd and even numbers separately between 1 and 120.
int ciftToplam = 0;
int tekToplam = 0;
for (int i = 1; i <= 120; i++)
{
    if ((i % 2) == 0)
    {
        ciftToplam += i;
    }
    else
    {
        tekToplam += i;
    }
}
Console.WriteLine($"Çift sayılar toplamı : {ciftToplam}\r\nTek sayılar toplamı : {tekToplam}");