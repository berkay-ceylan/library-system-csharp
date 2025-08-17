using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Books
{
    public class KitapTarih : Kitap
    {
        public KitapTarih(string isbn, string baslik, int yayinYili, int sayfaSayisi, string yazar) : base(isbn, baslik, yayinYili, sayfaSayisi, yazar)
        {
            OduncVerildiMi= false;
            Tur = "Tarih";
        }

        public override void GeriAlinabilirMi()
        {
            if (OduncVerildiMi == true)
            {
                Console.WriteLine($"{Baslik} geri alınabilir");
            }
            else
                Console.WriteLine($"{Baslik} kitabı Zaten şu an da Kütüphanede");
        }

        public override void OduncVerilebilirMi()
        {
            if (OduncVerildiMi == false)
            {
                Console.WriteLine($"{Baslik} kitabı ödünç verilebilir.");
            }
            else
                Console.WriteLine($"{Baslik} kitabı zaten ödünç verilmiş");

        }

        public override string ToString()
        {
            return base.ToString() + " " + (OduncVerildiMi == false ? "Ödünç verilebilir" : "kitap şu an da ödünç verilmiş");
        }
    }
}
