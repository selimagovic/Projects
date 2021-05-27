using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Proje2A
{
    class Program
    {
        static Random rnd = new Random(DateTime.Now.Millisecond); 
        // random sayi uretiliyor .
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch(); 
            // Pc mizin calculation speed ini olcuyoruz
            int n;
            Console.WriteLine("\n\tLutfen Josephus yontemi icin kullanilacak sayiyi giriniz : ");
            n =Convert.ToInt32( Console.ReadLine());
            //Kullanicidan bir sayi aliyoruz
            sw.Start();
            Stack<string> bodrum = new Stack<string>();
            Queue<string> zemin = new Queue<string>();
            //Bodrum ve Zemin katlarini yani YIGIT ve KUYRUK larini olusturuyoruz .
            string[] renk = {"YESIL    ","MAVI     ","KIRMIZI   ","SARI     ","TURUNCU  ","PEMBE    "
                                ,"SIYAH    ","BEYAZ     ",
                           "KAHVERENGI","GRI      ","MOR      ","LACIVERT  ","TURKUAZ   ","ELA      ",
                           "BEJ      "};
            // Renk dizisi olusturup kuyruk yigit ve bagli liste ile eslestiriyoruz .
            BagliListe bliste = new BagliListe(renk);
            Dugum yaz = bliste.bas;


            
            for (int j = 0; j < renk.Length; j++ )
            {
                bodrum.Push(renk[j]);
            }
            // Bodruma renkleri atiyoruz .
            for (int i = 0; i < renk.Length; i++)
            {
                zemin.Enqueue(renk[i]);              
            }
            
            // Zemine renkleri atiyoruz .
            int r;
            string temp;

                while(zemin.Count != 0)
                {
                    r = rnd.Next(1, 3);
                    //Zemin bos degilse fonksiyona giriyor ve rastgele 1 ve 2 arasinda sayi uretiyor .

                        if (bliste.bas == null)
                            r = 2;

                        if (bodrum.Count == 0)
                            r = 1;
                    // bagli liste bos ise bodruma gecer ya da tam tersi islem uygulanir .
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\tZeminden cikan araba: " + zemin.Dequeue()+"     ");
                    Console.ResetColor();
                    // Cikan araba yazdiriliyor .
                    if(r == 1 && bliste.bas !=null )
                    {
                        yaz = bliste.cikar(n);
                        zemin.Enqueue(yaz.getVeri());
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("\t1. Kattan cikarilan arac: " + yaz.getVeri());
                        Console.WriteLine("\tZemine eklenen arac: " + yaz.getVeri()+"      ");
                        //Bagli listededn Josephus yontemine gore arac cikariliyor ve yazdiriliyor .
                    }
                    Console.ResetColor();
                    if(r == 2 && bodrum.Count != 0)
                    {
                        temp = bodrum.Pop();
                        zemin.Enqueue(temp);
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("\tBodrumdan cikarilan arac: " + temp+" ");
                        Console.WriteLine("\tZemine eklenen arac: " + temp+"   ");
                        //Bodrumdan arac cikariliyor ve yazdiriliyor .
                    }
                }
                sw.Stop();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\tMilisayaniye olarak hacanan zaman = " + sw.ElapsedMilliseconds+"  ");
                
                int s = 5;
                double sec =   TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds).TotalSeconds;

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Blue;
                double hesapla = s / sec;
                Console.WriteLine("\n\t5 saniyede islenilen otopark problem adeti = "+String.Format("{0:0.00}",hesapla));
                Console.ResetColor();
                Console.ReadKey();
        }


    }
}
