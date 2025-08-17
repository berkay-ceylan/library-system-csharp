using CSProjeDemo1.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Users
{
    public class Uye : İuye
    {
        public Uye(string isim, string soyisim, string telefonNumarasi)
        {
            İsim = isim;
            Soyisim = soyisim;
            TelefonNumarasi = telefonNumarasi;
            id++;
        }
        public List<Kitap> AldıgıKitaplar = new();
        private string _isim;
        private string _soyisim;
        private string _telefonNumarasi;


        public string İsim
        {
            get {return _isim;}
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length < 20)
                    _isim = value;
                else
                    throw new Exception("isim boş ve 20 karakterden uzun olamaz");
            
            } 
        }
        public string Soyisim
        {
            get { return _soyisim; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length < 20)
                    _soyisim = value;
                else
                    throw new Exception("soyisim boş ve 20 karakterden uzun olamaz");

            }

        }
        public string TelefonNumarasi
        {   get {  return _telefonNumarasi; }
            set
            {
                if (value.Length == 10)
                    _telefonNumarasi = value;
                else
                    throw new Exception("lütfen telefon numaranızı başında 0 olmadan giriniz telefon numarası 10 karakterden oluşmaktadır.");
                
            }
            

        }

        

        public int İd = id;
        static int id = 0;
        public void OduncAlinanKitaplar()
        {


            foreach (var item in AldıgıKitaplar)
            {

                Console.WriteLine($"{item.İSBN}= {item.Baslik}");
            }
        }

        public override string ToString()
        {
            return $"{İd}: İsim: {İsim} Soyisim: {Soyisim}  Telefon numarası: {TelefonNumarasi}";
        }
    }
}
