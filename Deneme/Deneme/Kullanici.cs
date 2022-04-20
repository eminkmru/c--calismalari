using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public class Kullanici
    {
        public Guid id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public override string ToString()
        {
            return Isim + " " + Soyisim;
        }
    }
}
