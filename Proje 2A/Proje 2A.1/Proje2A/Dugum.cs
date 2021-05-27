using System;
using System.Linq;

namespace Proje2A
{
    class Dugum
    {
        
        private string veri;
        static int sayisi;
        public Dugum sonrakiDugum;

        //Dugum yapisi olusturuluyor .
        public Dugum(string gelenVeri)
        {
            veri = gelenVeri;
            sayisi++;
        }

        public string getVeri()
        {
            // Rengi alan fonksiyon . 
            return veri;
        }

        public int getSayisi()
        {
            //Arabanin no sunu alan fonksiyon .
            return sayisi;
        }

        public void azaltsayi()
        {
            // Sayi azalttir .
            sayisi--;
        }


        public void goster()
        {
            ///Rengi yazdirir .
            Console.WriteLine(veri);
        }
    }
}
