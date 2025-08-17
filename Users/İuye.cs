using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Users
{
    public interface İuye
    {
        
        public string İsim { get; set; }
        public string Soyisim { get; set; }

        public string TelefonNumarasi { get; set; }

        

        public void OduncAlinanKitaplar();


    }
}
