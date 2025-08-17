using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Books
{
    public abstract class Kitap
    {
		protected string Tur;
		public bool OduncVerildiMi;
		private string _isbn;
		private string _baslik;
		private int _yayinYili;
		private int _sayfaSayisi;
		private string _yazar;

        protected Kitap(string isbn, string baslik, int yayinYili, int sayfaSayisi, string yazar)
        {
            İSBN = isbn;
            Baslik = baslik;
            YayinYili = yayinYili;
            SayfaSayisi = sayfaSayisi;
            Yazar = yazar;
			id++;
            
        }
        public int İd = id;
        static int id = 0;
        public string Yazar
		{
			get { return _yazar; }
			set
			{
				if (!string.IsNullOrEmpty(value))
					_yazar = value;
				else
					throw new Exception("Yazar ismi boş geçilemez Eğer yazar ismi bilinmiyorsa lütfen 'Anonim' yazınız.");
			}
		}


		public int SayfaSayisi
		{
			get { return _sayfaSayisi; }
			set 
			{
				if (value > 10 && value < 5000)
					_sayfaSayisi = value;
				else
					throw new Exception("Sayfa sayısı 10 dan küçük ve 5000 den büyük olamaz");
			}
		}

		public int YayinYili
		{
			get { return _yayinYili; }
			set
			{
				if (value > 0 && value <= DateTime.Now.Year)
					_yayinYili = value;
				else
					throw new Exception("Yayın yılı 0 dan küçük ve günümüz tarihinden büyük olamaz.");
			}
		}


		public string Baslik
		{
			get { return _baslik; }

			set
			{
				if (!string.IsNullOrEmpty(value) || value.Length! > 100)
					_baslik = value;
				else
				{
					
					throw new Exception("\nBaşlık boş ve 100 karakterden daha büyük olamaz.");
					
				}
					
			}
		}

		public string İSBN
		{
			get { return _isbn; }

			set 
			{ 
				if (value.Length == 5) 
				_isbn = value;
				else
					throw new ArgumentOutOfRangeException("\nİSBN numarası 5 karakter olmak zorundadır.");
			}
		}

        public override string ToString()
        {
			return $"{İd}:  İSBN numarası: {İSBN}  Kitap İsmi: {Baslik}  Yazar: {Yazar}  Yayın Yılı: {YayinYili}   Sayfa Sayısı: {SayfaSayisi}  Kitap türü: {Tur}";
        }

		public abstract void OduncVerilebilirMi();
		public abstract void GeriAlinabilirMi();

	}
}
