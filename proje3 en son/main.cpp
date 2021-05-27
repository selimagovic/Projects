#include <iostream>
#include <iomanip>
#include <cstring>

using namespace std;
using std::cin;

#include "ucus.h"
#include "yazdir.h"

int menuSec(void);

int main()
{
    int ucusNo=0,luxkap=0,norkap=0,secim;
    string k_yeri[21];
    string v_yeri[21];
    string zaman[5];


    Ucus *airlines;
    Yazdir yaz;


    do
    {
        secim=menuSec();
        switch(secim)
        {
        case 1:
            cout <<"Ucus numarasi giriniz."<<endl<<"\n---> ";
            cin >> ucusNo;
            if (ucusNo==airlines->ucusNoOku())
                cout <<"Bu ucus zaten var."<<endl;
            else
            {
                cout <<"Kalkis yeri giriniz."<<endl<<"\n---> ";
                cin >> k_yeri;
                cout <<"Varis yeri giriniz."<<endl<<"\n---> ";
                cin >> v_yeri;
                cout << "Ucusun zamani giriniz."<<endl<<"\n---> ";
                cin >> zaman;
                cout << "Normal koltuk sayisi giriniz."<<endl<<"\n---> ";
                cin  >> norkap;


                airlines = new Ucus(ucusNo,k_yeri,v_yeri,zaman,0,norkap);

                yaz.ekle(airlines);
            }
            break;
        case 2:
            cout <<"Ucus numarasi giriniz."<<endl<<"\n--->";
            cin >> ucusNo;
            if (ucusNo==airlines->ucusNoOku())
                cout <<"Bu ucus zaten var."<<endl;
            else
            {
                cout <<"Kalkis yeri giriniz."<<endl<<"\n---> ";
                cin >> k_yeri;
                cout <<"Varis yeri giriniz."<<endl<<"\n---> ";
                cin >> v_yeri;
                cout << "Ucusun zamani giriniz."<<endl<<"\n---> ";
                cin >> zaman;
                cout << "Luks koltuk sayisi giriniz."<<endl<<"\n---> ";
                cin  >> luxkap;
                airlines = new Ucus(ucusNo,k_yeri,v_yeri,zaman,luxkap,norkap);
                yaz.ekle(airlines);
            }
            break;
        case 3:
            cout<<"Ucus numarasi giriniz."<<endl<<"\n---> ";
            cin>>ucusNo;

            airlines=yaz.arama(ucusNo);

            if(airlines==NULL)
            {
                cout<<"Bu ucus numara yok."<<endl;
            }
            else
            {
                cout<<"Luks Kapasite giriniz."<<endl<<"\n---> ";
                cin>>luxkap;

                //airlines=yaz.ekle(luxkap);
            }
            break;
        case 4:
            cout <<"Ucus numarasi giriniz."<<endl<<"\n---> ";
            cin >> ucusNo;
            airlines=yaz.arama(ucusNo);

            if(airlines==NULL)
            {
                cout<<"Bu ucus numara yok."<<endl;
            }
            else
            {
                delete airlines;
            }
            break;
        case 5:
            cout<<"Ucus numarasi giriniz."<<endl<<"\n---> ";
            cin>>ucusNo;
            airlines=yaz.arama(ucusNo);
            if(airlines==NULL)
            {
                cout<<"Bu ucus numara yok."<<endl;
            }
            else
            {

                cout<<"Ucus no  Kalkis yeri  Varis yeri  Zaman  Lux kap  Normal kap"<<endl;
                cout<<"____________________________________________________________"<<endl;
                cout <<airlines->ucusNoOku()<<"\t\t"<<airlines->kalYeriOku()<<"\t   "<<airlines->varYeriOku()<<"\t  " <<airlines->zamanOku()<<"\t\t" <<airlines->luxkapOku()<<"\t " <<airlines->norkapOku()<<endl;
                cout<<"____________________________________________________________"<<endl;
            }
            break;
        case 6:
        cout<<"Gormek istediginiz Luks koltuk iceren ucus numarasi giriniz."<<endl<<"\n--->";
            cin>>ucusNo;
            if(yaz.bos_mu())
            {
                cout<<"Luks koltuk iceren ucus yok."<<endl;
            }
            else{
            cout<<"Ucus no  Kalkis yeri  Varis yeri  Zaman  Lux kap  Normal kap"<<endl;
            cout<<"____________________________________________________________"<<endl;
            cout <<airlines->ucusNoOku()<<"\t\t"<<airlines->kalYeriOku()<<"\t   "<<airlines->varYeriOku()<<"\t  " <<airlines->zamanOku()<<"\t\t" <<airlines->luxkapOku()<<"\t " <<airlines->norkapOku()<<endl;
            }

            break;
        case 7:
            cout << "Bir yere olan ucus giriniz."<<endl<<"\n--->";
            cin >> v_yeri;
            yaz.AdaAra(v_yeri);

            if(yaz.AdaAra(v_yeri)==NULL)
            {
                cout<<"Bu ada gore ucus yok."<<endl;
            }
            else
            {
                cout<<"Ucus no  Kalkis yeri  Varis yeri  Zaman  Lux kap  Normal kap"<<endl;
                cout<<"____________________________________________________________"<<endl;
                cout <<airlines->ucusNoOku()<<"\t\t"<<airlines->kalYeriOku()<<"\t   "<<airlines->varYeriOku()<<"\t  " <<airlines->zamanOku()<<"\t\t" <<airlines->luxkapOku()<<"\t " <<airlines->norkapOku()<<endl;
            }

          break;
        case 8:
        cout<<"Kalkis yeri giriniz."<<endl<<"---> ";
            cin>>k_yeri;
            if(yaz.bos_mu())
                cout<<"Bu ucus yok!"<<endl;
            else
            {
                cout<<"Ucus no  Kalkis yeri  Varis yeri  Zaman  Lux kap  Normal kap "<<endl;
                cout<<"____________________________________________________________"<<endl;
                cout <<airlines->ucusNoOku()<<"\t\t"<<airlines->kalYeriOku()<<"\t   "<<airlines->varYeriOku()<<"\t  " <<airlines->zamanOku()<<"\t\t" <<airlines->luxkapOku()<<"\t " <<airlines->norkapOku()<<"\t  " <<endl;
            }

            break;
        case 9:
            break;
        }
    }
    while(secim!=10);

    return 0;
}

int menuSec(void)
{
    int secim;
    do
    {
        cout << endl;
        cout << "********************MENU************************************" << endl;
        cout << "1. Yeni ucusun eklemesi, normal koltuk."<<endl;
        cout << "2. Yeni ucusun eklemesi, luks koltuk."<<endl;
        cout << "3. Bir ucusun luks koltuk sayisinin guncellenmesi."<<endl;
        cout << "4. Bir ucusun iptal edilmesi."<<endl;
        cout << "5. Bir ucusun bilgilerinin goruntulenmesi."<<endl;
        cout << "6. Luks koltuk iceren ucuslarin listelenmesi."<<endl;
        cout << "7. Bir yere olan ucuslarin listelenmesi."<<endl;
        cout << "8. Bir yerden kalkan ucuslarin listelenmesi."<<endl;
        cout << "9. Bir yerden bir yere olan ucuslarin listelenmesi."<<endl;
        cout << "10. Programdan cikiniz."<<endl;



        cout << "Seciminizi giriniz."<<endl<<"\n---> "<<endl;
        cin>> secim;
    }
    while(secim<1 || secim>10);

    return secim;
}
