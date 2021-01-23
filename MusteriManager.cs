using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class MusteriManager
    {
        public void MusteriEKle(Musteri musteri)
        {
            Console.WriteLine(" Eklediğiniz müşteri: " + musteri.ID +" numaralı" + musteri.name + musteri.surname 
                + " İsimli müşteri eklenmiştir." );
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(" Silinen müşteri: " + musteri.ID + " numaralı"+ musteri.name + musteri.surname
                + " İsimli müşteri silinmiştir.");
        }

        public void MusteriListele(Musteri musteri) 
        {

            Console.WriteLine("Numara: " + musteri.ID);
            Console.WriteLine("Ad: " + musteri.name);
            Console.WriteLine("Soyad: "+ musteri.surname);
        }
    }
}
