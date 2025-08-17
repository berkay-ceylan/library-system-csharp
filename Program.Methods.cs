using CSProjeDemo1.Books;
using CSProjeDemo1.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    internal partial class Program
    {

        public static void GeriAlmak()
        {

            UyeleriListele();
            Console.Write("\nLütfen kitap iade edecek üyenin ID numarasını girin: ");
            int İd = int.Parse(Console.ReadLine());
            KitaplariListele();
            Console.Write("\nLütfen geri alınacak kitabın numarasını seçiniz.");
            int numara = int.Parse(Console.ReadLine());
            kutuphane.GeriAl(numara, İd);

        }
        public static void OduncVermek()
        {
            try
            {
                UyeleriListele();
                Console.Write("\nLütfen kitap ödünç verilecek üyenin ID numarasını girin: ");
                int İd = int.Parse(Console.ReadLine());
                KitaplariListele();
                Console.Write("\nLütfen Ödünç verilecek kitabın numarasını seçiniz.");
                int numara = int.Parse(Console.ReadLine());
                kutuphane.OduncVer(numara, İd);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }



        }

        public static void UyeleriListele()
        {
            foreach (var item in kutuphane.Uyeler)
            {
                Console.WriteLine(item);
            }


        }

        public static void KitaplariListele()
        {
            foreach (var item in kutuphane.Kitaplar)
            {
                Console.WriteLine(item);
            }

        }

        public static void KitapEkle()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*--- Kitap Ekleme ---*\n");
            Console.ResetColor();
            try
            {
                Console.Write("hangi tür kitap eklemek istiyorsunuz bilimkurgu için [1]. Roman için [2]. Tarih için [3]:  ");
                int tur = int.Parse(Console.ReadLine());
                if (tur < 1 || tur > 3)
                {
                    Console.WriteLine("yanlış tuşlama yaptınız");
                    return;
                }


                Console.Write("kitabın İSBN sinigiriniz: ");
                string isbn = Console.ReadLine();
                Console.Write("kitabın başlığını giriniz: ");
                string baslik = Console.ReadLine();
                Console.Write("kitabın yazarını giriniz: ");
                string yazar = Console.ReadLine();
                Console.Write("kitabın yayın yılını giriniz: ");
                int.TryParse(Console.ReadLine(), out int yayinyili);
                Console.Write("kitabın sayfa sayısını giriniz: ");
                int.TryParse(Console.ReadLine(), out int sayfasayisi);

                if (tur == 1)
                {
                    kutuphane.Kitaplar.Add(new KitapBilimKurgu(isbn, baslik, yayinyili, sayfasayisi, yazar));
                }
                else if (tur == 2)
                {
                    kutuphane.Kitaplar.Add(new KitapRoman(isbn, baslik, yayinyili, sayfasayisi, yazar));
                }
                else
                    kutuphane.Kitaplar.Add(new KitapTarih(isbn, baslik, yayinyili, sayfasayisi, yazar));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nYeni Kitap Eklendi\n");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();

            }


        }

        public static void KutuphaneUyeVeKitaplar()
        {
            Console.WriteLine(kutuphane);

        }
        public static void UyeEkle()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*--- Üye Ekleme ---*\n");
            Console.ResetColor();
            try
            {
                Console.Write("isim giriniz: ");
                string isim = Console.ReadLine();
                Console.Write("soyisim giriniz: ");
                string soyisim = Console.ReadLine();
                Console.Write("Telefon numarasını başında 0 olmadan giriniz: ");
                string telefon = Console.ReadLine();

                kutuphane.Uyeler.Add(new Uye(isim, soyisim, telefon));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nYeni Üye Eklendi.\n");
                Console.ResetColor();


            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }



        }
    }
}
