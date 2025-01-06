using Hafta5Kapanis;

bool isValidInput = false; // Kullanıcıdan geçerli bir giriş alana kadar döngü
List<Araba> arabalar = new List<Araba>(); // Araba nesnelerini saklamak için liste

while (!isValidInput) // Kullanıcıdan giriş almak için döngü
{
    Console.Write("Bir araba üretmek istiyor musunuz? Cevap(e/h) : ");
    string answer = Console.ReadLine().ToLower(); // Kullanıcının cevabını al ve küçük harfe çevir

    if (answer == "e" || answer == "h") // Geçerli cevap kontrolü
    {
        isValidInput = true; // Geçerli cevap alındı
        if (answer == "h") return; // Hayır cevabı verilirse programdan çık

        ArabaOlusturStart: // Araba oluşturma başlangıcı
        Console.Write("Seri No : ");
        string seriNo = Console.ReadLine(); // Seri numarasını al

        Console.Write("Marka : ");
        string marka = Console.ReadLine(); // Marka bilgisini al

        Console.Write("Model : ");
        string model = Console.ReadLine(); // Model bilgisini al

        Console.Write("Renk : ");
        string renk = Console.ReadLine(); // Renk bilgisini al

        int kapiSayisi = -1; // Kapı sayısını tutacak değişken
        goto KapiSayisiStart; // Kapı sayısı girişi için etiket

    KapiSayisiStart: // Kapı sayısı girişi
        Console.Write("Kapı Sayısı : ");
        string kapiSayisiInput = Console.ReadLine(); // Kullanıcıdan kapı sayısını al
        try
        {
            kapiSayisi = Convert.ToInt32(kapiSayisiInput); // Girişi tam sayıya çevir
                                                           // Yeni araba nesnesini listeye ekle
            arabalar.Add(new Araba
            {
                SeriNumarasi = seriNo,
                Marka = marka,
                Model = model,
                Renk = renk,
                KapiSayisi = kapiSayisi
            });
        }
        catch (FormatException) // Format hatası kontrolü
        {
            Console.WriteLine("Lütfen sayısal bir değer giriniz."); // Hata mesajı
            goto KapiSayisiStart; // Yeniden kapı sayısı girişi iste
        }
        catch (ArgumentException ex) // Argüman hatası kontrolü
        {
            Console.WriteLine(ex.Message); // Hata mesajı
            goto KapiSayisiStart; // Yeniden kapı sayısı girişi iste
        }
        catch (Exception ex) // Genel hata kontrolü
        {
            Console.WriteLine("Genel bir hata oluştu: " + ex.Message); // Hata mesajı
            goto KapiSayisiStart; // Yeniden kapı sayısı girişi iste
        }

        bool isValidInput2 = false; // Başka araba oluşturma isteği için geçerli giriş kontrolü

        while (!isValidInput2) // Kullanıcıdan başka araba oluşturma isteği almak için döngü
        {
            Console.Write("Başka araba oluşturmak istiyor musunuz? Cevap(e/h) : ");
            answer = Console.ReadLine().ToLower(); // Kullanıcının cevabını al ve küçük harfe çevir

            if (answer == "e" || answer == "h") // Geçerli cevap kontrolü
            {
                isValidInput2 = true; // Geçerli cevap alındı
                if (answer == "e") goto ArabaOlusturStart; // Evet cevabı verilirse yeni araba oluştur

                // Arabaların seri numaralarını ve markalarını yazdır
                Console.WriteLine("Arabaların seri numaraları ve markaları yazdırılıyor...");
                foreach (var araba in arabalar)
                {
                    Console.WriteLine($"Seri No : {araba.SeriNumarasi}, Marka : {araba.Marka}");
                }
            }
        }
    }
}