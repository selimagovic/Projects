#include <iostream>
#include <iomanip>
#include <cstring>

using namespace std;

#include "ucus.h"
#include "yazdir.h"

Yazdir::Yazdir()
{
    ilk=new Ucus(0,NULL,NULL,NULL,0,0);
    ilk->sonrakiAyarla(NULL);
}
void Yazdir::ekle(Ucus *yeni)
{
    Ucus *onceki,*gecici;

    onceki=ilk;
    gecici=ilk->sonrakiOku();

    while(gecici!=NULL && yeni->ucusNoOku()<=gecici->ucusNoOku())
    {
        onceki=gecici;
        gecici=gecici->sonrakiOku();
    }/*end while*/
    yeni->sonrakiAyarla(gecici);
    onceki->sonrakiAyarla(yeni);

}
Ucus *Yazdir::arama(int ucusNo)
{
    Ucus *gecici;
    gecici=ilk->sonrakiOku();

    while (gecici != NULL)
    {
        if (gecici->ucusNoOku()==ucusNo)
            return gecici;
        gecici=gecici->sonrakiOku();
    }
    return NULL;
}
Ucus *Yazdir::AdaAra(char aranan)
{
    Ucus *gecici;

    gecici=ilk;//prvi = ilk

    while(gecici != NULL)
    {
        if(strcmp(gecici->varYeriOku(),aranan)==0)
        {

            cout<<aranan;
        }
        gecici=gecici->sonrakiOku();
    }
    return NULL;
}

Ucus *Yazdir::cikar(int silinecek)
{
    Ucus *gecici,*onceki;
    onceki=ilk;
    gecici=ilk->sonrakiOku();
    while(gecici!=NULL && gecici->ucusNoOku()<silinecek)
    {
        onceki=gecici;
        gecici=gecici->sonrakiOku();

    }
    if(gecici->ucusNoOku()!=silinecek)
        return NULL;
    else
    {

        onceki->sonrakiAyarla(gecici->sonrakiOku());

        return(gecici);
    }

}

bool Yazdir::bos_mu()
{
    return ilk->sonrakiOku()==NULL;
}/*
void Yazdir::listele()
{

    Ucus *gecici=ilk->sonrakiOku();

    while(gecici!=NULL)
    {
        gecici->yazdir();
        gecici=gecici->sonrakiOku();
    }
}*/
ostream &operator<<(ostream &output,Ucus &airlines)
{
    output<<airlines.ucusNoOku()<<airlines.zamanOku()<<airlines.luxkapOku()<<airlines.norkapOku();
    return output;
}














