using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Proje_2.b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random zaman yaratiliyor .
            Random zaman = new Random(DateTime.Now.Millisecond);

            // Yiginda bulunacak olan araba miktari kullanicidan aliniyor .
            Console.WriteLine("\nKuyrukta Bulunacak Olan Araba Adeti(n) Giriniz: ");
            int n =Convert.ToInt32(Console.ReadLine());
            
            int zamann;
            Kuyruk kuyruk = new Kuyruk(n);
            Kuyruk oncelikkuyruk = new Kuyruk(n);
            Kuyruk siralikuyruk = new Kuyruk(n);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tA)                                               ");
            Console.ResetColor();
            // Kullanacagimiz kuyruk oncelikli kuyruk ve sirali kuyruk olusturuluyor .
       
            for (int i = 0; i < n;i++ )
            {
                
                zamann=zaman.Next(10, 300);
                kuyruk.Enque(i,zamann);
                oncelikkuyruk.Enque(i, zamann);
                Console.WriteLine("\tGirilen "+(i+1)+".arabanın bekleme süresi: " + zamann);
                
            }
            // 10 ve 300 arasinda uretilen random zaman ve numarasi(i) kuyruk yapisina ekleniyor . 
            //ayriyetten oncelikli kuyruga da gonderiliyor ancak onu simdilik kullanmiyoruz .
            Console.WriteLine();
            int top = 0, top2 = 0, top3 = 0;
            for(int i=0; i<n; i++)
            {
                Araba temp = kuyruk.deque();
                top += temp.zaman;
                top2 += top;
                if (i == 0)
                    top3 = 0;
                // Deque fonksiyonuyla arabalar kuyruktan teker teker cikariliyor ve Araba class tipindeki Temp e konuluyor .
                // Her arabanin zamani TOP degiskeninde toplaniyor .
                // Ve her sefer donen top degiskeninin degerleri de top2 degiskenine aktariliyor .
                    
                Console.WriteLine("\t"+(temp.numara+1) + "." + " Arabanin bekleme süresi: " + top3);
                Console.WriteLine( "\t"+(temp.numara+1) +"." + " Arabanin kuyrukta kaldigi sure: " + top);
                top3 += temp.zaman;
                // Arabanin bekleme suresi yazdiriliyor ve ayriyetten arabanin kuyrukta kaldigi sure yazdiriliyor .
                // Arabanin bekleme suresi ve arabanin kuyrukta kaldigi sure farklidir .
            }
            float ort = top2 / n;
            int top4=0,top5=0;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tAraba basina kuyrukta kaldığı ortalama süre: " + ort+"              ");
            //Her arabanin kuryukta ortalama kaldigi sure hesaplanip yazdiriliyor .
            Console.ResetColor();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tB)                                               ");
            Console.ResetColor();
            Console.WriteLine("\n\tKucukten Buyuge Dogru Siralama \n");
            // Kucukten buyuge dogru siralama islemi yapiliyor ancak 2 ayri kuyruk kullaniliyor .
            
            for (int i = 0; i < n; i++)
            {
               Araba temp = oncelikkuyruk.oncelikli();
               siralikuyruk.Enque(temp.numara,temp.zaman);
               // Kuyruktan kucukten buyuge cikarma islemi yapiliyor ancak sirali degil ve ardindan sirali bicimde cikarilan veriler 
               //teker teker sirali bir bicimde yeni bir kuyruga aktariliyor .
               top4 += temp.zaman;
               top5 += top4;
               Console.WriteLine("\tGirilen " + (temp.numara+1) + ".arabanın bekleme süresi: "+ temp.zaman );
                // Girilen arabanin bekleme sureleri teker teker yazdiriliyor .
            }
            float ort2 = top5 / n;
            int fark =Convert.ToInt32(ort-ort2);
            float yuzde = 100 - ((ort2 / ort) * 100);
            // Ortalama ve fark  hesaplaniyor .

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tKuyrukta Kaldigi Sure Farki : " + fark+"                ");
            // Bir onceki kuyruga gore kuyrukta kaldigi sure farki yazdiriliyor .
            Console.ResetColor();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(String.Format("\tYuzde ="+yuzde)+" %                                ");
            // Farka gore yuzde yazdiriliyor .
            Console.ResetColor();
            Console.WriteLine();
            int sayi1=0,sayi2=0,sayi3=0,sayi4=0,sayac=0;

            // Arabalarin 4 cikisli otopark icin toplamda suresi yazdiriliyor 
            // 4 cikisli oldugu icin en hizli islemi bitiren otopark bu olacaktir .
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tC)                                               ");
            Console.ResetColor();
            
            for (int k = 0; k < n;k++ )
            {
                if (!siralikuyruk.BosMu() && sayi1 == 0)
                {
                    Araba temparaba = siralikuyruk.deque();
                    sayi1 = temparaba.zaman;
                    Console.WriteLine("\n\t1. Cikisa yonelen arac no :" + (temparaba.numara + 1) + " ve bekleme suresi :" + temparaba.zaman);
                }
                if (!siralikuyruk.BosMu() && sayi2 == 0)
                {
                    Araba temparaba = siralikuyruk.deque();
                    sayi2 = temparaba.zaman;
                    Console.WriteLine("\n\t2. Cikisa yonelen arac no :" + (temparaba.numara + 1) + " ve bekleme suresi :" + temparaba.zaman);
                }
                if (!siralikuyruk.BosMu() && sayi3 == 0)
                {
                    Araba temparaba = siralikuyruk.deque();
                    sayi3 = temparaba.zaman;
                    Console.WriteLine("\n\t3. Cikisa yonelen arac no :" + (temparaba.numara + 1) + " ve bekleme suresi :" + temparaba.zaman);
                }
                if (!siralikuyruk.BosMu() && sayi4 == 0)
                {
                    Araba temparaba = siralikuyruk.deque();
                    sayi4 = temparaba.zaman;
                    Console.WriteLine("\n\t4. Cikisa yonelen arac no :" + (temparaba.numara + 1) + " ve bekleme suresi :" + temparaba.zaman);
                }
                // bos olan sayi tiplerine zamanlar aktariliyor ve kuyrugun verinin aktarilmadan once bos olup olmadigi kontrol ediliyor .
                // veriler kucukten buyuge tutuldugu icin sirali bir sekilde ilk once 1 2 3 ve en son 4 ten eleman cikarilacaktir .
                if (sayi1 != 0)
                {
                    sayac += sayi1;
                    if (sayi2 != 0)
                        sayi2 = sayi2 - sayi1;
                    if (sayi3 != 0)
                        sayi3 = sayi3 - sayi1;
                    if (sayi4 != 0)
                        sayi4 = sayi4 - sayi1;

                    sayi1 = sayi1 - sayi1;
                    //En kucuk sayi1 ise bu donguye girecektir .
                    if (sayi1 == 0 && !siralikuyruk.BosMu())
                    {
                        Console.WriteLine("\n\t1.Cikis Bos !!!");
                        Araba temparaba = siralikuyruk.deque();
                        sayi1 = temparaba.zaman;
                        Console.WriteLine("\n\t1. Cikisa yonelen arac no :" + (temparaba.numara + 1) + " ve bekleme suresi :" + temparaba.zaman);
                    }
                }

                if (sayi2 != 0)
                {
                    sayac += sayi2;
                    if (sayi1 != 0)
                        sayi1 = sayi1 - sayi2;
                    if (sayi3 != 0)
                        sayi3 = sayi3 - sayi2;
                    if (sayi4 != 0)
                        sayi4 = sayi4 - sayi2;

                    sayi2 = sayi2 - sayi2;
                    //En kucuk sayi2 ise bu donguye girecektir .
                    if (sayi2 == 0 && !siralikuyruk.BosMu())
                    {
                        Console.WriteLine("\n\t2.Cikis Bos !!!");
                        Araba temparaba = siralikuyruk.deque();
                        sayi2 = temparaba.zaman;
                        Console.WriteLine("\n\t2. Cikisa yonelen arac no :" + (temparaba.numara + 1) + " ve bekleme suresi :" + temparaba.zaman);
                    }
                }

                if (sayi3 != 0)
                {
                    sayac += sayi3;
                    if (sayi1 != 0)
                        sayi1 = sayi1 - sayi3;
                    if (sayi2 != 0)
                        sayi2 = sayi2 - sayi3;
                    if (sayi4 != 0)
                        sayi4 = sayi4 - sayi3;

                    sayi3 = sayi3 - sayi3;
                    //En kucuk sayi3 ise bu donguye girecektir .
                    if (sayi3 == 0 && !siralikuyruk.BosMu())
                    {
                        Console.WriteLine("\n\t2.Cikis Bos !!!");
                        Araba temparaba = siralikuyruk.deque();
                        sayi3 = temparaba.zaman;
                        Console.WriteLine("\n\t3. Cikisa yonelen arac no :" + (temparaba.numara + 1) + " ve bekleme suresi :" + temparaba.zaman);
                    }
                }

                if (sayi4 != 0)
                {
                    sayac += sayi4;
                    if (sayi1 != 0)
                        sayi1 = sayi1 - sayi4;
                    if (sayi2 != 0)
                        sayi2 = sayi2 - sayi4;
                    if (sayi3 != 0)
                        sayi3 = sayi3 - sayi4;

                    sayi4 = sayi4 - sayi4;
                    //En kucuk sayi4 ise bu donguye girecektir .
                    if (sayi4 == 0 && !siralikuyruk.BosMu())
                    {
                        Console.WriteLine("\n\t4.Cikis Bos !!!");
                        Araba temparaba = siralikuyruk.deque();
                        sayi4 = temparaba.zaman;
                        Console.WriteLine("\n\t4. Cikisa yonelen arac no :" + (temparaba.numara+1) + " ve bekleme suresi :" + temparaba.zaman);
                    }

                }
            }
            

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t4 Cikisli Otoparktaki İslem Tamamlanma Suresi: " + sayac+"  ");
            Console.ResetColor();
            
            //4 ckisili otoparktaki islem tamamlanma suresi 
            
                

                Console.ReadKey();
        }
    }
}
