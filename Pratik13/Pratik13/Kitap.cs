using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik13
{
    public class Kitap
    {
        public Kitap()
        {
            KayitTarihi = DateOnly.FromDateTime(DateTime.Now);
        }

        public Kitap(string ad, string yazarAdi, int sayfaSayisi, string yayinEvi)
        {
            Ad = ad;
            YazarAdi = yazarAdi;
            SayfaSayisi = sayfaSayisi;
            Yayinevi = yayinEvi;
            KayitTarihi = DateOnly.FromDateTime(DateTime.Now);
        }

        public string Ad { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayinevi { get; set; }
        public DateOnly KayitTarihi { get; set; }
    }
}
