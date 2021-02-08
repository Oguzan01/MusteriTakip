using System;

namespace MusteriTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Oğuzhan";
            musteri1.MusteriYasi = 20;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Abdullah";
            musteri2.MusteriYasi = 24;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAdi = "Metehan";
            musteri3.MusteriYasi = 16;

            Musteri musteri4 = new Musteri();
            musteri4.MusteriId = 4;
            musteri4.MusteriAdi = "Alican";
            musteri4.MusteriYasi = 22;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            Musteri musteriler = new Musteri();

            MusteriManager islem = new MusteriManager();
            islem.MusteriMenusu(new Musteri());
        }
    }
}
