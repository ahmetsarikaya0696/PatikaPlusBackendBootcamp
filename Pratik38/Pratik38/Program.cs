using Pratik38;

// List of authors
List<Yazar> yazarlar =
[
    new Yazar { AuthorId = 1, Name = "Jane Austen" },
    new Yazar { AuthorId = 2, Name = "Charles Dickens" },
    new Yazar { AuthorId = 3, Name = "George Orwell" },
    new Yazar { AuthorId = 4, Name = "Agatha Christie" },
    new Yazar { AuthorId = 5, Name = "J.R.R. Tolkien" }
];

// List of books
List<Kitap> kitaplar =
[
    new Kitap { BookId = 1, Title = "Pride and Prejudice", AuthorId = 1 },
    new Kitap { BookId = 2, Title = "Emma", AuthorId = 1 },
    new Kitap { BookId = 3, Title = "Oliver Twist", AuthorId = 2 },
    new Kitap { BookId = 4, Title = "David Copperfield", AuthorId = 2 },
    new Kitap { BookId = 5, Title = "1984", AuthorId = 3 },
    new Kitap { BookId = 6, Title = "Animal Farm", AuthorId = 3 },
    new Kitap { BookId = 7, Title = "Harry Potter and the Philosopher's Stone", AuthorId = 5 },
    new Kitap { BookId = 8, Title = "The Hobbit", AuthorId = 5 }
];

// Joining authors and books based on AuthorId
var integratedList = yazarlar.Join(kitaplar, y => y.AuthorId,
                                             k => k.AuthorId,
                                            (y, k) => new { y.Name, k.Title })
                             .ToList();

// Displaying the integrated list of authors and their books
foreach (var item in integratedList)
{
    Console.WriteLine($"Yazar : {item.Name}, Kitap : {item.Title}");
}
