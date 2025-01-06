using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik15
{
    public class Ogretmen : BaseKisi
    {
        public decimal Maas { get; set; }

        public void DisplayAdSoyadMaas()
        {
            DisplayAdSoyad();
            Console.WriteLine($"Maas : {Maas}");
        }
    }
}
