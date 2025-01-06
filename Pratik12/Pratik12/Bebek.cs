using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik12
{
    public class Bebek
    {
        public Bebek()
        {
            DogumTarihi = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(" Ingaaaa ");
        }

        public Bebek(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(" Ingaaaa ");
        }

        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public DateOnly DogumTarihi { get; set; }

        public void DisplayProperties()
        {
            Console.WriteLine($"Ad: {Ad ?? "-"}, Soyad: {Soyad ?? "-"}, Doğum Tarihi: {DogumTarihi}");
        }
    }
}
