using CSProjeDemo1.Books;
using CSProjeDemo1.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Kutuphane
    {
        public List<Uye> Uyeler = new();
        public List<Kitap> Kitaplar = new();

        

        public void OduncVer( int Kitapİndex,int Uyeİndex)
        {

            if (Kitaplar == null || Uyeler == null)
            {
                Console.WriteLine("listeler null olamaz.");
                return;
            }
            if (Kitaplar[Kitapİndex].OduncVerildiMi== false)
            {
                Kitaplar[Kitapİndex].OduncVerildiMi = true;
                Uyeler[Uyeİndex].AldıgıKitaplar.Add(Kitaplar[Kitapİndex]);
                Console.WriteLine($"{Kitaplar[Kitapİndex].Baslik} kitabı {Uyeler[Uyeİndex].İsim} üyesine ödünç verildi");
            }
            else if (Uyeler[Uyeİndex].AldıgıKitaplar.Contains(Kitaplar[Kitapİndex]))
            {
                Console.WriteLine($"{Uyeler[Uyeİndex].İsim} Zaten bu Kitapı kiralamış");
            }
            else
            {
                Console.WriteLine($"{Kitaplar[Kitapİndex].Baslik} zaten başkasına ödünç verilmiş");
            }

        }

        public void GeriAl(int Kitapİndex, int Uyeİndex)
        {

            if (Kitaplar == null || Uyeler == null)
            {
                Console.WriteLine("listeler null olamaz.");
                return;
            }
            if (Kitaplar[Kitapİndex].OduncVerildiMi== true)
            {
                if (!Uyeler[Uyeİndex].AldıgıKitaplar.Contains(Kitaplar[Kitapİndex]))
                {
                    Console.WriteLine($"{Kitaplar[Kitapİndex].Baslik} bu üyenin üzerinde görülmüyor iade alınamaz");
                    
                }
                else
                {
                    Uyeler[Uyeİndex].AldıgıKitaplar.Remove(Kitaplar[Kitapİndex]);
                    Kitaplar[Kitapİndex].OduncVerildiMi = false;
                    Console.WriteLine($"{Kitaplar[Kitapİndex].Baslik} kitabı geri alındı.");
                        

                }

            }
            else
            {
                Console.WriteLine("kitap zaten kütüphanede");
            }


        }







        public override string ToString()
        {
            string uye = string.Empty;
            foreach (var item in Uyeler)
            {
                uye += " " + item.ToString()+"\n";
            }
            string kitap = string.Empty;
            foreach (var item in Kitaplar)
            {
                kitap += " " + item.ToString() + "\n";
            }
            return $"Üyeler: {uye}\nKitaplar: {kitap}";
        }
    }

}
