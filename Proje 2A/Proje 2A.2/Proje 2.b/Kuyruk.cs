using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_2.b
{
    class Kuyruk
    {
        public int length;
        public Araba[] arabalar;
        public int head, last;
        public int arabaSayisi;
    
        public Kuyruk(int n)
        {
            length = n;
            
            arabalar = new Araba[length];
           
            arabaSayisi = 0;
            head = 0;
 
            last = -1;
  
        }

        public void Enque(int no, int z)
        {
            if (last == length - 1)
                last = -1;

            arabalar[++last] = new Araba(no, z);
            arabaSayisi++;
        }

        public Araba deque()
        {
            Araba temporary = arabalar[head++];
            if (head == length)
                head = 0;

            arabaSayisi--;
            return temporary;
        }

        public Araba oncelikli()
        {
            int i,index=0;
         
            Araba min = arabalar[0];
            for ( i = 0; i < arabaSayisi; i++)
                    if(arabalar[i].zaman < min.zaman)
                    {
                        min = arabalar[i];
                        index = i;
                    }


            Araba temp = new Araba(min.numara, min.zaman);
            arabalar[index].zaman = 333;
            
            return temp;
        }
        


        public bool BosMu()
        {
            return arabaSayisi == 0;
        }
    }
}
