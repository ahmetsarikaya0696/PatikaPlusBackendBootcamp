using Pratik21;

List<Movie> movies = new List<Movie>();
string input1 = string.Empty;
double input2 = 0;

while (true)
{
    Console.Write("Film adı : ");
    input1 = Console.ReadLine();

    Console.Write("Imdb Puanı : ");
    input2 = Convert.ToDouble(Console.ReadLine());

    Movie movie = new Movie() { Name = input1, ImdbPoint = input2 };
    movies.Add(movie);

    Console.Write("Devam etmek istiyor musunuz? (Evet için herhangi bir tuşa/Hayır için 'h' tuşuna basınız) : ");
    input1 = Console.ReadLine().ToLower();

    if (input1 == "h")
    {
        Console.WriteLine("Programdan çıkılıyor...");

        // Display all movies
        Console.WriteLine("Tüm Filmler");
        DisplayMovies(movies);

        // Display movies with ImdbPoint > 4 and < 9
        var filteredMoviesByImdbPoint = movies.Where(x => x.ImdbPoint > 4 && x.ImdbPoint < 9).ToList();
        Console.WriteLine("Imdb Puanı 4 ile 9 arasında olan filmler");
        DisplayMovies(filteredMoviesByImdbPoint);

        // Display movies with Name starting with 'A'
        var filteredMoviesByName = movies.Where(x => x.Name.StartsWith("A")).ToList();
        Console.WriteLine("'A' ile Başlayan Filmler");
        DisplayMovies(filteredMoviesByName);

        break;
    }
}

// Display movies
static void DisplayMovies(List<Movie> movie)
{
    if (!movie.Any())
    {
        Console.WriteLine("Film bulunamadı.");
        return;
    }

    foreach (var item in movie)
    {
        Console.WriteLine($"Film adı : {item.Name} - Imdb Puanı : {item.ImdbPoint}");
    }
}