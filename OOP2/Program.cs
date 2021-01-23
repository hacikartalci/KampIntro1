using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacı Kartalcı
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Hacı";
            musteri1.Soyadi = "Kartalcı";
            musteri1.TcNo = "11111111111";

            //Kartalcipanjur.com
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kartalcipanjur.com";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID - L Harfi diyor ki: (Birbirine benziyor diye inheritance yapma!
            //Eğer bir nesnede bir değeri kullanmak zorunda değilsen, orada soyutlama hatası yapıyorsun.

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            //New görürsen her zaman Referans aklına gelsin.
            //Musteri class'ı hem GercekMusteri hem de TuzelMusteri referansını tutuyor.

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


        }
    }
}
