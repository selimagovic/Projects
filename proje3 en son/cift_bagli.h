#ifndef CIFT_BAGLI_LISTE_H_INCLUDED
#define CIFT_BAGLI_LISTE_H_INCLUDED
#include "ucus.h"
#include <iostream>
class Cift_bagli_liste
{
friend ostream &operator<<(ostream&,Cift_bagli_liste&);
private:
    Ucus *ilk,*son;
    int bekleyen_sayisi;
public:
    Cift_bagli_liste();
    void ekle(Ucus *);
    void Sil(Ucus*);
    bool bos_mu();
    int bekleyen_sayisi_oku();
    Ucus *ilk_oku();
    Ucus*son_oku();
};


#endif // CIFT_BAGLI_LISTE_H_INCLUDED
