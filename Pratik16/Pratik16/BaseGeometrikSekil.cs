namespace Pratik16
{
    // Abstract base class for geometric shapes
    public abstract class BaseGeometrikSekil
    {
        // Properties for width and height
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

        // Abstract method to calculate area
        public abstract int AlanHesapla();
    }

    // Class for square shape
    public class Kare : BaseGeometrikSekil
    {
        // Constructor to initialize square with side length
        public Kare(int kenar)
        {
            Yukseklik = kenar;
            Genislik = kenar;
        }

        // Override method to calculate area of square
        public override int AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }

    // Class for rectangle shape
    public class Dikdortgen : BaseGeometrikSekil
    {
        // Override method to calculate area of rectangle
        public override int AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }

    // Class for right triangle shape
    public class DikUcgen : BaseGeometrikSekil
    {
        // Override method to calculate area of right triangle
        public override int AlanHesapla()
        {
            return Genislik * Yukseklik / 2;
        }
    }
}
