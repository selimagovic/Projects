#ifndef YAZDIR_H_INCLUDED
#define YAZDIR_H_INCLUDED
#include <iostream>
#include <iomanip>
using namespace std;

#include "ucus.h"
#include "name.h"

class Yazdir
{
private:
    Ucus* ilk;
public:
    Yazdir();
    void ekle(Ucus *);
    void yerdenListemesi(Ucus *);
    void yereListemese(Ucus *);

    Ucus *AdaAra(char);
    Ucus *arama(int);
    Ucus *cikar(int);

    bool bos_mu();
    void listele();
};



#endif // YAZDIR_H_INCLUDED
