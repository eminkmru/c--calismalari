using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public static class SanalDatabase
    {
        public static List<Kullanici> KullaniciListe { get; set; }
        static SanalDatabase()
        {
            KullaniciListe = new List<Kullanici>();
        }

    }
}
