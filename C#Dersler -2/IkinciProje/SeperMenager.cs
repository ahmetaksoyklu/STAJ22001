using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace IkinciProje
{
    public class SeperMenager
    {
        //public void Ekle()
        //{
        //    Console.WriteLine("sepete eklendi");
        //}

        public void Ekle(Urun urun)
        {
            Console.WriteLine("urun eklendi "+urun.Adi);
        }

        public void Ekle2(string uruAdi, string aciklama, int fiyati)
        {
            Console.WriteLine("urun adı " + uruAdi);
        }
    }
}
