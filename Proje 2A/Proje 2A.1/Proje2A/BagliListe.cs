using System;
using System.Linq;

namespace Proje2A
{
    class BagliListe
    {
        public Dugum bas;
        public Dugum gecici;
        public Dugum onceki;


        public BagliListe (string [] renk)
        {

            bas = null;
            for(int i=0;i<renk.Length; i++)
            {
                Dugum yeni = new Dugum(renk[i]);
                // Dugum olusturur .

                if (i == 0)
                {
                    bas = yeni;
                    gecici = bas;
                    continue;
                }              
               // Birinci ise donguye girer .
                gecici.sonrakiDugum = yeni;
                gecici = gecici.sonrakiDugum;
              // Arada uretilen baglar .
                if(i==14)
                {
                    gecici.sonrakiDugum = yeni;
                    yeni.sonrakiDugum = bas;
                    //Sonuncu bag ise donguye girer .
                }

            }
        }

       public Dugum cikar(int n)//n cikaracak eleman  
        {
           // Cikar fonksiyonu .

           if(bas==null)
           {
               Console.WriteLine("Liste Bostur");
               return null;
           }
           //Bas bos ise liste bosttur .
           
            int m = bas.getSayisi();

            onceki = bas;
            gecici = bas;
           if(bas.sonrakiDugum==bas)
           {
               //Basa donme durumu .
               gecici = bas;
               bas = null;
               return gecici;
           }
           else
           {
               if (n==1)
               {
                   // Cikaralacak eleman 1 ise bu donguye girer,
                   // degilse ELSE girer
                   while(onceki.sonrakiDugum!=bas)
                   {
                       // 
                       onceki = gecici;
                       gecici = gecici.sonrakiDugum;
                   }
                   if(onceki.sonrakiDugum==bas)
                   {
                       gecici = bas;
                       onceki.sonrakiDugum = gecici.sonrakiDugum;
                       bas = onceki.sonrakiDugum;
                       return gecici;
                   }
               }                   
               else
               {
                   onceki = bas;
                   gecici = bas;

                   for (int i = 0; i < n - 1; i++)
                   {
                       onceki = gecici;
                       gecici = gecici.sonrakiDugum;

                   }
                   onceki.sonrakiDugum = gecici.sonrakiDugum;
                   bas = onceki.sonrakiDugum;
               }
           }
          
           return gecici;
          
        }
        
        public bool IsEmpty()
       {
            // Bagli Liste Bos olup olmadigini kontrol ediliyor.
            if(bas==null)
                return true;

            return false;
       }
    }

}
