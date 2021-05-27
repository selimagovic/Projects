/*******************************************\
 * DERSIN ADI: ALGORITMA VE PROGRAMLAMA 2   *
 * PROJE ADI: Futbol Ligi Takip Sistemi v2  *
 *                                          *
 * PROJE YAZAN KISILER:                     *
 * EROLL RAMAXHIK - 05 10 0000 901          *
 * SELIM AGOVIC - 05 11 0000 797            *
 * ONUR PALA - 05 10 0000 871               *
\*******************************************/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#define YIRMI 21
#define YUZ 100

struct OYUNCU
{
    int t_kod;              /// TAKIMIN KODU
    int f_no;               /// FUTBOLCUNUN FORMA NUMARASI
    char f_ad[YIRMI];       /// FUTBOLCUNUN AD VE SOYAD
    int a_gol;              /// FUTBOLCUNUN ATTIGI GOL
    struct OYUNCU *sonraki; /// POINTER SONRAKI OYUNCU ICIN

};
struct TAKIM
{
    int t_kod;              /// TAKIMIN KODU
    char t_ad[YIRMI];       /// TAKIMI ADI
    int g_say;              /// TAKIMIN GALIBIYET SAYISI
    int b_say;              /// TAKIMIN BERABERLIK SAYISI
    int m_say;              /// TAKIMIN MAGLUBIYET SAYISI
    int a_gol;              /// TAKIMIN ATTIGI GOL SAYISI
    int y_gol;              /// TAKIMIN YEDIGI GOL SAYISI

    struct OYUNCU *sonraki_oyuncu;  /// TAKIMDA FUTBOLCUNUN SONRAKI DUGUM
    struct SKORLAR *sonraki_hafta;  /// TAKIMDA SKORLARIN SONRAKI DUGUM
};
struct SKORLAR
{
    int h_no;               /// SKORLARIN HAFTA NUMARASI
    int ev_kod;             /// SKORLARIN EV SAHIBI TAKIMIN KODU
    int mis_kod;            /// SKORLARIN MISAFIRIN TAKIMIN KODU
    int ev_gol;             /// SKORLARIN EV SAHIBI ATTIGI GOL SAYISI
    int mis_gol;            /// KORLARIN MISAFIRIN ATTIGI GOL SAYISI
    struct SKORLAR *sonraki;/// POINTER SONRAKI SKOR ICIN
};
/// FONKSYON PROTOTIPLERI
void goster_takim()
{
    printf("\n\tTakim Kod  Takim Adi             OO GG BB MM AA YY AVR Puan");
    printf("\n\t---------  --------------------- -- -- -- -- -- -- --- ----");
}
void goster_takim_ve_oyuncu()
{
    printf("\n\tTakim Kod  Takim Adi             Forma no Ad Soyad             AA");
    printf("\n\t---------  --------------------- -------- -------------------- --");
}
void goster_Oyuncu()
{
    printf("\n\tFutbolcu Bilgileri:");
    printf("\n\tForma No        Ad Soyad          AA");
    printf("\n\t--------  --------------------    --");
}
void goster_skorlar()
{
    printf("\n\tOynadigi maclarin skorlari:\n");
    printf("\n\t    EV SAHIBI                         MISAFIR");
    printf("\n\tHAFTA       TAKIM ADI                 TAKIM ADI");
    printf("\n\t----- -------------------- -- -- --------------------");
}
void goster1();
void goster2()
{
    int i,j;
    char metin[]="PROGRAM BASARILIYLA SONLANDIRILDI";
    printf("\n\n");
    j=0;
    printf("\t");
    for (;;)
    {
        for(i=0; i<100000; i++);
        for(i=0; i<1000000; i++);
        printf("%c",metin[j]);
        j++;
        if (j==strlen(metin))
        {
            printf(" ");
            break;
        }
    }
}
int menu(void);
int sil_oyuncu(struct OYUNCU *,int, struct TAKIM *[],int);
void yazdir_oyuncu(struct OYUNCU *);

int main()
{
    ///
    system("title Futbol Ligi Takip Sistemi v2");
    system("color a");
    struct TAKIM *team[YUZ] = {NULL};                                       /// 100 DIZILIK STRUCT OLUSTURULUR
    int fno,ikinci_fno,kontrol;
    struct OYUNCU *futBilgi,*onceki,*simdiki,*yeni_futbolcu,*gecici,*temp;
    char aranan_takim[YIRMI],cvp,max_ad[21];                                /// DEGISKENLER BELIRLENIR

    struct SKORLAR *skor,*onceki_skor,*simdiki_skor;                       /// ARAMA YAPMAK ICIN EKLENIR
    struct SKORLAR *skor2,*onceki_skor2,*simdiki_skor2;                    /// AYNI SEKILDE ARAMA ICIN EKLENIR
    int tkod,ikinci_tkod,j=0,max=0;

    int sec,i=0,k=0,max_gol,max_kod,max_fno;
    int found,evkod,miskod,evgol,misgol,hno,bulundu;
    int oo=0,avr=0,puan=0;
    goster1();
    while((sec=menu())!=12)                                                 /// YANLIS GIRIS YAPILMAMASI SAGLANIR
    {
        switch(sec)                                                         /// SECIM YAPILIR
        {
        case 1:
            system("cls");                                                  /// C DEKI EKRAN TEMIZLEME FONKSYONU
            printf("\n\tTAKIM EKLEME FONKSYONA GIRDINIZ\n\n");
            printf("\t Takimin kodu giriniz (1-99):\n\t--> ");
            scanf("%d",&tkod);                                              /// KULLANICININ GIRDIGI KODU ALIR
            while(tkod<1 || tkod>99)                                        /// YANLIS GIRIS YAPILMAMASI ICIN KOD KONTROL EDILIR
            {
                printf("\n\tYanlis girdiniz!!!\n\tLutfen tekrar Takim kodu giriniz:\n\t--> ");
                scanf("%d",&tkod);
            }
            if(team[tkod-1]==NULL)                                          /// TAKIM KODU DAHA ONCE KULLANILMADIYSA YENI TAKIM OLUSTURULUR
            {
                i=0;
                team[tkod-1]=malloc(sizeof(struct TAKIM));                  /// YENI DUGUM OLUSTURULUR
                team[tkod-1]->t_kod = tkod;                                 /// TAKIM DUGUMUNDEKI TAKIM KODU BELIRLENIR
                team[tkod-1]->sonraki_oyuncu=NULL;                          /// YENI DUGUM ICIN SONRAKI FUTBOLCUNUN DUGUMU NULL (BOS) ATILIR
                team[tkod-1]->sonraki_hafta=NULL;                           /// YENI DUGUM ICIN SONRAKI FUTBOLCUNUN DUGUMU NULL (BOS) ATILIR
                fflush(stdin);
                printf("\n\tTakim isimini giriniz:\n\t--> ");
                gets(team[tkod-1]->t_ad);                                   /// GETS FONKSYONU STRINGI ALIR
                while(team[tkod-1]->t_ad[i])
                {
                    team[tkod-1]->t_ad[i]=(toupper(team[tkod-1]->t_ad[i])); /// HARFLER BUYUTULUR
                    i++;
                }
                team[tkod-1]->b_say=0;                                      /// TAKIM DUGUMDEKI BERABERLIK SAYISI BELIRLENIR
                team[tkod-1]->g_say=0;                                      /// TAKIM DUGUMDEKI GALIBIYET SAYISI BELIRLENIR
                team[tkod-1]->m_say=0;                                      /// TAKIM DUGUMDEKI MAGLUBIYET SAYISI BELIRLENIR
                team[tkod-1]->a_gol=0;                                      /// TAKIM DUGUMDEKI ATTIGI GOL SAYISI BELIRLENIR
                team[tkod-1]->y_gol=0;                                      /// TAKIM DUGUMDEKI YEDIGI GOL SAYISI BELIRLENIR
                printf("\n\t%s TAKIMI BASARIYLA OLUSTURDUNUZ!!!",team[tkod-1]->t_ad);
            }
            else
                printf("\n\t Girdiginiz takim kodu (%d) daha once kullandiniz!!!",tkod);
            printf("\n\n");
            system("\tpause");
            break;
        case 2:
            system("cls");
            printf("\n\tLIG DISINDAN TRANSFER EDILMESI FONKSYONA GIRDINIZ\n\n");
            do
            {
                printf("\n\tTakim kodu giriniz:\n\t--> ");
                scanf("%d",&tkod);
            }
            while(tkod<1 || tkod>99);
            if(team[tkod-1]!=NULL)                                                  /// TAKIM BOS DEGILSE YENI BIR FUTBOLCU OLUSTURULUR
            {
                fflush(stdin);
                do
                {
                    printf("\n\tFutbolcunun forma numarasi giriniz:\n\t--> ");
                    scanf("%d",&fno);                                               /// FUTBOLCUNUN FORMA NUMARASI ALINIR VE OYUNCU DUGUME BAGLANIR
                }
                while(fno<1 || fno>99);

                gecici=team[tkod-1]->sonraki_oyuncu;                                /// FORMA NUMARASI DAHA ONCE KULLANILDIYSA ASAGDAKI
                while(gecici!=NULL && gecici->f_no!=fno)                            /// MESAJ VERILIR
                {
                    gecici=gecici->sonraki;
                }
                if(gecici!=NULL)
                    printf("\n\tForma numaraya ait oyuncu var.");
                else
                {
                    /// FORMA NUMARASI DAHA ONCE KULLANILMADIYSA YENI FUTBOLCU OLUSTURULUR VE FUTBOLCUYA
                    /// AIT DIGER BILGILER ALINIR DUGUME BAGLANIR VE SONRAKI FUTBOLCU DUGUM ICIN NULL (BOS) OLARAK GOSTERILIR
                    futBilgi=malloc(sizeof(struct TAKIM));
                    futBilgi->t_kod = tkod;
                    futBilgi->f_no = fno;
                    j=0;
                    fflush(stdin);
                    printf("\n\tFutbolcunun ad ve soyad giriniz:\n\t--> ");
                    gets(futBilgi->f_ad);

                    while(futBilgi->f_ad[j])
                    {
                        futBilgi->f_ad[j] = toupper(futBilgi->f_ad[j]);
                        j++;
                    }
                    futBilgi->a_gol=0;
                    futBilgi->sonraki=NULL;

                    onceki=NULL;
                    simdiki=team[tkod-1]->sonraki_oyuncu;

                    while(simdiki!=NULL && fno > simdiki->f_no)
                    {
                        onceki=simdiki;
                        simdiki=simdiki->sonraki;
                    }
                    if(onceki==NULL)
                    {
                        futBilgi->sonraki=team[tkod-1]->sonraki_oyuncu;
                        team[tkod-1]->sonraki_oyuncu=futBilgi;
                    }
                    else
                    {
                        onceki->sonraki=futBilgi;
                        futBilgi->sonraki=simdiki;
                    }
                    printf("\n\tTRANSFER BASARIYLA GERCEKLESTIRDINIZ!!!");
                }

            }
            else
                printf("\n\tyazdiginiz takim kodu bulunamadi.");
            printf("\n\n");
            system("\tpause");
            break;
        case 3:
            system("cls");
            printf("\n\tLIG DISINDA TRANSFER EDILMESI FONKSYONA GIRDINIZ\n\n");
            /// CASE 3 BIR TAKIMDAN BASKA BIR TAKIMA OYUNCU TRANSFER EDILIR VE TRANSFER ISLEMI GERCEKLESTIRILIR
            do
            {
                printf("\n\tFutbolcunun takim kodu giriniz:\n\t-> ");
                scanf("%d",&tkod);
            }
            while(team[tkod-1]==NULL || tkod<1 || tkod>99);
            do
            {
                printf("\n\tFutbolcunun forma numarasi giriniz:\n\t-> ");
                scanf("%d",&fno);
                yeni_futbolcu=team[tkod-1]->sonraki_oyuncu;
                /// ILK DUGUMDE FORMA NUMARASI MEVCUT ISE DIREKT ALIR VE KULLANICIDAN
                /// TRANSFER EDECEGI TAKIMIN KODU VE YENI FORMA NUMARASI SORULUR
                if(fno==yeni_futbolcu->f_no)
                {
                    found=1;
                    team[tkod-1]->sonraki_oyuncu=yeni_futbolcu->sonraki;
                    gecici=yeni_futbolcu;
                }
                else
                {
                    onceki=team[tkod-1]->sonraki_oyuncu;
                    simdiki=onceki->sonraki;
                    while(simdiki!=NULL)
                    {
                        if(fno==simdiki->f_no)
                        {
                            found=1;
                            gecici=simdiki;
                            onceki->sonraki=simdiki->sonraki;
                        }
                        onceki=simdiki;
                        simdiki=simdiki->sonraki;
                    }
                }

                if(found==0)
                    printf("\n\tYazdiginiz forma numara bulunamadi.");
            }
            while(found==0);
            do
            {
                printf("\n\tTransfer edecek takima takim kod giriniz:\n\t->");
                scanf("%d",&ikinci_tkod);
            }
            while(team[ikinci_tkod-1]==NULL);
            do
            {
                found=0;
                printf("\n\tIkinci takimda futbolcunun forma numarasi yaziniz:\n\t->");
                scanf("%d",&ikinci_fno);
                temp=team[ikinci_tkod-1]->sonraki_oyuncu;
                /// YENI OYUNCU ICIN GIRILEN FORMA NUMARASI KONTROL EDILIR
                /// DAHA ONCE GIRILEN FORMA NUMARASININ OLUP OLMADIGI KONTROL EDILIR
                while(temp!=NULL && temp->f_no!=ikinci_fno)
                {
                    temp=temp->sonraki;
                }
                /// FORMA NO BOS ISE YENI TAKIMDAKI FUTBOLCUYU TRANSFER EDILIR
                if(temp==NULL)
                {
                    gecici->f_no=ikinci_fno;
                    onceki=NULL;
                    simdiki=team[ikinci_tkod-1]->sonraki_oyuncu;
                    while(simdiki!=NULL && ikinci_fno>simdiki->f_no)
                    {
                        onceki=simdiki;
                        simdiki=simdiki->sonraki;
                    }
                    if(onceki==NULL)
                    {
                        gecici->sonraki=team[ikinci_tkod-1]->sonraki_oyuncu;
                        team[ikinci_tkod-1]->sonraki_oyuncu=gecici;
                    }
                    else
                    {
                        onceki->sonraki=gecici;
                        gecici->sonraki=simdiki;
                    }
                    printf("\n\tTRANSFER BASARIYLA GERCEKLESTIRDINIZ!!!");
                }
                else
                {
                    printf("\n\tOyuncu forma numarasi zaten var.");
                    found=1;
                }
            }
            while(found==1);
            printf("\n\n");
            system("\tpause");
            break;
        case 4:
            system("cls");
            printf("\n\tLIG DISINDA TRANSFER EDILMESI FONKSYONA GIRDINIZ\n\n");

            /// CASE 4 BIR TAKIMIN FUTBOLCUSU SILINIR
            printf("\n\tFutbolcunun takim kodu giriniz:\n\t-> ");
            scanf("%d",&tkod);

            if(team[tkod-1]!=NULL)
            {
                printf("\n\tFutbolcunun forma numarasi giriniz:\n\t-> ");
                scanf("%d",&fno);
                gecici=team[tkod-1]->sonraki_oyuncu;
                while(gecici!=NULL && gecici->f_no!=fno)
                    gecici=gecici->sonraki;
                if(gecici!=NULL)
                {
                    /// GIRILEN TAKIM KODU ILK SIRADA ISE ALINIR VE SILINIR DEGILSE
                    /// SONUNA GIDILIR YANI BOS OLANA KADAR
                    if(fno==team[tkod-1]->sonraki_oyuncu->f_no)
                    {
                        gecici=team[tkod-1]->sonraki_oyuncu;
                        team[tkod-1]->sonraki_oyuncu=team[tkod-1]->sonraki_oyuncu->sonraki;
                        free(gecici);   /// FREE FONKSYONU DUGUMDEKI TUM BILGILERI SILER VE BELEKTEKI YERI FREE LER
                    }
                    else
                    {
                        onceki=team[tkod-1]->sonraki_oyuncu;
                        simdiki=onceki->sonraki;

                        while(simdiki!=NULL && simdiki->f_no!=fno)
                        {
                            onceki=simdiki;
                            simdiki=simdiki->sonraki;
                        }
                        if(simdiki!=NULL)
                        {
                            gecici=simdiki;
                            onceki->sonraki=simdiki->sonraki;
                            free(gecici);
                        }
                    }
                }
                else
                    printf("\n\tFutbolcunun forma numarasi bulunamadi.");
            }
            else
                printf("\n\t Yazdiginiz Takim kodu (%d) bulunamadi!!!",tkod);
            printf("\n\n");
            system("\tpause");
            break;
        case 5:
            system("cls");
            printf("\n\tMAC SKORLARIN KAYDEDILMESI FONKSYONA GIRDINIZ\n\n");
            /// CASE 5 YENI SKORLARIN GIRILMESI
            do
            {
                /// SKORLAR ICIN BELLEKTEKI YER AYRILIR

                /// TUM GEREKLI BILGILER ALINIR VE SONUNDA YENI OLUSTURULAN DUGUME ATANIR
                skor=malloc(sizeof(struct SKORLAR));
                skor2=malloc(sizeof(struct SKORLAR));
                printf("\n\tHafta no giriniz:\n\t--> ");
                scanf("%d",&hno);

                do
                {
                    printf("\n\tEv sahibinin takim kodu giriniz:\n\t-> ");
                    scanf("%d",&evkod);
                }
                while(evkod<1 || evkod>99);

                if(team[evkod-1]->sonraki_oyuncu==NULL )
                {
                    printf("\n\t%d TAKIMINDA OYUNCU MEVCUT DEGIL",evkod);
                    break;
                }
                fflush(stdin);
                do
                {
                    printf("\n\tMisafirin takim kodu giriniz:\n\t-> ");
                    scanf("%d",&miskod);
                }
                while(miskod<1 || miskod>99);
                while(miskod==evkod)
                {
                    printf("\n\tKodu daha once ev sahibi olarak girdiniz\n");
                    printf("\tMisafirin takim kodu giriniz:\n\t-> ");
                    scanf("%d",&miskod);
                }

                if(team[miskod-1]->sonraki_oyuncu==NULL )
                {
                    printf("\n\t%d TAKIMINDA OYUNCU MEVCUT DEGIL",miskod);
                    break;
                }
                /// TAKIM KODUNUN YANLIS GIRILMEMESI ICIN KONTROL EDILIR
                if(team[evkod-1]!=NULL && team[miskod-1]!=NULL)
                {
                    printf("\n\tEv Sahib Takimin Adi\n\t-----------------------");
                    printf("\n\t%-20s\n",team[evkod-1]->t_ad);
                    fflush(stdin);
                    printf("\n\tEv sahibin attilan gol sayisi yaziniz:\n\t-> ");
                    scanf("%d",&evgol);
                    if(evgol>0)
                        for(i=0; i<evgol; i++)
                        {
                            do
                            {
                                kontrol=0;
                                printf("\n\t%d. golu atan forma numara giriniz:\n\t-> ",i+1);
                                scanf("%d",&fno);
                                if(team[evkod-1]->sonraki_oyuncu->f_no==fno)
                                {
                                    team[evkod-1]->sonraki_oyuncu->a_gol+=1;
                                    kontrol=1;
                                }
                                else
                                {
                                    onceki=team[evkod-1]->sonraki_oyuncu;
                                    simdiki=onceki->sonraki;

                                    while(simdiki!=NULL)
                                    {
                                        if(simdiki->f_no==fno)
                                        {
                                            kontrol=1;
                                            simdiki->a_gol+=1;
                                        }
                                        onceki=simdiki;
                                        simdiki=simdiki->sonraki;
                                    }
                                }
                                if(kontrol==0)
                                    printf("\n\tGirdiginiz forma no mevcut degil.\n");
                            }
                            while(kontrol==0);
                        }

                    printf("\n\tMisafir Takimin Adi\n\t----------------------- ");
                    printf("\n\t%-20s\n",team[miskod-1]->t_ad);
                    fflush(stdin);
                    printf("\n\tMisafir attilan gol sayisi yaziniz:\n\t-> ");
                    scanf("%d",&misgol);

                    if(misgol>0)
                        for(i=0; i<misgol; i++)
                        {
                            do
                            {
                                kontrol=0;
                                printf("\n\t%d. golu atan forma numara giriniz:\n\t-> ",i+1);
                                scanf("%d",&fno);
                                if(team[miskod-1]->sonraki_oyuncu->f_no==fno)
                                {
                                    team[miskod-1]->sonraki_oyuncu->a_gol+=1;
                                    kontrol=1;
                                }
                                else
                                {
                                    onceki=team[miskod-1]->sonraki_oyuncu;
                                    simdiki=onceki->sonraki;

                                    while(simdiki!=NULL)
                                    {
                                        if(simdiki->f_no==fno)
                                        {
                                            kontrol=1;
                                            simdiki->a_gol+=1;
                                        }
                                        onceki=simdiki;
                                        simdiki=simdiki->sonraki;
                                    }
                                }
                                if(kontrol==0)
                                    printf("\n\tGirdiginiz forma no mevcut degil.\n");
                            }
                            while(kontrol==0);
                        }
                    skor->h_no=hno;
                    skor->ev_kod=evkod;
                    skor->mis_kod=miskod;
                    skor->ev_gol=evgol;
                    skor->mis_gol=misgol;

                    skor2->h_no=hno;
                    skor2->ev_kod=evkod;
                    skor2->mis_kod=miskod;
                    skor2->ev_gol=evgol;
                    skor2->mis_gol=misgol;
                    if(evgol>misgol)
                    {
                        team[evkod-1]->g_say+=1;
                        team[miskod-1]->m_say+=1;
                    }
                    if(evgol==misgol)
                    {
                        team[evkod-1]->b_say+=1;
                        team[miskod-1]->b_say+=1;
                    }
                    if(evgol<misgol)
                    {
                        team[evkod-1]->m_say+=1;
                        team[miskod-1]->g_say+=1;
                    }
                    team[evkod-1]->a_gol+=evgol;
                    team[evkod-1]->y_gol+=misgol;
                    team[miskod-1]->a_gol+=misgol;
                    team[miskod-1]->y_gol+=evgol;

                    if(team[evkod-1]->sonraki_hafta==NULL)
                    {
                        team[evkod-1]->sonraki_hafta=skor;
                        skor->sonraki=NULL;
                    }
                    else
                    {
                        onceki_skor=NULL;
                        simdiki_skor=team[evkod-1]->sonraki_hafta;

                        while(simdiki_skor!=NULL && skor->h_no > simdiki_skor->h_no)
                        {
                            onceki_skor=simdiki_skor;
                            simdiki_skor=simdiki_skor->sonraki;
                        }
                        if(onceki_skor==NULL)
                        {
                            skor->sonraki=team[evkod-1]->sonraki_hafta;
                            team[evkod-1]->sonraki_hafta=skor;
                        }
                        else
                        {
                            onceki_skor->sonraki=skor;
                            skor->sonraki=simdiki_skor;
                        }
                    }

                    if(team[miskod-1]->sonraki_hafta==NULL)
                    {
                        team[miskod-1]->sonraki_hafta=skor2;
                        skor2->sonraki=NULL;
                    }
                    else
                    {
                        onceki_skor2=NULL;
                        simdiki_skor2=team[miskod-1]->sonraki_hafta;

                        while(simdiki_skor2!=NULL && skor2->h_no > simdiki_skor2->h_no)
                        {
                            onceki_skor2=simdiki_skor2;
                            simdiki_skor2=simdiki_skor2->sonraki;
                        }
                        if(onceki_skor2==NULL)
                        {
                            skor2->sonraki=team[evkod-1]->sonraki_hafta;
                            team[evkod-1]->sonraki_hafta=skor2;
                        }
                        else
                        {
                            onceki_skor2->sonraki=skor2;
                            skor2->sonraki=simdiki_skor2;
                        }
                    }
                }
                else
                {
                    system("cls");
                    printf("\n\n\tYazdiginiz takim kodlari (%d,%d) bulunamadi!!!\n",evkod,miskod);
                }

                do
                {
                    fflush(stdin);
                    printf("\n\tBaska eklenecek skorlar var mi?\n\t-> ");
                    cvp=getchar();
                }
                while(cvp!='e' && cvp!='E' && cvp!='h' && cvp!='H');
            }
            while(cvp=='e' || cvp=='E');
            printf("\n\n");
            system("\tpause");
            break;
        case 6:
            system("cls");
            printf("\n\tTAKIMIN DURUM VE FUTBOLCULAR FONKSYONA GIRDINIZ\n\n");
            /// TAKIMLARA AIT BILGILERI VE FUTBOLCULAR GOSTERILIR
            bulundu=0;
            found=1;
            j=0;
            k=0;
            printf("\n\tAranacak takimin adi yaziniz:\n\t--> ");
            scanf("%s",aranan_takim);                               /// KULLANICIDAN TAKIMIN ISMI ALINIR VE
            while(aranan_takim[j])
            {
                aranan_takim[j]=toupper(aranan_takim[j]);
                j++;
            }

            while(team[tkod-1]->t_ad[k])
            {
                team[tkod-1]->t_ad[k]=toupper(team[tkod-1]->t_ad[k]);
                k++;
            }

            for(i=0; i<100; i++)                                    /// OLUP OLMADIGI KONTROL EDILIR
            {
                if(team[i]!=NULL)
                {
                    found=strcmp(aranan_takim,team[i]->t_ad);
                    if(found==0)
                    {
                        found=i;
                        bulundu=1;
                        break;
                    }
                }
            }
            if(bulundu==1)                                              /// BULUNDUYSA TAKIMIN TUM BILGILERI GOSTERILIR
            {
                /// O TAKIMA AIT FUTBOLCULAR GOSTERILIR
                goster_takim();
                k=0;
                oo=0;
                avr=0;
                puan=0;

                while(team[found]->t_ad[k])
                {
                    team[found]->t_ad[k]=(toupper(team[found]->t_ad[k]));
                    k++;
                }
                oo=team[found]->b_say+team[found]->g_say+team[found]->m_say;
                avr=team[found]->a_gol-team[found]->y_gol;
                for(i=0; i<team[found]->g_say; i++)
                    puan+=3;
                for(i=0; i<team[found]->b_say; i++)
                    puan+=1;
                printf("\n\t%3d        %-20s%3d  %-2d %-2d %-2d %-2d %-2d i%-3d %-4d",team[found]->t_kod, team[found]->t_ad,
                       oo,team[found]->g_say,team[found]->b_say,team[found]->m_say,team[found]->a_gol,team[found]->y_gol,avr,puan);
                printf("\n\t-----------------------------------------------------------\n");
                futBilgi=team[found]->sonraki_oyuncu;
                yazdir_oyuncu(futBilgi);
                printf("\n\t------------------------------------");

            }
            else
                printf("\n\tYazdiginiz takim ismi bulunamadi.");

            printf("\n\n");
            system("\tpause");
            break;
        case 7:
            system("cls");
            printf("\n\tTAKIMIN DURUM VE OYNADIGI MACLAR FONKSYONA GIRDINIZ\n\n");

            do
            {
                printf("\n\tTakim kodu giriniz:\n\t-> ");
                scanf("%d",&tkod);
            }
            while(tkod<1 || tkod>99);

            if(team[tkod-1]!=NULL)
            {
                goster_takim();
                k=0;
                oo=0;
                avr=0;
                puan=0;

                while(team[tkod-1]->t_ad[k])
                {
                    team[tkod-1]->t_ad[k]=(toupper(team[tkod-1]->t_ad[k]));
                    k++;
                }
                oo=team[tkod-1]->b_say+team[tkod-1]->g_say+team[tkod-1]->m_say;
                avr=team[tkod-1]->a_gol-team[tkod-1]->y_gol;
                for(i=0; i<team[tkod-1]->g_say; i++)
                    puan+=3;
                for(i=0; i<team[tkod-1]->b_say; i++)
                    puan+=1;
                printf("\n\t%3d        %-20s%3d  %-2d %-2d %-2d %-2d %-2d i%-3d %-4d",team[tkod-1]->t_kod, team[tkod-1]->t_ad,
                       oo,team[tkod-1]->g_say,team[tkod-1]->b_say,team[tkod-1]->m_say,team[tkod-1]->a_gol,
                       team[tkod-1]->y_gol,avr,puan);
                if(team[tkod-1]->sonraki_hafta==NULL)
                {
                    printf("\n\tTAKIMIN OYNANMIS MACI BULUNMAMAKTADIR");
                }
                else
                {
                    printf("\n");
                    goster_skorlar();
                    onceki_skor2=team[tkod-1]->sonraki_hafta;
                    while(onceki_skor2!=NULL)
                    {
                        printf("\n\t%3d.",onceki_skor2->h_no);
                        printf("  %-20s%2d :%2d ",team[onceki_skor2->ev_kod-1]->t_ad,
                               onceki_skor2->ev_gol,onceki_skor2->mis_gol);
                        printf("    %-20s",team[onceki_skor2->mis_kod-1]->t_ad);
                        onceki_skor2=onceki_skor2->sonraki;
                    }
                }
            }
            else
                printf("\n\tYazdiginiz takim kodu bulunamadi");
            printf("\n\n");
            system("\tpause");
            break;
        case 8:
            system("cls");
            printf("\n\tTUM TAKIMLARIN DURUMLARI FONKSYONA GIRDINIZ\n\n");
            goster_takim();
            for(j=0; j<100; j++)
            {
                if(team[j]==NULL)
                    continue;
                k=0;
                oo=0;
                avr=0;
                puan=0;

                while(team[j]->t_ad[k])
                {
                    team[j]->t_ad[k]=(toupper(team[j]->t_ad[k]));
                    k++;
                }
                oo=team[j]->b_say+team[j]->g_say+team[j]->m_say;
                avr=team[j]->a_gol-team[j]->y_gol;
                for(i=0; i<team[j]->g_say; i++)
                    puan+=3;
                for(i=0; i<team[j]->b_say; i++)
                    puan+=1;
                printf("\n\t%3d        %-20s%3d  %-2d %-2d %-2d %-2d %-2d i%-3d %-4d",team[j]->t_kod, team[j]->t_ad,
                       oo,team[j]->g_say,team[j]->b_say,team[j]->m_say,team[j]->a_gol,team[j]->y_gol,avr,puan);
            }
            printf("\n\t-----------------------------------------------------------");
            printf("\n\n");
            system("\tpause");
            break;
        case 9:
            system("cls");
            printf("\n\tCOK GOL ATAN VE AZ GOL YIYEN TAKIMLARI FONKSYONA GIRDINIZ\n\n");

            max=100;
            for(i=0; i<100; i++)
            {
                max_gol=0;
                if(team[i]==NULL)
                    continue;

                if(team[i]->a_gol>max_gol)
                {
                    max_kod=team[i]->t_kod;
                }
                if(team[i]->y_gol<max)
                {
                    max=team[i]->t_kod;
                }
            }
            goster_takim();
            k=0;
            oo=0;
            avr=0;
            puan=0;

            while(team[max_kod-1]->t_ad[k])
            {
                team[max_kod-1]->t_ad[k]=(toupper(team[max_kod-1]->t_ad[k]));
                k++;
            }
            oo=team[max_kod-1]->b_say+team[max_kod-1]->g_say+team[max_kod-1]->m_say;
            avr=team[max_kod-1]->a_gol-team[max_kod-1]->y_gol;
            for(i=0; i<team[max_kod-1]->g_say; i++)
                puan+=3;
            for(i=0; i<team[max_kod-1]->b_say; i++)
                puan+=1;
            printf("\n\t%3d        %-20s%3d  %-2d %-2d %-2d %-2d %-2d i%-3d %-4d",team[max_kod-1]->t_kod, team[max_kod-1]->t_ad,
                   oo,team[max_kod-1]->g_say,team[max_kod-1]->b_say,team[max_kod-1]->m_say,team[max_kod-1]->a_gol,team[max_kod-1]->y_gol,avr,puan);
            k=0;
            oo=0;
            avr=0;
            puan=0;

            while(team[max-1]->t_ad[k])
            {
                team[max-1]->t_ad[k]=(toupper(team[max-1]->t_ad[k]));
                k++;
            }
            oo=team[max-1]->b_say+team[max-1]->g_say+team[max-1]->m_say;
            avr=team[max-1]->a_gol-team[max-1]->y_gol;
            for(i=0; i<team[max-1]->g_say; i++)
                puan+=3;
            for(i=0; i<team[max-1]->b_say; i++)
                puan+=1;
            printf("\n\t%3d        %-20s%3d  %-2d %-2d %-2d %-2d %-2d i%-3d %-4d",team[max-1]->t_kod, team[max-1]->t_ad,
                   oo,team[max-1]->g_say,team[max-1]->b_say,team[max-1]->m_say,team[max-1]->a_gol,team[max-1]->y_gol,avr,puan);
            printf("\n\n");
            system("\tpause");
            break;
        case 10:
            system("cls");
            printf("\n\tDEPLASMANDA EN IYI TAKIM FONKSYONA GIRDINIZ\n\n");
            /// CASE 10 DEPLASMANDA EN IYI TAKIM BULUP EKRANA GOSTERILIR
            for(i=0; i<100; i++)
            {
                if(team[i]==NULL)
                    continue;
                max=0;
                if(team[i]!=NULL)
                {
                    if(team[i]->sonraki_hafta!=NULL)
                    {
                        onceki_skor2=team[i]->sonraki_hafta;
                        while(onceki_skor2!=NULL)
                        {
                            if(onceki_skor2->mis_gol>max)
                                max=onceki_skor2->mis_kod;
                            onceki_skor2=onceki_skor2->sonraki;
                        }
                    }
                }
            }
            oo=0;
            avr=0;
            puan=0;
            goster_takim();
            while(team[max-1]->t_ad[k])
            {
                team[max-1]->t_ad[k]=(toupper(team[max-1]->t_ad[k]));
                k++;
            }
            oo=team[max-1]->b_say+team[max-1]->g_say+team[max-1]->m_say;
            avr=team[max-1]->a_gol-team[max-1]->y_gol;
            for(i=0; i<team[max-1]->g_say; i++)
                puan+=3;
            for(i=0; i<team[max-1]->b_say; i++)
                puan+=1;
            printf("\n\t%3d        %-20s%3d  %-2d %-2d %-2d %-2d %-2d i%-3d %-4d",team[max-1]->t_kod, team[max-1]->t_ad,
                   oo,team[max-1]->g_say,team[max-1]->b_say,team[max-1]->m_say,team[max-1]->a_gol,team[max-1]->y_gol,avr,puan);

            printf("\n\n");
            system("\tpause");
            break;
        case 11:
            system("cls");
            printf("\n\tTAKIMLARIN GOL KRALI VE LIGDEKI GOL KRALI FONKSYONA GIRDINIZ\n\n");
            /// CASE 11 TAKIMLARIN GOL KRALI VE LIGDEKI GOL KRALI BULUP EKRANA GOSTERILIR
            goster_takim_ve_oyuncu();
            for(i=0; i<100; i++)
            {
                if(team[i]==NULL)
                    continue;
                max_gol=0;
                if(team[i]!=NULL)
                {
                    if(team[i]->sonraki_oyuncu!=NULL)
                    {
                        onceki=team[i]->sonraki_oyuncu;
                        while(onceki!=NULL)
                        {
                            if(onceki->a_gol>max_gol)
                            {
                                max_gol=onceki->a_gol;
                                max_kod=onceki->t_kod;
                                max_fno=onceki->f_no;

                                found=strlen(onceki->f_ad);
                                for(j=0; j<found; j++)
                                {
                                    max_ad[j]=onceki->f_ad[j];
                                }
                                max_ad[found]='\0';
                            }
                            onceki=onceki->sonraki;
                        }
                        printf("\n\t%3d        %-20s  %3d       %-20s%2d",max_kod, team[max_kod-1]->t_ad,
                               max_fno,max_ad,max_gol);
                    }
                }
            }

            printf("\n\n\tLigin Gol Krali:\n");
            goster_takim_ve_oyuncu();
            for(i=0; i<100; i++)
            {
                if(team[i]==NULL)
                    continue;
                if(team[i]!=NULL)
                {
                    if(team[i]->sonraki_oyuncu!=NULL)
                    {
                        onceki=team[i]->sonraki_oyuncu;
                        while(onceki!=NULL)
                        {
                            if(onceki->a_gol>max_gol)
                            {
                                max_gol=onceki->a_gol;
                                max_kod=onceki->t_kod;
                                max_fno=onceki->f_no;

                                found=strlen(onceki->f_ad);
                                for(j=0; j<found; j++)
                                {
                                    max_ad[j]=onceki->f_ad[j];
                                }
                                max_ad[found]='\0';
                            }
                            onceki=onceki->sonraki;
                        }
                    }
                }
            }
            printf("\n\t%3d        %-20s  %3d       %-20s%2d",max_kod, team[max_kod-1]->t_ad,
                   max_fno,max_ad,max_gol);
            printf("\n\n");
            system("\tpause");
            break;

        }
    }
    printf("\n\n");
    goster2();
    printf("\n\n");
    system("pause");
    return 0;
}

/// CASE 6 DAKI TAKIMIN ADA AIT FUTBOLCULAR EKRANA GOSTERILIR
void yazdir_oyuncu(struct OYUNCU *futBilgi)
{
    if(futBilgi==NULL)
    {
        printf("\n\tBU TAKIMA AIT HIC BIR FUTBOLCU YOK");
    }
    else
    {
        goster_Oyuncu();
        while(futBilgi!=NULL)
        {
            printf("\n\t%4d      %-20s %4d",futBilgi->f_no,futBilgi->f_ad,futBilgi->a_gol);
            futBilgi=futBilgi->sonraki;
        }
    }
}
/// EKRANA ILK PROGRAM ACARKEN BU FONKSYON GOSTERILIR
int menu(void)
{
    int secim;
    system("CLS");
    printf("\n\t\t\21\26\26\20 MENU \21\26\26\20\n");
    printf("\n\t1.  Takim Ekleme fonksiyon.");
    printf("\n\t2.  Lig disindan transfer edilmesi.");
    printf("\n\t3.  Lig icinde transfer edilmesi.");
    printf("\n\t4.  Lig disinda transfer edilmesi.");
    printf("\n\t5.  Mac skorlarin kaydedilmesi.");
    printf("\n\t6.  Takimin durum ve futbolcular.");
    printf("\n\t7.  Takimin durum ve oynadigi maclar.");
    printf("\n\t8.  Tum takimlarin durumlari.");
    printf("\n\t9.  Cok gol atan ve az gol yiyen takimlari.");
    printf("\n\t10. Deplasmanda en iyi takim.");
    printf("\n\t11. Takimlarin gol krali ve ligdeki gol krali.");
    printf("\n\n\t12. CIKIS");

    printf("\n\n\t Seciminizi Giriniz: \n\t---> ");
    scanf("%d",&secim);

    return secim;
}

void goster1()
{
    int i,j;
    char metin[]="*********************************************";
    char metin2[]="* DERSIN ADI: ALGORITMA VE PROGRAMLAMA 2   *";
    char metin3[]="* PROJE ADI: Futbol Ligi Takip Sistemi v2  *";
    char metin4[]="*                                          *";
    char metin5[]="* PROJE YAZAN KISILER:                     *";
    char metin6[]="* EROLL RAMAXHIK - 05 10 0000 901          *";
    char metin7[]="* SELIM AGOVIC - 05 11 0000 797            *";
    char metin8[]="* ONUR PALA - 05 10 0000 871               *";
    char metin9[]="********************************************";
    char metin10[]="                                           ";
    printf("\n\n");
    j=0;
    printf("\t\t");
    for (;;)
    {
        for(i=0; i<100000; i++);
        for(i=0; i<1000000; i++);
        printf("%c",metin[j]);
        j++;
        if (j==strlen(metin))
        {
            printf(" ");
            break;
        }
    }
    printf("\n\n");
    j=0;
    printf("\t\t");
    for (;;)
    {
        for(i=0; i<1000000; i++);
        for(i=0; i<1000000; i++);
        printf("%c",metin2[j]);
        j++;
        if (j==strlen(metin2))
        {
            printf(" ");
            break;
        }
    }
    printf("\n\n");
    j=0;
    printf("\t\t");
    for (;;)
    {
        for(i=0; i<1000000; i++);
        for(i=0; i<1000000; i++);
        printf("%c",metin3[j]);
        j++;
        if (j==strlen(metin3))
        {
            printf(" ");
            break;
        }
    }
    printf("\n\n");
    j=0;
    printf("\t\t");
    for (;;)
    {
        for(i=0; i<100000; i++);
        for(i=0; i<1000000; i++);
        printf("%c",metin4[j]);
        j++;
        if (j==strlen(metin4))
        {
            printf(" ");
            break;
        }
    }
    printf("\n\n");
    j=0;
    printf("\t\t");
    for (;;)
    {
        for(i=0; i<100000; i++);
        for(i=0; i<1000000; i++);
        printf("%c",metin5[j]);
        j++;
        if (j==strlen(metin5))
        {
            printf(" ");
            break;
        }
    }
    printf("\n\n");
    j=0;
    printf("\t\t");
    for (;;)
    {
        for(i=0; i<100000; i++);
        for(i=0; i<10000000; i++);
        printf("%c",metin6[j]);
        j++;
        if (j==strlen(metin6))
        {
            printf(" ");
            break;
        }
    }
    printf("\n\n");
    j=0;
    printf("\t\t");
    for (;;)
    {
        for(i=0; i<100000; i++);
        for(i=0; i<10000000; i++);
        printf("%c",metin7[j]);
        j++;
        if (j==strlen(metin7))
        {
            printf(" ");
            break;
        }
    }
    printf("\n\n");
    j=0;
    printf("\t\t");
    for (;;)
    {
        for(i=0; i<100000; i++);
        for(i=0; i<10000000; i++);
        printf("%c",metin8[j]);
        j++;
        if (j==strlen(metin8))
        {
            printf(" ");
            break;
        }
    }
    printf("\n\n");
    j=0;
    printf("\t\t");
    for (;;)
    {
        for(i=0; i<100000; i++);
        for(i=0; i<10000000; i++);
        printf("%c",metin9[j]);
        j++;
        if (j==strlen(metin9))
        {
            printf(" ");
            break;
        }
    }
    printf("\n\n");
    j=0;
    printf("\t\t");
    for (;;)
    {
        for(i=0; i<100000; i++);
        for(i=0; i<1000000; i++);
        printf("%c",metin10[j]);
        j++;
        if (j==strlen(metin10))
        {
            printf(" ");
            break;
        }
    }
}




