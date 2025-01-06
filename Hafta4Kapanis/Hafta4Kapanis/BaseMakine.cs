using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Kapanis
{
    // Abstract base class representing a machine
    public abstract class BaseMakine
    {
        // Constructor initializing the production date to the current date
        public BaseMakine()
        {
            UretimTarihi = DateOnly.FromDateTime(DateTime.Now);
        }

        // Virtual method to print machine information
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim Tarihi : {UretimTarihi}\r\nSeri No : {SeriNo}\r\nAd : {Ad}\r\nAciklama : {Aciklama}\r\nİşletim Sistemi : {IsletimSistemi}");
        }

        // Abstract method to get the product name, must be implemented by derived classes
        public abstract void UrunAdiGetir();

        // Properties of the machine
        public DateOnly UretimTarihi { get; private set; }
        public required string SeriNo { get; set; }
        public required string Ad { get; set; }
        public required string Aciklama { get; set; }
        public required string IsletimSistemi { get; set; }
    }

    // Derived class representing a phone
    public class Telefon : BaseMakine
    {
        // Property indicating if the phone has a Turkish license
        public required bool TrLisanli { get; set; }

        // Override method to print phone information
        public override void BilgileriYazdir()
        {
            Console.WriteLine($"Tr Lisanslı : {(TrLisanli ? "Evet" : "Hayır")}");
            base.BilgileriYazdir();
        }

        // Override method to get the product name
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
        }
    }

    // Derived class representing a computer
    public class Bilgisayar : BaseMakine
    {
        private int _usbGirisSayisi;

        // Property for the number of USB ports, only allows 2 or 4
        public int UsbGirisSayisi
        {
            get { return _usbGirisSayisi; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _usbGirisSayisi = value;
                    return;
                }

                Console.WriteLine("Usb giriş sayısı 2 veya 4 olmalıdır.");
            }
        }

        // Property indicating if the computer has Bluetooth
        public required bool Bluetooth { get; set; }

        // Override method to print computer information
        public override void BilgileriYazdir()
        {
            Console.WriteLine($"Usb Giriş Sayısı : {UsbGirisSayisi}\r\nBluetooth : {(Bluetooth ? "Var" : "Yok")}");
            base.BilgileriYazdir();
        }

        // Override method to get the product name
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
        }
    }
}
