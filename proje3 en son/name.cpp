#include <iostream>

using namespace std;

#include "ucus.h"
#include "yazdir.h"
#include "name.h"



Name::Name(char kY[],char vY[])
{
    kopyala(kalkis_yeri,kY);
    kopyala(varis_yeri,vY);
}

void Name::kopyala(char ilk[],char son[])
{
    int i=0;

    while(son[i]!='\0'){
        ilk[i]=son[i];
        i++;
    }
    ilk[i]='\0';

}


//Private uyelere erisim için gerekli okuma fonksiyonlar
char *Name::kalYeriOku()
{
    return kalkis_yeri;
}
char *Name::varYeriOku()
{
    return varis_yeri;
}
Name *Name::sonrakiOku()
{
    return sonraki;
}
void Name::kalYeriAyarla(char KY)
{
    kalkis_yeri[21]=KY;
}
void Name::varYeriAyarla(char VY)
{
    varis_yeri[21]=VY;
}
void Name::yaz()
{
    cout << endl;
    cout << "   "<<kalkis_yeri<<"  " <<varis_yeri <<endl;

}
/*
ostream &operator<<(ostream &cikti, const Name &nam)
{
    cikti<<" "<<nam.kalYeriOku()<<" "<<nam.varYeriOku();
    return cikti;
}
*/
