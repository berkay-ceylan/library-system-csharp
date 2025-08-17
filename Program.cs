using CSProjeDemo1.Books;
using CSProjeDemo1.Users;
using System.Security.Cryptography.X509Certificates;

namespace CSProjeDemo1
{
    internal partial class Program
    {

        public static Kutuphane kutuphane = new Kutuphane();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*-----Kütüphane Yönetim Sistemi-----*\n\n");
                Console.ResetColor();
                Console.WriteLine("1.Yeni üye eklemek için lütfen [1] i tuşlayın\n");
                Console.WriteLine("2.Yeni kitap eklemek için lütfen [2] yi tuşlayın\n");
                Console.WriteLine("3.Kütüphane sistemindeki üyeleri ve kitapları listelemek için lütfen [3] ü tuşlayın\n");
                Console.WriteLine("4.Kitapları listelemek için [4] ü tuşlayın\n");
                Console.WriteLine("5.Üyeleri listelemek için [5] i tuşlayın\n");
                Console.WriteLine("6.Kitap ödünç vermek için [6] yı tuşlayın\n");
                Console.WriteLine("7.Kitabı geri almak için lütfen [7] yi tuşlayın\n");
                Console.WriteLine("Çıkış yapmak için [8] i tuşlayın\n");
                Console.Write("Seçim: ");
                string secim = Console.ReadLine();
                Console.Clear();

                switch (secim)
                {
                    case "1":

                        UyeEkle();
                        break;

                    case "2":
                        KitapEkle();

                        break;
                    case "3":
                        KutuphaneUyeVeKitaplar();

                        break;
                    case "4":
                        KitaplariListele();

                        break;
                    case "5":
                        UyeleriListele();
                        break;
                    case "6":
                        OduncVermek();

                        break;
                    case "7":
                        GeriAlmak();
                        break;
                    case "8":
                        Console.WriteLine("Çıkış Yapılıyor...");
                        return;
                        default:
                        Console.WriteLine("Hatalı Tuşlama yaptınız");
                        break;

                }







            }

        }



        

    }
}
