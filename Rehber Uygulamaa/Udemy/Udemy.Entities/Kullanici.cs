using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Entities
{
    public class Kullanici
    {
        public Guid id { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
    }
}
