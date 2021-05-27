#include <iostream>
#include <cstring>

using namespace std;
#include "ucus.h"
#include "name.h"

class Ucus;

Ucus::Ucus(int No,string kalkis,string varis,string Zm,int lK,int Nk ): ucus_no(No),nor_kap(Nk),lux_kap(lK)
{
    kalkis_yeri=kalkis;
    varis_yeri=varis;
    zaman=Zm;
   sonraki=NULL;
}
int Ucus::ucusNoOku()
{
    return ucus_no;
}
string Ucus::zamanOku()
{
    return zaman;
}
int Ucus::luxkapOku()const
{
    return lux_kap;
}
int Ucus::norkapOku()const
{
    return nor_kap;
}

Ucus * Ucus::sonrakiOku(){

return sonraki;

}
void Ucus::sonrakiAyarla(Ucus *arg_sonraki)
{
    sonraki=arg_sonraki;
}
//Private uyelere erisim için gerekli okuma fonksiyonlar
string Ucus::kalYeriOku()
{
    return kalkis_yeri;
}
string Ucus::varYeriOku()
{
    return varis_yeri;
}
void Ucus::ucusNoSet(int n)
{
    ucus_no=n;
}
void Ucus::zamanSet(string z)
{
    strcpy(zaman,z);
}
void Ucus::norSet(int nor)
{
    nor_kap=nor;
}

void Ucus::kalYeriAyarla(string KY)
{
    kalkis_yeri=KY;
}
void Ucus::varYeriAyarla(string VY)
{
    varis_yeri=VY;
}
ostream &operator<<(ostream &output,const Ucus &airlines)
{
    output<<airlines.ucusNoOku()<<airlines.kalYeriOku()<<""<<airlines.varYeriOku()<<""<<airlines.zamanOku()<<""<<airlines.luxkapOku()<<""<<airlines.norkapOku()<<endl;
    return output;
}
ostream &operator>>(ostream &input,Ucus &airlines)
{
    input.ignore();

}
