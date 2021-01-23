using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.name = " Mirem";
            musteri1.surname = " Işıldak";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.name = " Beyza";
            musteri2.surname = " karaca";

            Musteri musteri3 = new Musteri();
            musteri3.ID = 3;
            musteri3.name = " sena";
            musteri3.surname = " bilgin";

            Musteri[] Musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            Console.WriteLine("-----Eklenen Müşteriler----");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEKle(musteri1);
            musteriManager.MusteriEKle(musteri2);
            musteriManager.MusteriEKle(musteri3);

            Console.WriteLine("-----Silinen Müşteriler----");
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);

            Console.WriteLine("-----Müşteriler----");

            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriListele(musteri3);


        }
    }
}
