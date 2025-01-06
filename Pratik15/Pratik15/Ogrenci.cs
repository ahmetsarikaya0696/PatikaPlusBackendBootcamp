using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik15
{
    public class Ogrenci : BaseKisi
    {
        public required string OgrenciNumarasi { get; set; }

        public void DisplayAdSoyadOgrenciNo()
        {
            DisplayAdSoyad();
            Console.WriteLine($"OgrenciNumarasi : {OgrenciNumarasi}");
        }
    }
}
