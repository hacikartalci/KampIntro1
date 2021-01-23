﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri EKlenmiştir. Müşteri : " + musteri.Adi + musteri.Soyadi);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesi : " + musteri.Adi + musteri.Soyadi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silinmiştir. Müşteri : " + musteri.Adi + musteri.Soyadi);
        }
    }
}
