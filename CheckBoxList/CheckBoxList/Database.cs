using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBoxList
{
    public class Database
    {
        public static List<Urun> UrunTablo = new List<Urun>()
        {
            new Urun()
            {
                 Id = 1,
                  UrunAdi ="Şeker Portakalı",
                   UrunKategori ="Roman",
                       StokAdedi =100,
                        Yazar  =   "José Mauro de Vasconcelos",
                         Aciklama =     "Şeker Portakalı, Brezilyalı yazar José Mauro de Vasconcelos'un tüm dünyayı etkisi altına almayı başaran 1968 tarihli dram ve çocukluk romanıdır. Brezilya'nın Minas Gerais bölgesinde yaşayan fakir bir ailenin beş yaşındaki oğlu olan ve hayal gücü çok gelişmiş olan Zeze adlı bir çocuğun başından geçenleri konu edinir. "
            },
            new Urun()
            {
                Id = 2,
                  UrunAdi ="Nutuk",
                   UrunKategori ="Söylev",
                       StokAdedi =100,
                        Yazar  =   "Mustafa Kemal Atatürk",
                         Aciklama   =       "Nutuk, yazıldığı dönemde Cumhuriyet Halk Fırkası umumi reisi olan Gazi Mustafa Kemal'in 15-20 Ekim 1927 tarihlerinde, 1919'dan 1927'ye dek kendisinin ve silah arkadaşlarının faaliyetlerini özetlediği konuşmasının metnidir."

            },
            new Urun()
            {
                Id = 3,
                  UrunAdi ="Çalıkuşu",
                   UrunKategori ="Roman",
                       StokAdedi =100,
                        Yazar  =   "Reşat Nuri Güntekin",
                         Aciklama="Çalıkuşu, Reşat Nuri Güntekin'in ilk defa 1922'de tefrika edilmeye başlanıp 1923'te kitap olarak yayımlanan, 1937'de büyük değişikliklerle tefrika edilen romanıdır."

            }

        };
    }
}
