#ifndef UCUS_H_INCLUDED
#define UCUS_H_INCLUDED
#include <cstring>
#include "name.h"

class Ucus
{
    friend ostream &operator<<(ostream &,const Ucus &);
    friend ostream &operator>>(ostream &,Ucus &);

private:
    const int ucus_no;
    string kalkis_yeri;
    string varis_yeri;
    string zaman;
    const int lux_kap;
    const int nor_kap;


    Ucus *sonraki;

public:
    Ucus(int,string ,string ,string ,int,int);
    int ucusNoOku();
    string zamanOku();
    string  kalYeriOku();
    string  varYeriOku();
    int luxkapOku()const;
    int norkapOku()const;

    void ucusNoSet(int);
    void zamanSet(string);
    void luxSet(int);
    void norSet(int);
    Ucus *sonrakiOku();
    void kalYeriAyarla(string );
    void varYeriAyarla(char );
    void sonrakiAyarla(Ucus *);
    //void yazdir();

};


#endif // UCUS_H_INCLUDED
