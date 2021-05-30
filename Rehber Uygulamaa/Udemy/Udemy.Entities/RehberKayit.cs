using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Entities
{
    public class RehberKayit
    {
        public Guid id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string telefon1 { get; set; }
        public string telefonII { get; set; }
        public string telefonIII { get; set; }
        public string Adres { get; set; }
        public string EMailAdres { get; set; }
        public string Website { get; set; }
        public string Aciklama { get; set; }

        public override string ToString()
        {
            return isim + " " + soyisim;
        }
    }
}
