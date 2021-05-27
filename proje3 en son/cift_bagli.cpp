#include <iostream>

using namespace std;

#include "cift_bagli_liste.h"
#include "ucus.h"
#include "name.h"

Cift_bagli_liste::Cift_bagli_liste()
{
    Ucus*liste_basi;
    liste_basi=new Ucus(0,NULL,0,0,0);
    ilk=liste_basi;
    ilk->cift_bagli_liste_sonraki_ayarla(ilk);
    son->cift_bagli_liste_onceki_ayarla(ilk);
    bekleyen_sayisi=0;
}
void Cift_bagli_liste::ekle(Ucus *yeni)
{
    Ucus *gecici;

    gecici=ilk->cift_bagli_liste_sonrakiOku();

    while (gecici!=ilk && gecici->name->kalYeriOku()<yeni->name->kalYeriOku)
        gecici=gecici->cift_bagli_liste_sonrakiOku();

    yeni->cift_bagli_liste_sonraki_ayarla(gecici);
    yeni->cift_bagli_liste_onceki_ayarla(gecici->cift_bagli_liste_oncekiOku());
    (gecici->cift_bagli_liste_oncekiOku())->cift_bagli_liste_sonraki_ayarla(yeni);
    gecici->cift_bagli_liste_onceki_ayarla(yeni);
    bekleyen_sayisi++;
}
void Cift_bagli_liste::Sil(Ucus *silincek)
{
    (silincek->cift_bagli_liste_oncekiOku())->cift_bagli_liste_sonraki_ayarla(silincek->cift_bagli_liste_sonrakiOku());
    (silincek->cift_bagli_liste_sonrakiOku())->cift_bagli_liste_onceki_ayarla(silincek->cift_bagli_liste_oncekiOku());
    delete(silincek);
     bekleyen_sayisi--;
}
bool Cift_bagli_liste::bos_mu()
{
    return  bekleyen_sayisi==0;

}
int Cift_bagli_liste::bekleyen_sayisi_oku()
{
    return bekleyen_sayisi;
}
Personel *Cift_bagli_liste::ilk_oku()
{
    return ilk;
}
Personel *Cift_bagli_liste::son_oku()
{
    return ilk->cift_bagli_liste_oncekiOku();
}
ostream &operator<<(ostream &cikti,Cift_bagli_liste &liste)
{
    int i;
    Ucus *gecici=liste.ilk_oku();
    gecici=gecici->cift_bagli_liste_sonrakiOku();
    for (i=0;i<liste.bekleyen_sayisi_oku();i++)
    {
        cikti<<*(gecici)<<endl;
        gecici=gecici->cift_bagli_liste_sonrakiOku();
    }
    return cikti;
}

Cift_bagli* Cift_bagli::AdaAra(int aranan)
{
    Name *gecici;
    gecici=first->sonrakiOku();

    while(gecici != NULL);
    {
        if(strcmp(gecici->kalYeriOku(),aranan)==0)
            return gecici;
        gecici=first->sonrakiOku();
    }
    return NULL;
}

*/
