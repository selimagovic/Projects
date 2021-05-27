#ifndef NAME_H_INCLUDED
#define NAME_H_INCLUDED
#include <cstring>

class Name
{
    friend ostream &operator<<(ostream &,const Name &);
    private:
        char kalkis_yeri[21];
        char varis_yeri[21];
        Name *sonraki;
    public:
        Name (char [], char []);
        void kopyala(char [],char []);
        char  *kalYeriOku();
        char  *varYeriOku();
        Name *sonrakiOku();
        void kalYeriAyarla(char );
        void varYeriAyarla(char );
        void yaz();
};

#endif // NAME_H_INCLUDED
