// Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız. 
// (Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) )

Console.Write("Limit : ");
int.TryParse(Console.ReadLine(), out int limit);

int i = 0;
while (i <= limit)
{
    Console.WriteLine($"{i}) Ben bir Patika'lıyım");
    i++;
}

i = 0; // sayacı sıfırla
do
{
    Console.WriteLine($"{i}) Ben bir Patika'lıyım");
    i++;
} while (i <= limit);

// while döngüsü şartın sağlandığı zaman çalışırken do-while döngüsü şart sağlanmasa dahi bir kez çalışır.