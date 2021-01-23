using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MüsteriNumarasi = 1111;
            musteri1.Adi = "Hasan";
            musteri1.Soyadi = "Doğan";
            musteri1.TC = 11111;
            musteri1.Telefon = 111111;

            Musteri musteri2 = new Musteri();
            musteri2.MüsteriNumarasi = 1112;
            musteri2.Adi = "Ahmet";
            musteri2.Soyadi = "Durmuş";
            musteri2.TC = 11112;
            musteri2.Telefon = 111112;

            Musteri musteri3 = new Musteri();
            musteri3.MüsteriNumarasi = 1113;
            musteri3.Adi = "Mehmet";
            musteri3.Soyadi = "Sevilmiş";
            musteri3.TC = 11113;
            musteri3.Telefon = 111113;

            Musteri musteri4 = new Musteri();
            musteri4.MüsteriNumarasi = 1114;
            musteri4.Adi = "Burak";
            musteri4.Soyadi = "Kut";
            musteri4.TC = 11114;
            musteri4.Telefon = 111114;

            Musteri musteri5 = new Musteri();
            musteri5.MüsteriNumarasi = 1115;
            musteri5.Adi = "Cüneyt";
            musteri5.Soyadi = "Arkın";
            musteri5.TC = 11115;
            musteri5.Telefon = 111115;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Numarası : " + musteri.MüsteriNumarasi);
                Console.WriteLine("Ad : " + musteri.Adi);
                Console.WriteLine("Soyad : " + musteri.Soyadi);
                Console.WriteLine("T.C. : " + musteri.TC);
                Console.WriteLine("Telefon : " + musteri.Telefon);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            musteriManager.Ekle(musteri5);

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            musteriManager.Listele(musteri4);
            musteriManager.Listele(musteri5);

            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
            musteriManager.Sil(musteri4);
            musteriManager.Sil(musteri5);


        }
    }
}
