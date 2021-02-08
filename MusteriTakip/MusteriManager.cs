using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriTakip
{
    class MusteriManager
    {
        public void MusteriMenusu(Musteri musteri)
        {
            

            int secim;
            Console.WriteLine("Hesabınıza giriş yapmak için 1 e basın " + "\n" +
                "Hesabınızı silmek için 2 ye basın." + "\n" +
                "Müşterileri listelemek için 3 e basın." + "\n" + 
                "Hesap eklemek için 4 e basın ");
            Console.Write("İşleminizi seçin = ");
            secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    MusteriGiris(musteri);
                    break;
                
                case 2:
                    MusteriSil(musteri);
                    break;

                case 3:
                    MusteriListele(musteri);
                    break;

                case 4:
                    MusteriEkle(musteri);
                    break;
            }

        }
        public void MusteriGiris(Musteri musteri)
        {
            Console.Write("ID numaranızı giriniz = ");
            int id = Convert.ToInt32(Console.ReadLine());
            
            switch(id)
            {
                case 1:
                    Console.WriteLine("Hoşgeldin Oğuzhan");
                    break;
                case 2:
                    Console.WriteLine("Hoşgeldin Abdullah");
                    break;
                case 3:
                    Console.WriteLine("Hoşgeldin Metehan");
                    break;
                case 4:
                    Console.WriteLine("Hoşgeldin Alican");
                    break;
                default:
                    Console.WriteLine("Böyle bir hesap yok.");
                    break;
            }
        }

        public void MusteriEkle(Musteri musteri)
        {
            Console.Write("ID numaranızı giriniz = ");
            musteri.MusteriId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adınızı giriniz = ");
            musteri.MusteriAdi = Console.ReadLine();

            Console.Write("Yaşınızı giriniz = ");
            musteri.MusteriYasi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hesabınız eklenmiştir.");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.Write("Hesabın ID numarasını giriniz = ");
            musteri.MusteriId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hesap silinmiştir.");
        }

        public void MusteriListele(Musteri musteri)
        {
            //foreach (var muster in musteriler)
            //{
            //    Console.WriteLine(muster.MusteriAdi);
            //}
        }
    }
}
