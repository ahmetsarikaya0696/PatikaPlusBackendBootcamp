using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik15
{
    public abstract class BaseKisi
    {
        public required string Ad { get; set; }
        public required string Soyad { get; set; }

        protected void DisplayAdSoyad()
        {
            Console.WriteLine($"Ad : {Ad} Soyad : {Soyad}");
        }
    }
}
