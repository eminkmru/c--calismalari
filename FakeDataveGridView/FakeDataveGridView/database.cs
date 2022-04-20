﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDataveGridView
{
    public class database
    {
        public List<musteri> musteriler = new List<musteri>();
        public database()
        {

        }
        public List<musteri> musteriListele()
        {
            Random rnd = new Random();
            for (int i = 1; i < 1001; i++)
            {
               
                musteri Temp = new musteri();
                Temp.id = 1000 + i; 
                Temp.isim = FakeData.NameData.GetFirstName();
                Temp.soyisim = FakeData.NameData.GetSurname();
                Temp.tamAdi = $"{Temp.isim} {Temp.soyisim}";
                Temp.emailAdres = FakeData.NetworkData.GetEmail(Temp.isim + Temp.soyisim);
                Temp.telefonNumarasi=FakeData.PhoneNumberData.GetPhoneNumber();
                Temp.il = FakeData.PlaceData.GetCity(); 
                Temp.ilce = FakeData.PlaceData.GetCountry();
                Temp.adres = FakeData.PlaceData.GetAddress();
                musteriler.Add(Temp);
            }
            return musteriler;
        }



    }
}
