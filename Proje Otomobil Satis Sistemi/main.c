#include <stdio.h>
#include <stdlib.h>
#include <string.h>
void goster();
void goster2();
void goster3();         ///Funksyonlarin prototipleri
void goster4();
void goster5();
int main()
{
    system("title Otomobil Satis Sistemi v1.0");
    system("color 0b");///Ekranin rengi degisiyor
    float vergisiz_fiy,mtv,satis_fiy,kdv,otv_kdv_mtv;
    float toplamVergisizFiy,topSatisFiy,toplam;
    float max_vergi=0,karsilikliSatis,max_satFiy=0,sat;
    float ortVergsizFiy,motor1Vergisiz=0,motor2Vergisiz=0,motor3Vergisiz=0;                                    ///Verileri
    float ortSatisFiy,yuzde1600,yuzde1600ve2000,yuzde2000ust;
    int motor_har,siraNumarasi=0,vergisizSiraNo,karsilikliHar,satis_sira,satis_har;
    int ort_say=0,yuzBinSay=0;
    const int plaka_mas=375;
    int motor1=0,motor2=0,motor3=0,top_plakaMas=0;

    float top_otv=0,top_mtv=0,top_kdv=0;
    int vergSay=0;
    float otv;
    char cvp;
    char eng_mi;

    do
    {
        goster2();/// Yukarda belirtilen funksiyon yaziliyor.
        printf("\n\n");
        printf("\n\n\t\tLutfen vergisiz fiyati giriniz (TL):  ");
        scanf("%f",&vergisiz_fiy);
        while(vergisiz_fiy<=0)
        {
            printf("\n\n\t\tY A N L I S  GIRDINIZ!!!!\n\t\tLutfen tekrar vergisiz fiyati giriniz: ");
            scanf("%f",&vergisiz_fiy);
        }
        fflush(stdin);
        printf("\n\t\tLutfen motor harcimi giriniz (cm^3): ");
        scanf("%d",&motor_har);
        while(motor_har<=0)
        {
            printf("\n\n\t\tY A N L I S  GIRDINIZ!!!!\n\t\tLutfen tekrar motor harcimi giriniz: ");
            scanf("%d",&motor_har);
        }
        siraNumarasi++;
        fflush(stdin);          ///Girdigi sayilari ya da harfleri sonraki giris icin temizliyor.
        kdv=vergisiz_fiy*0.18;/// KDV hesapliyor.
        if(motor_har<1601)
        {
            if(motor1==0)
            {
                yuzde1600=0.0;
                motor1Vergisiz=0.0;
            }
            motor1++;
            motor1Vergisiz+=vergisiz_fiy;
            fflush(stdin);
            printf("\n\t\t Arabanizda engelilik var mi?(E/e/H/h)\n\t\t%c ",16);
            eng_mi=getchar();
            while(eng_mi!='e' && eng_mi!='E' && eng_mi!='h' && eng_mi!='H')/// Yanslis harf girmemesi icin kontrol ediyor
            {
                /// ve mesaj gosteriyor.
                fflush(stdin);
                printf("\n\n\t\tY A N L I S  HARFI  GIRDINIZ!!!!\n\t\t Lutfen tekrar deneyin :D ");
                printf("\n\t\t%c ",4);
                eng_mi=getchar();
            }

            if(motor_har<=1300)
            {
                if(eng_mi=='e' || eng_mi=='E')
                {
                    ort_say++;
                    mtv=0;
                    otv=0;
                }
                else
                {
                    otv=((vergisiz_fiy*40)/100)+kdv;
                    mtv=517.00/2;
                }
            }
            else if(motor_har>1300 && motor_har<1601)
            {
                if(eng_mi=='e' || eng_mi=='E')
                {
                    ort_say++;
                    mtv=0;
                    otv=0;
                }
                else
                {
                    otv=((vergisiz_fiy*40)/100)+kdv;
                    mtv=827.00/2;
                }
            }
        }
        else if(motor_har>1600 && motor_har<2001)
        {
            if(motor2==0)
            {
                yuzde1600ve2000=0.0;
                motor2Vergisiz=0.0;
            }
            motor2++;
            motor2Vergisiz+=vergisiz_fiy;
            otv=((vergisiz_fiy*80)/100)+kdv;
            if(motor_har>1600 && motor_har<1801)
                mtv=1457.00/2;
            else if(motor_har>1800 && motor_har<2001)
                mtv=2295.00/2;
        }
        else
        {

            if(motor3==0)
            {
                yuzde2000ust=0.0;
                motor3Vergisiz=0.0;
            }
            motor3++;
            motor3Vergisiz+=vergisiz_fiy;
            otv=((vergisiz_fiy*130)/100)+kdv;
            if(motor_har>2000 && motor_har<2501)
                mtv=3443.00/2;
            else if(motor_har>1500 && motor_har<3001)
                mtv=4799.00/2;
            else if(motor_har>3000 && motor_har<3501)
                mtv=7308.00/2;
            else if(motor_har>3500 && motor_har<4001)
                mtv=11489.00/2;
            else
                mtv=18803.00/2;
        }
        top_kdv+=kdv;
        top_otv+=otv;
        top_mtv+=mtv;
        top_plakaMas+=plaka_mas;
        satis_fiy=(otv+mtv+vergisiz_fiy+plaka_mas+kdv);
        topSatisFiy+=satis_fiy;
        toplamVergisizFiy+=vergisiz_fiy;

        goster5();/// Yukarda belirtilen funksiyon yaziliyor.
        goster4();
        /// Girdigi numalara gore hesapliyor ve ekrana yaziliyor
        printf("\n\n\n");
        printf("\n\t\tArabanin satis sira numarasi: %d'dir.",siraNumarasi);
        printf("\n\t\tArabanin vergisiz fiyati: %.2f TL",vergisiz_fiy);
        printf("\n\t\tArabanin OTV fiyati: %.2f TL",otv);
        printf("\n\t\tArabanin KDV fiyati: %.2f TL",kdv);
        printf("\n\t\tArabanin MTV fiyati: %.2f TL",mtv);
        printf("\n\t\tArabanin plaka masrafi: %d TL",plaka_mas);
        printf("\n\n\t\tOTV, KDV, MTV tutarlari(TL)\n\t\tve plaka masrafi(TL): %.2f TL",otv_kdv_mtv=otv+kdv+mtv+plaka_mas);
        printf("\n\t\tArabanin teslim satis fiyati: %.2f  TL",satis_fiy);

        if(vergisiz_fiy>max_vergi)
        {
            max_vergi=vergisiz_fiy;
            vergisizSiraNo=siraNumarasi;
            karsilikliHar=motor_har;
            karsilikliSatis=satis_fiy;
        }
        if(satis_fiy>max_satFiy)
        {
            max_satFiy=satis_fiy;
            satis_sira=siraNumarasi;
            satis_har=motor_har;
            sat=vergisiz_fiy;
        }
        if(satis_fiy>100000)
            yuzBinSay++;
        if(vergisiz_fiy<30000 && motor_har<=1600)
            vergSay++;

        fflush(stdin);
        printf("\n\n\t\t Baska araba var mi?! (E/e/H/h)");
        printf("\n\t\t%c ",16);
        cvp=getchar();
        while(cvp!='e' && cvp!='E'&& cvp!='h' && cvp!='H')
        {
            fflush(stdin);
            printf("\n\n\t\tY A N L I S  HARFI  GIRDINIZ!!!!\n\t\t Lutfen tekrar deneyin :D ");
            printf("\n\t\t%c ",4);
            cvp=getchar();
        }
    }
    while(cvp=='E' || cvp=='e');
    if(motor1Vergisiz==0)
        motor1Vergisiz=0.0;
    else
        motor1Vergisiz=motor1Vergisiz/(float)motor1;

    if(motor2Vergisiz==0)
        motor2Vergisiz=0.0;
    else
        motor2Vergisiz=motor2Vergisiz/(float)motor2;
    if(motor3Vergisiz==0)
        motor3Vergisiz=0.0;
    else
        motor3Vergisiz=motor3Vergisiz/(float)motor3;
    toplam=top_kdv+top_mtv+top_otv+top_plakaMas;
    yuzde1600=(float)(motor1*100)/siraNumarasi;
    yuzde1600ve2000=(float)(motor2*100)/siraNumarasi;
    yuzde2000ust=(float)(motor3*100)/siraNumarasi;
    ortSatisFiy=(float)topSatisFiy/siraNumarasi;
    ortVergsizFiy=(float)toplamVergisizFiy/siraNumarasi;
    printf("\n\n");

    goster3();
    goster4();
    /// Tum girdigi araclarin vergisiz fiyatlari ve motor harcimlari asaga gosteriyor
    fflush(stdin);
    printf("\n\n\t\t=================================================");
    printf("\n\n\t\tMotor hacmi 1600 cm^3'u gecmeyen, 1601-2000 cm^3\n\t\tarasinda olan ve 2000 cm^3'ten yuksek olan");
    printf("\n\t\taraclarin sayilari ve yuzdeleri.");
    printf("\n\n\n\t\tMotor 1600 cm^3 icin:\n\t\tMotorun sayisi: %d'dir.\n\t\tMotorun yuzdesi: %.2f %c",motor1,yuzde1600,37);
    printf("\n\n\t\tMotor 1601-2000 cm^3 icin:\n\t\tMotorun sayisi: %d'dir.\n\t\tMotorun yuzdesi: %.2f %c",motor2,yuzde1600ve2000,37);
    printf("\n\n\t\tMotor 2000'ten yuksek cm^3 icin:\n\t\tMotorun sayisi: %d'dir.\n\t\tMotorun yuzdesi: %.2f %c",motor3,yuzde2000ust,37);
    printf("\n\n\t\t=================================================");
    printf("\n\n\t\tMotor hacmi 1600 cm^3'u gecmeyen, 1601-2000 cm^3\n\t\tarasinda olan ve 2000 cm^3'ten yuksek olan");
    printf("\n\t\taraclarin vergisiz fiyatlarinin ortalamalari.");
    printf("\n\n\n\t\tMotor 1600 cm^3 icin: %.2f TL'dir.",motor1Vergisiz);
    printf("\n\t\tMotor 1601-2000 cm^3 icin: %.2f TL'dir.",motor2Vergisiz);
    printf("\n\t\tMotor 2000'ten yuksek cm^3 icin: %.2f TL'dir.",motor3Vergisiz);
    printf("\n\n\t\t=================================================");
    printf("\n\n\t\tTum araclarin vergisiz fiyatlarinin ve\n\t\t anahtar teslim satis fiyatlarinin ortalamalari.");
    printf("\n\n\t\tVergisiz fiyatlarin ortalamalari: %.2f TL",ortVergsizFiy);
    printf("\n\t\tTeslim satis fiyatlarin ortalamalari: %.2f TL",ortSatisFiy);
    printf("\n\n\t\t=================================================");
    printf("\n\n\t\tVergisiz fiyati 30000 TL'den dusuk \n\t\tve motor hacmi 1600 cm^3'u gecmeyen\n\n\t\tAraclain sayisi: %d'dir",vergSay);
    printf("\n\n\t\t=================================================");
    printf("\n\n\t\tAnahtar teslim satis fiyati 100000'den yuksek olan\n\n\t\tAraclarin sayisi: %d'dir",yuzBinSay);
    printf("\n\n\t\t=================================================");
    printf("\n\n\t\tOrtopedik engelli kisilere satilan araclarin\n\n\t\tSayisi: %d'dir",ort_say);
    printf("\n\n\t\t=================================================");
    printf("\n\n\t\tVergisiz fiyati en yuksek olan aracin");
    printf("\n\n\t\tSatis sira numarasi: %d'dir \n\t\tVergisiz fiyati: %.2f TL",vergisizSiraNo,max_vergi);
    printf("\n\t\tMotor harcimi: %d cm^3\n\t\tAnahtar teslim satis fiyati: %.2f TL",karsilikliHar,karsilikliSatis);
    printf("\n\n\t\t=================================================");
    printf("\n\n\t\tAnahtar teslim satis fiyati en yuksek olan aracin");
    printf("\n\n\t\tSatis sira numarasi: %d'dir\n\t\tVergisiz fiyati: %.2f TL",satis_sira,sat);
    printf("\n\t\tMotor harcimi: %d cm^3\n\t\tAnahtar teslim satis fiyati: %.2f TL",satis_har,max_satFiy);
    printf("\n\n\t\t=================================================");
    printf("\n\n\t\tDevlete odenen toplam OTV,KDV,MTV ve Pl.Mas. (TL)\n");
    printf("\n\t\tToplam OTV: %.2f TL",top_otv);
    printf("\n\t\tToplam KDV: %.2f TL",top_kdv);
    printf("\n\t\tToplam MTV: %.2f TL",top_mtv);
    printf("\n\t\tToplam plaka masrafi: %d TL",top_plakaMas);
    printf("\n\n\t\t%d arac icin:\n\t\tToplam Devlete odenen: %.2f TL",siraNumarasi,toplam);
    printf("\n\n\t\t=================================================\n\n\n\t\t");
    system("pause");
    goster();
    printf("\n\n\n\t\t");
    system("pause");
    return 0;
}
/// Basta belirtilen funksyonlar.
void goster()
{
    int m,h;
    char metin[]="Proje SELIM AGOVIC yazdi.";
    printf("\n\n");

    h=0;
    printf("\t\t");
    for (;;)
    {
        for(m=0; m<10000000; m++);
        for(m=0; m<10000000; m++);
        printf("%c",metin[h]);
        h++;
        if (h==strlen(metin))
        {
            printf(" ");
            break;
        }
    }
}
void goster2()
{
    int i,j;
    char metin[]="OTOMOBIL SATIS SISTEMI";
    printf("\n\n");
    j=0;
    printf("\t\t");
    for (;;)
    {
        for(i=0; i<1000000; i++);
        for(i=0; i<10000000; i++);
        printf("%c",metin[j]);
        j++;
        if (j==strlen(metin))
        {
            printf(" ");
            break;
        }
    }
}
void goster3()
{
    int e,r;
    char metin[]="ARABALARIN TUM SONUCLARI";
    printf("\n\n");
    r=0;
    printf("\t\t  ");
    for (;;)
    {
        for(e=0; e<100000; e++);
        for(e=0; e<10000000; e++);
        for(e=0; e<1000000; e++);
        printf("%c",metin[r]);
        r++;
        if (r==strlen(metin))
        {
            printf(" ");
            break;
        }
    }
}
void goster4()
{
    int q,w;

    char metin[]= {'H','E','S','A','P','L','I','Y','O','R',58,176,176,176,176,177,177,177,177,178,178,178,178,219,219,219,219};
    printf("\n\n");
    w=0;
    printf("\t\t");
    for (;;)
    {
        for(q=0; q<1000000; q++);
        for(q=0; q<10000000; q++);
        printf("%c",metin[w]);
        w++;
        if (w==strlen(metin)-1)
        {
            printf(" ");
            break;
        }
    }

}
void goster5()
{
    int l,o;
    char metin2[]="BU ARABANIN GIRDIKLERI";
    printf("\n\n");
    l=0;

    printf("\t\t   ");
    for (;;)
    {
        for(o=0; o<1000000; o++);
        for(o=0; o<10000000; o++);
        printf("%c",metin2[l]);
        l++;
        if (l==strlen(metin2))
        {
            printf(" ");
            break;
        }
    }
}
