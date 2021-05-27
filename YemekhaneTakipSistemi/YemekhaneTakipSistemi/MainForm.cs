using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YemekhaneTakipSistemi
{


    public partial class MainForm : Form
    {
        DateTime date = DateTime.Now.ToLocalTime();
        //private int id = 0;
        public char radio_ID,_dil;
        private decimal _kimlik;
        private DateTime _date;
        public MainForm()
        {
            InitializeComponent();
        }
        public void getDil(char dil)
        {
            _dil = dil;
        }
        //Veritabanı ile kod arasında baglantı 
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                      AttachDbFilename=C:\Users\Selim\Documents\YemekhaneData.mdf;
                                                   Integrated Security=True;Connect Timeout=30");
        int yemek;
        double bakiye = 0.0f;
        public void setId(char _ID)
        {
            radio_ID = _ID;
        }
        public void setKimlik(decimal kimlik)
        {
            _kimlik = kimlik;
        }
        public void setDate(DateTime date)
        {
            _date = date;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DiliDegistir();
            tarihinden.MinDate = DateTime.Now;
            tarihine.MinDate = DateTime.Now;
            if (radio_ID == 'O')
            {

                connection.Open();
                SqlCommand cmdsay = new SqlCommand(@"SELECT COUNT (YemekID) FROM YEMEK ", connection);
                SqlCommand b = new SqlCommand(@"SELECT Bakiye FROM BAKIYE ", connection);
                var bak = b.ExecuteScalar();
                bakiye = Convert.ToDouble(bak);
                var a = cmdsay.ExecuteScalar();
                connection.Close();
                yemek = Convert.ToInt32(a);
            }
            else
            {
                connection.Open();
                SqlCommand cmdsay = new SqlCommand(@"SELECT COUNT (YemekID) FROM YEMEK ", connection);
                SqlCommand b = new SqlCommand(@"SELECT Bakiye FROM BAKIYE ", connection);
                var bak = b.ExecuteScalar();
                bakiye = Convert.ToDouble(bak);
                var a = cmdsay.ExecuteScalar();
                connection.Close();
                yemek = Convert.ToInt32(a);

            }
            kullaniciGroupBox.Visible = false;
        }



        #region Buttons (EXIT,EKLE,IPTAL,Kullanici Hakkinda,Program Hakkinda)

        private void cikisButton_Click(object sender, EventArgs e)
        {
            string mesaj=null, mesaj1=null;
            if (_dil == 'T')
            {
                mesaj = "Cikmak Istediginizden Emin misiniz?";
                mesaj1 = "Emin Misiniz?";
            }
            else
            {
                mesaj = "That you want to exit?";
                mesaj1 = "Are you sure?";
            }

            if (MessageBox.Show(mesaj,mesaj1 , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (radio_ID == 'O')
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE OGRENCILER SET SonGiris='" + _date.ToShortDateString() + "', SonSaat='"
                             + _date.ToShortTimeString() + "'WHERE OgrenciKartID='" + _kimlik + "'", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE PERSONEL SET SonGiris='" + _date.ToShortDateString() + "', SonSaat='"
                                + _date.ToShortTimeString() + "'WHERE PersonelKartID='" + _kimlik + "'", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();

                }
                this.Dispose();
            }
        }
        private void kullaniciHakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullaniciGroupBox.Visible = true;                     
            
            if(radio_ID == 'O')
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                var commandText = "SELECT Ad FROM OGRENCILER WHERE OgrenciKartID=@id";
                using (var cmd = new SqlCommand(commandText,connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = _kimlik;
                    var adId = cmd.ExecuteScalar().ToString();
                    adLabel.Text = adId;
                    connection.Close();
                }                
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                var commandText1 = "SELECT Soyad FROM OGRENCILER WHERE OgrenciKartID=@id";
                using (var cmd = new SqlCommand(commandText1, connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = _kimlik;
                    var soyId = cmd.ExecuteScalar().ToString();
                    soyadLabel.Text = soyId;
                    connection.Close();
                }
                DateTime kontroldate;
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                var zaman = "SELECT SonGiris FROM OGRENCILER WHERE OgrenciKartID=@id ";
                using (var cmd = new SqlCommand(zaman, connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = _kimlik;
                    var tarih = cmd.ExecuteScalar().ToString();
                    kontroldate = Convert.ToDateTime(tarih);
                    girisLabel.Text = kontroldate.ToShortDateString();
                }
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                var saat = "SELECT SonSaat FROM OGRENCILER WHERE OgrenciKartID=@id ";
                using (var cmd = new SqlCommand(saat, connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = _kimlik;
                    var tarih = String.Format("{0: dd/MM/yyyy}", cmd.ExecuteScalar().ToString());
                    sonSaatLabel.Text = tarih;
                }
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                var bakiyeText = "SELECT Bakiye FROM BAKIYE WHERE OgrenciKartID=@id";
                using (var cmd = new SqlCommand(bakiyeText, connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = _kimlik;
                    var adId = cmd.ExecuteScalar().ToString();
                    mevBakiyeLabel.Text = adId + "TL";
                    connection.Close();
                }

            }
            else 
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                var commandText = "SELECT Ad FROM PERSONEL WHERE PersonelKartID=@id";
                using (var cmd = new SqlCommand(commandText, connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = _kimlik;
                    var adId = cmd.ExecuteScalar().ToString();
                    adLabel.Text = adId;
                    connection.Close();
                }
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                var commandText1 = "SELECT Soyad FROM PERSONEL WHERE PersonelKartID=@id";
                using (var cmd = new SqlCommand(commandText1, connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = _kimlik;
                    var soyId = cmd.ExecuteScalar().ToString();
                    soyadLabel.Text = soyId;
                    connection.Close();
                }
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                var zaman = "SELECT SonGiris FROM PERSONEL WHERE PersonelKartID=@id ";
                using (var cmd = new SqlCommand(zaman, connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = _kimlik;
                    var tarih = cmd.ExecuteScalar().ToString();
                    girisLabel.Text = tarih;
                }
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                var saat = "SELECT SonSaat FROM PERSONEL WHERE PersonelKartID=@id ";
                using (var cmd = new SqlCommand(saat, connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = _kimlik;
                    var tarih = cmd.ExecuteScalar().ToString();
                    sonSaatLabel.Text = tarih;
                }
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                var bakiyeText = "SELECT Bakiye FROM BAKIYE WHERE PersonelKartID=@id";
                using (var cmd = new SqlCommand(bakiyeText, connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = _kimlik;
                    var adId = cmd.ExecuteScalar().ToString();
                    mevBakiyeLabel.Text = adId + " TL";
                    connection.Close();
                }

            }
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            if (kahvCheckBox.Checked == false && ogleCheckBox.Checked == false && aksamCheckBox.Checked == false)
            {
                if (_dil == 'T')
                    MessageBox.Show("Bir secim yapmaniz gerekmektedir...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Please make a choice...", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                DateTime dtarihinden = Convert.ToDateTime(tarihinden.Text);
                DateTime dtarihine = Convert.ToDateTime(tarihine.Text);
                int tden = Convert.ToInt32(dtarihinden.Day);
                int tye = Convert.ToInt32(dtarihine.Day);
                int fark = 0;
                fark = tye - tden;
                string kKontrol, oKontrol, aKontrol;
                string kOku = "select Kahvalti FROM YEMEK WHERE Tarih=@t and PersonelKartID=@pID and OgrenciKartID=@oID";
                string aOku = "select AksamYemegi FROM YEMEK WHERE Tarih=@t and PersonelKartID=@pID and OgrenciKartID=@oID";
                string oOku = "select OgleYemegi FROM YEMEK WHERE Tarih=@t and PersonelKartID=@pID and OgrenciKartID=@oID";

                string kahvalti = kahvCheckBox.Checked ? "Alindi" : "Alinmadi";
                string ogleYemegi = ogleCheckBox.Checked ? "Alindi" : "Alinmadi";
                string aksamYemegi = aksamCheckBox.Checked ? "Alindi" : "Alinmadi";

                if (fark < 0)
                {
                    if (_dil == 'T')
                        MessageBox.Show("Girdiginiz Tarih Araligini Kontrol Ediniz!");
                    else
                        MessageBox.Show("Please Check the date range  that you entered !");
                }
                else
                    for (int i = 0; i <= fark; i++)
                    {


                        //using kismi daha once yemek alinip alinmadigini kontrol eder
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();
                        using (var cmd1 = new SqlCommand(kOku, connection))
                        {

                            cmd1.Parameters.AddWithValue("@t", dtarihinden.AddDays(i).ToShortDateString());
                            if (radio_ID == 'P')
                            {
                                cmd1.Parameters.Add("@pID", SqlDbType.Decimal).Value = _kimlik;
                                cmd1.Parameters.Add("@oID", SqlDbType.Decimal).Value = 0;

                                var k = cmd1.ExecuteScalar();
                                kKontrol = Convert.ToString(k);

                                cmd1.CommandText = oOku;
                                var o = cmd1.ExecuteScalar();
                                oKontrol = Convert.ToString(o);

                                cmd1.CommandText = aOku;
                                var a = cmd1.ExecuteScalar();
                                aKontrol = Convert.ToString(a);
                                connection.Close();

                            }
                            else
                            {
                                cmd1.Parameters.Add("@oID", SqlDbType.Decimal).Value = _kimlik;
                                cmd1.Parameters.Add("@pID", SqlDbType.Decimal).Value = 0;
                                var k = cmd1.ExecuteScalar();
                                kKontrol = Convert.ToString(k);
                                cmd1.CommandText = oOku;
                                var o = cmd1.ExecuteScalar();
                                oKontrol = Convert.ToString(o);

                                cmd1.CommandText = aOku;
                                var a = cmd1.ExecuteScalar();
                                aKontrol = Convert.ToString(a);
                                connection.Close();
                            }
                        }
                        if (kKontrol == "" && oKontrol == "" && aKontrol == "")
                        {
                            YemekEkle(dtarihinden.AddDays(i), kahvalti, ogleYemegi, aksamYemegi);
                        }
                        else
                        { 
                            if (kKontrol != "Alinmadi" && kKontrol != "")
                            {
                                if (oKontrol != "Alinmadi" && oKontrol != "")
                                {
                                    if (aKontrol != "Alinmadi" && aKontrol != "")
                                    {
                                        if (kahvCheckBox.Checked == true/* && ogleCheckBox.Checked == true
                                        && aksamCheckBox.Checked == true*/)
                                        {
                                            if (_dil == 'T')
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " Tarihinde Kahvalti kaydi bulunmaktadir");
                                            else
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " On this date you have Breakfast");
                                        }
                                        if (ogleCheckBox.Checked == true)
                                        {
                                            if (_dil == 'T')
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " Tarihinde Ogle Yemegi kaydi bulunmaktadir");
                                            else
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " On this date you have Lunch");
                                        }
                                        if (aksamCheckBox.Checked == true)
                                        {
                                            if (_dil == 'T')
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " Tarihinde Aksam Yemegi kaydi bulunmaktadir");
                                            else
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " On this date you have Dinner");
                                        }
                                    }
                                    else
                                    {
                                        if (kahvCheckBox.Checked == true /*&& ogleCheckBox.Checked == true*/)
                                        {
                                            if (_dil == 'T')
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " Tarihinde Kahvalti  kaydi bulunmaktadir");
                                            else
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + "On this date you already have Breakfast ");
                                        }
                                        if (ogleCheckBox.Checked == true)
                                        {
                                            if (_dil == 'T')
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " Tarihinde Ogle Yemegi kaydi bulunmaktadir");
                                            else
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " On this date you have Lunch");
                                        }
                                        if (aksamCheckBox.Checked == true)
                                        {
                                            aKontrol = "Alindi";
                                            YemekGuncelleme(dtarihinden.AddDays(i), kKontrol, oKontrol, aKontrol);
                                        }

                                    }/*end aksam alindi == false*/
                                }
                                else
                                {
                                    if (aKontrol != "Alinmadi" && aKontrol != "")
                                    {
                                        if (kahvCheckBox.Checked == true /*&& aksamCheckBox.Checked == true*/)
                                        {
                                            if (_dil == 'T')
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " Tarihinde Kahvalti kaydi bulunmaktadir");
                                            else
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " On this date you have Breakfast");
                                        }
                                        if (ogleCheckBox.Checked == true)
                                        {
                                            oKontrol = "Alindi";
                                            YemekGuncelleme(dtarihinden.AddDays(i), kKontrol, oKontrol, aKontrol);
                                        }
                                        if (aksamCheckBox.Checked == true)
                                        {
                                            if (_dil == 'T')
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " Tarihinde Aksam Yemegi kaydi bulunmaktadir");
                                            else
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " On this date you have Dinner");
                                        }
                                    }
                                    else
                                    {
                                        if (kahvCheckBox.Checked == true)
                                        {
                                            if (_dil == 'T')
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " Tarihinde Kahvalti kaydi bulunmaktadir");
                                            else
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + "On this date you already have Breakfast");
                                        }
                                        if (ogleCheckBox.Checked == true)
                                        {
                                            oKontrol = "Alindi";
                                            YemekGuncelleme(dtarihinden.AddDays(i), kKontrol, oKontrol, aKontrol);
                                        }
                                        if (aksamCheckBox.Checked == true)
                                        {
                                            aKontrol = "Alindi";
                                            YemekGuncelleme(dtarihinden.AddDays(i), kKontrol, oKontrol, aKontrol);
                                        }
                                    }/*end aksam alindi == false*/
                                }

                            }
                            else
                            {
                                if (oKontrol != "Alinmadi" && oKontrol != "")
                                {
                                    if (aKontrol != "Alinmadi" && aKontrol != "")
                                    {
                                        if (ogleCheckBox.Checked == true)
                                        {
                                            if (_dil == 'T')
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " Tarihinde Ogle Yemegi kaydi bulunmaktadir");
                                            else
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " On this date you have Lunch");
                                        }
                                        if (kahvCheckBox.Checked == true)
                                        {
                                            kKontrol = "Alindi";
                                            YemekGuncelleme(dtarihinden.AddDays(i), kKontrol, oKontrol, aKontrol);
                                        }
                                        if (aksamCheckBox.Checked == true)
                                        {
                                            if (_dil == 'T')
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " Tarihinde Aksam Yemegi kaydi bulunmaktadir");
                                            else
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " On this date you have Dinner");
                                        }
                                    }
                                    else
                                    {
                                        if (ogleCheckBox.Checked == true)
                                        {
                                            if (_dil == 'T')
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " Tarihinde Ogle Yemegi kaydi bulunmaktadir");
                                            else
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + "On this date you already have Lunch");
                                        }
                                        else
                                        {
                                            if (kahvCheckBox.Checked == true)
                                            {
                                                kKontrol = "Alindi";
                                                YemekGuncelleme(dtarihinden.AddDays(i), kKontrol, oKontrol, aKontrol);
                                            }
                                            if (aksamCheckBox.Checked == true)
                                            {
                                                aKontrol = "Alindi";
                                                YemekGuncelleme(dtarihinden.AddDays(i), kKontrol, oKontrol, aKontrol);
                                            }
                                        }
                                    }/*end aksam alindi == false*/
                                }
                                else
                                {
                                    if (aKontrol != "Alinmadi")
                                    {
                                        if (aksamCheckBox.Checked == true)
                                        {
                                            if (_dil == 'T')
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " Tarihinde Aksam Yemegi kaydi bulunmaktadir");
                                            else
                                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString() + " On this date you have Dinner");

                                        }
                                        else
                                        {
                                            if (kahvCheckBox.Checked == true)
                                            {
                                                kKontrol = "Alindi";
                                                YemekGuncelleme(dtarihinden.AddDays(i), kKontrol, oKontrol, aKontrol);
                                            }
                                            if (ogleCheckBox.Checked == true)
                                            {
                                                oKontrol = "Alindi";
                                                YemekGuncelleme(dtarihinden.AddDays(i), kKontrol, oKontrol, aKontrol);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        YemekSil(dtarihinden.AddDays(i));
                                        YemekEkle(dtarihinden.AddDays(i), kahvalti, ogleYemegi, aksamYemegi);
                                    }
                                }                                
                            }
                        }                       
                }/*end for*/
            }
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            if (kahvaltiIptalCB.Checked == false && ogleIptalCB.Checked == false && aksamIptalCB.Checked == false)
            {
                MessageBox.Show("\tBir secim yapmaniz gerekmektedir...   ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime dt = DateTime.Now.ToLocalTime();
                DateTime dtarihinden = Convert.ToDateTime(iptalTarihinden.Text);
                DateTime dtarihine = Convert.ToDateTime(iptalTarihine.Text);
                int tden = Convert.ToInt32(dtarihinden.Day);
                int tye = Convert.ToInt32(dtarihine.Day);
                int fark = tye - tden;
                double miktar = 0.0f;
                string kKontrol, oKontrol, aKontrol;

                string myBakiye = "select Bakiye from BAKIYE where PersonelKartID=@pID and OgrenciKartID=@oID";
                string k = "select Kahvalti from YEMEK Where Tarih=@t and PersonelKartID=@pID and OgrenciKartID=@oID";
                string o = "select OgleYemegi from YEMEK Where Tarih=@t and PersonelKartID=@pID and OgrenciKartID=@oID";
                string a = "select AksamYemegi from YEMEK Where Tarih=@t and PersonelKartID=@pID and OgrenciKartID=@oID";

                if (kahvaltiIptalCB.Checked == true)
                {
                    for (int i = 0; i <= fark; i++)
                    {
                        kKontrol = DatabasetenOku(k, dtarihinden.AddDays(i));
                        if(kKontrol == "")
                        {
                            if (_dil == 'T')
                                MessageBox.Show("Bu "+_kimlik+" kart numarasi icin Kahvalti bulunamadi");
                            else
                                MessageBox.Show("For this " + _kimlik + " card number there is no Breakfast");
                            break;
                        }
                        else if (kKontrol == "Alinmadi")
                        {
                            MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString()
                                + " tarihinde Kahvalti kaydi bulunmamaktadir.");
                            break;
                        }
                        else
                        {
                            kKontrol = "Alinmadi";
                            oKontrol = DatabasetenOku(o, dtarihinden.AddDays(i));
                            aKontrol = DatabasetenOku(a, dtarihinden.AddDays(i));

                            Guncelleme(kKontrol, oKontrol, aKontrol, dtarihinden.AddDays(i));
                            bakiye = bakiyeOku(myBakiye);
                            miktar = 2.25f;
                            bakiye += miktar;
                            BakiyeGuncelleme(myBakiye, bakiye, dtarihinden.AddDays(i), miktar);

                            if (_dil == 'T')
                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString()
                                    + " icin Silme Islemi Gerceklestirildi!!!");
                            else
                                MessageBox.Show("Deleting is successful for"
                                    + dtarihinden.AddDays(i).ToShortDateString());
                        }
                        
                    }
                }

                if (ogleIptalCB.Checked == true)
                {
                    for (int i = 0; i <= fark; i++)
                    {
                        oKontrol = DatabasetenOku(o, dtarihinden.AddDays(i));
                        if (oKontrol == "")
                        {
                            if (_dil == 'T')
                                MessageBox.Show("Bu " + _kimlik + " kart numarasi icin Ogle Yemegi bulunamadi");
                            else
                                MessageBox.Show("For this " + _kimlik + " card number there is no Lunch");
                            break;
                        }
                        else if (oKontrol == "Alinmadi")
                        {
                            MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString()
                                + "  tarihinde Ogle yemegi kaydi bulunmamaktadir.");
                            break;
                        }
                        else {
                            oKontrol = "Alinmadi";
                            kKontrol = DatabasetenOku(k, dtarihinden.AddDays(i));
                            aKontrol = DatabasetenOku(a, dtarihinden.AddDays(i));
                            Guncelleme(kKontrol, oKontrol, aKontrol, dtarihinden.AddDays(i));
                            bakiye = bakiyeOku(myBakiye);
                            miktar = 3.25f;
                            bakiye += miktar;
                            BakiyeGuncelleme(myBakiye, bakiye, dtarihinden.AddDays(i), miktar);
                            if (_dil == 'T')
                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString()
                                    + " icin Silme Islemi Gerceklestirildi!!!");
                            else
                                MessageBox.Show("Deleting is successful for"
                                    + dtarihinden.AddDays(i).ToShortDateString());
                        }
                    }
                }
                if (aksamIptalCB.Checked == true)
                {
                    for (int i = 0; i <= fark; i++)
                    {
                        aKontrol = DatabasetenOku(a, dtarihinden.AddDays(i));
                        if (aKontrol == "")
                        {
                            if (_dil == 'T')
                                MessageBox.Show("Bu " + _kimlik + " kart numarasi icin Aksam Yemegi bulunamadi");
                            else
                                MessageBox.Show("For this " + _kimlik + " card number there is no Dinner");
                            break;
                        }
                        if (aKontrol == "Alinmadi")
                        {
                            MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString()
                                + " tarihinde Aksam Yemegi kaydi bulunmamaktadir.");
                            break;
                        }
                        else
                        {
                            aKontrol = "Alinmadi";
                            oKontrol = DatabasetenOku(o, dtarihinden.AddDays(i));
                            kKontrol = DatabasetenOku(k, dtarihinden.AddDays(i));
                            Guncelleme(kKontrol, oKontrol, aKontrol, dtarihinden.AddDays(i));
                            bakiye = bakiyeOku(myBakiye);
                            miktar = 3.50f;
                            bakiye += miktar;
                            BakiyeGuncelleme(myBakiye, bakiye, dtarihinden.AddDays(i), miktar);

                            if (_dil == 'T')
                                MessageBox.Show(dtarihinden.AddDays(i).ToShortDateString()
                                    + "icin Silme Islemi Gerceklestirildi!!!");
                            else
                                MessageBox.Show("Deleting is successful for"
                                    + dtarihinden.AddDays(i).ToShortDateString());
                        }
                    }
                }

            }
        }

        private void gosterButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string kayit = "SELECT * FROM YEMEK WHERE PersonelKartID=@id and OgrenciKartID=@oID ";
            SqlCommand cmd = new SqlCommand(kayit, connection);
            if (radio_ID == 'P')
            {
                cmd.Parameters.AddWithValue("@id", _kimlik);
                cmd.Parameters.AddWithValue("@oID", 0);
            }
            else
            {
                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@oID", _kimlik);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            da.Fill(dtable);
            dataGridView1.DataSource = dtable;
            connection.Close();
        }

        private void hakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ProgramHakkinda ph = new ProgramHakkinda();
            ph.getDil(_dil);
            ph.ShowDialog();

        }

        #endregion

        #region Yemek Sil, Yemek Ekle, Yemek Guncelleme, Bakiye Guncelleme
        private void YemekSil(DateTime tarih)
        {
            string my_select = "DELETE FROM YEMEK WHERE PersonelKartID=@pID and OgrenciKartID=@oID and Tarih=@t";
            if (connection.State == ConnectionState.Closed)
                connection.Open();
                using (var cmd = new SqlCommand(my_select, connection))
                {
                    cmd.Parameters.AddWithValue("@t", tarih);
                    if (radio_ID == 'P')

                    {
                        cmd.Parameters.Add("@pID", SqlDbType.Decimal).Value = _kimlik;
                        cmd.Parameters.Add("@oID", SqlDbType.Decimal).Value = 0;
                    }
                    else
                    {
                        cmd.Parameters.Add("@oID", SqlDbType.Decimal).Value = _kimlik;
                        cmd.Parameters.Add("@pID", SqlDbType.Decimal).Value = 0;
                    }

                cmd.ExecuteNonQuery();
                connection.Close();
                }            
        }
        private void YemekEkle (DateTime dtarihinden,string kahvalti,string ogleYemegi, string aksamYemegi)
        {
            DateTime dt = DateTime.Now.ToLocalTime();
            double miktar = 0.0f;
            double x = 0.0f;
            if (radio_ID == 'P')
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                var bakiyeText = "SELECT Bakiye FROM BAKIYE WHERE PersonelKartID=@id";
                using (var cmd = new SqlCommand(bakiyeText, connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = _kimlik;
                    var b = cmd.ExecuteScalar().ToString();/////////////////
                    connection.Close();
                    miktar = Convert.ToDouble(b);
                }

                double kmiktar = 0.0f, omiktar = 0.0f, amiktar = 0.0f;
                    kmiktar = kahvCheckBox.Checked ? kmiktar += 2.25f : kmiktar;
                    omiktar = ogleCheckBox.Checked ? omiktar += 3.25f : omiktar;
                    amiktar = aksamCheckBox.Checked ? amiktar += 3.50f : amiktar;
                x = miktar - (kmiktar + omiktar + amiktar);
            }
            else
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    var bakiyeText = "SELECT Bakiye FROM BAKIYE WHERE OgrenciKartID=@id";
                    using (var cmd = new SqlCommand(bakiyeText, connection))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = _kimlik;
                        var bak = cmd.ExecuteScalar().ToString();
                        connection.Close();
                        miktar = Convert.ToDouble(bak);
                    }

                    double kmiktar = 0.0f, omiktar = 0.0f, amiktar = 0.0f;
                        kmiktar = kahvCheckBox.Checked ? kmiktar += 2.25f : kmiktar;
                        omiktar = ogleCheckBox.Checked ? omiktar += 3.25f : omiktar;
                        amiktar = aksamCheckBox.Checked ? amiktar += 3.50f : amiktar;
                    x = miktar - (kmiktar + omiktar + amiktar);

                }
                catch (Exception)
                {
                    if (_dil == 'T')
                        MessageBox.Show("Bakiyeniz yetersiz");
                    else
                        MessageBox.Show("Not Enough Balance ");
                }
            }

            if (x < 0)
            {
                if (_dil == 'T')
                    MessageBox.Show("Bakiyeniz yetersiz !!!", "UYARI!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Not Enough Balance !!!", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                        yemek++;
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO YEMEK (Kahvalti,OgleYemegi,
                                           AksamYemegi,Tarih,Saat,PersonelKartID,OgrenciKartID,YemekID) 
                                           VALUES (@k,@o,@a,@t,@s,@pID,@oID,@yID)", connection);

                        cmd.Parameters.AddWithValue("@k", kahvalti);
                        cmd.Parameters.AddWithValue("@o", ogleYemegi);
                        cmd.Parameters.AddWithValue("@a", aksamYemegi);
                        cmd.Parameters.AddWithValue("@t", dtarihinden.ToShortDateString());
                        cmd.Parameters.AddWithValue("@s", dt.ToShortTimeString());
                        if (radio_ID == 'P')
                        {
                            cmd.Parameters.AddWithValue("@pID", _kimlik);
                            cmd.Parameters.AddWithValue("@oID", 0);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@oID", _kimlik);
                            cmd.Parameters.AddWithValue("@pID", 0);
                        }
                        cmd.Parameters.AddWithValue("@yID", yemek);
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    
                    if (radio_ID == 'P')
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();
                        SqlCommand cmd1 = new SqlCommand("UPDATE BAKIYE SET Bakiye='" + x +
                            "' WHERE PersonelKartID ='" + _kimlik + "'", connection);
                        cmd1.ExecuteNonQuery();
                        connection.Close();

                    }
                    else
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();
                        SqlCommand cmd1 = new SqlCommand("UPDATE BAKIYE SET Bakiye='" + x +
                            "' WHERE OgrenciKartID ='" + _kimlik + "'", connection);
                        cmd1.ExecuteNonQuery();
                        connection.Close();
                    }
                    mevBakiyeLabel.Text = x.ToString() + " TL";
                    MessageBox.Show("\r\tIslem Basrili  ");
            }/*end first else*/
        }
        private void YemekGuncelleme(DateTime dtarihinden, string kahvalti, string ogleYemegi, string aksamYemegi)
        {
            double miktar = 0.0f;
            double x = 0.0f;
            if (radio_ID == 'P')
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                var bakiyeText = "SELECT Bakiye FROM BAKIYE WHERE PersonelKartID=@id";
                using (var cmd = new SqlCommand(bakiyeText, connection))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = _kimlik;
                    var b = cmd.ExecuteScalar().ToString();/////////////////
                    connection.Close();
                    miktar = Convert.ToDouble(b);
                }

                double kmiktar = 0.0f, omiktar = 0.0f, amiktar = 0.0f;
                kmiktar = kahvCheckBox.Checked ? kmiktar += 2.25f : kmiktar;
                omiktar = ogleCheckBox.Checked ? omiktar += 3.25f : omiktar;
                amiktar = aksamCheckBox.Checked ? amiktar += 3.50f : amiktar;
                x = miktar - (kmiktar + omiktar + amiktar);
            }
            else
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    var bakiyeText = "SELECT Bakiye FROM BAKIYE WHERE OgrenciKartID=@id";
                    using (var cmd = new SqlCommand(bakiyeText, connection))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Decimal).Value = _kimlik;
                        var bak = cmd.ExecuteScalar().ToString();
                        connection.Close();
                        miktar = Convert.ToDouble(bak);
                    }

                    double kmiktar = 0.0f, omiktar = 0.0f, amiktar = 0.0f;
                    kmiktar = kahvCheckBox.Checked ? kmiktar += 2.25f : kmiktar;
                    omiktar = ogleCheckBox.Checked ? omiktar += 3.25f : omiktar;
                    amiktar = aksamCheckBox.Checked ? amiktar += 3.50f : amiktar;
                    x = miktar - (kmiktar + omiktar + amiktar);

                }
                catch (Exception)
                {
                    if (_dil == 'T')
                        MessageBox.Show("Bakiyeniz yetersiz");
                    else
                        MessageBox.Show("Not Enough Balance ");
                }
            }

            if (x < 0)
            {
                if (_dil == 'T')
                    MessageBox.Show("Bakiyeniz yetersiz !!!", "UYARI!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Not Enough Balance !!!", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                yemek++;
                SqlCommand cmd = new SqlCommand(@"UPDATE YEMEK 
                                           SET Kahvalti=@k,OgleYemegi=@o,AksamYemegi=@a WHERE Tarih=@t AND
                    PersonelKartID=@pID AND OgrenciKartID=@oID", connection);

                cmd.Parameters.AddWithValue("@k", kahvalti);
                cmd.Parameters.AddWithValue("@o", ogleYemegi);
                cmd.Parameters.AddWithValue("@a", aksamYemegi);
                cmd.Parameters.AddWithValue("@t", dtarihinden.ToShortDateString());
                if (radio_ID == 'P')
                {
                    cmd.Parameters.AddWithValue("@pID", _kimlik);
                    cmd.Parameters.AddWithValue("@oID", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@oID", _kimlik);
                    cmd.Parameters.AddWithValue("@pID", 0);
                }
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                if (radio_ID == 'P')
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    SqlCommand cmd1 = new SqlCommand("UPDATE BAKIYE SET Bakiye='" + x +
                        "' WHERE PersonelKartID ='" + _kimlik + "'", connection);
                    cmd1.ExecuteNonQuery();
                    connection.Close();

                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    SqlCommand cmd1 = new SqlCommand("UPDATE BAKIYE SET Bakiye='" + x +
                        "' WHERE OgrenciKartID ='" + _kimlik + "'", connection);
                    cmd1.ExecuteNonQuery();
                    connection.Close();
                }
                mevBakiyeLabel.Text = x.ToString() + " TL";
                MessageBox.Show("\r\tIslem Basrili  ");
            }/*end first else*/
        }

        private void BakiyeGuncelleme(string data, double bakiye, DateTime date, double miktar)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE BAKIYE SET  Tarih=@t,Saat=@s,Bakiye=@b 
                    WHERE PersonelKartID=@pID and OgrenciKartID=@oID", connection);

            cmd.Parameters.AddWithValue("@t", date.ToShortDateString());
            cmd.Parameters.AddWithValue("@s", date.ToShortTimeString());
            cmd.Parameters.AddWithValue("@b", bakiye);
            if (radio_ID == 'P')
            {
                cmd.Parameters.AddWithValue("@pID", _kimlik);
                cmd.Parameters.AddWithValue("@oID", 0);
            }
            else
            {
                cmd.Parameters.AddWithValue("@pID", 0);
                cmd.Parameters.AddWithValue("@oID", _kimlik);
            }
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show(miktar.ToString() + " TL   yuklendi.", "Islem Basarili !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mevBakiyeLabel.Text = bakiye.ToString() + "  TL";
        }
        #endregion

        private void Guncelleme(string kdata, string odata, string adata,DateTime date )
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE YEMEK SET Kahvalti=@k, OgleYemegi=@o
                                      , AksamYemegi=@a WHERE Tarih=@t and PersonelKartID=@pID and OgrenciKartID=@oID", connection);

            cmd.Parameters.AddWithValue("@k", kdata);
            cmd.Parameters.AddWithValue("@o", odata);
            cmd.Parameters.AddWithValue("@a", adata);
            cmd.Parameters.AddWithValue("@t", date.ToShortDateString());
            if (radio_ID == 'P')
            {
                cmd.Parameters.AddWithValue("@pID", _kimlik);
                cmd.Parameters.AddWithValue("@oID", 0);
            }
            else
            {
                cmd.Parameters.AddWithValue("@oID", _kimlik);
                cmd.Parameters.AddWithValue("@pID", 0);
            }
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        #region DatabastenOku, BakiyeOku
        private string DatabasetenOku(string data,DateTime tarih)
        {
            string ogunKontrolu;
            
            if (connection.State == ConnectionState.Closed)
               connection.Open();
            using (var cmd = new SqlCommand(data, connection))
            {
                cmd.Parameters.AddWithValue("@t", tarih.ToShortDateString());
                if (radio_ID == 'O')
                {
                    cmd.Parameters.AddWithValue("@oID", _kimlik);
                    cmd.Parameters.AddWithValue("@pID", 0);
                    var kontrol = cmd.ExecuteScalar();
                    ogunKontrolu = Convert.ToString(kontrol);
                    connection.Close();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@pID", _kimlik);
                    cmd.Parameters.AddWithValue("@oID", 0);
                    var kontrol = cmd.ExecuteScalar();
                    ogunKontrolu = Convert.ToString(kontrol);
                    connection.Close();
                }
            }
            return ogunKontrolu;
        }
       
        
        private double bakiyeOku(string data)
        {
            double mevcutBakiye;
            using (var cmd = new SqlCommand(data, connection))
            {
                if (radio_ID == 'P')
                {
                    cmd.Parameters.AddWithValue("@pID", _kimlik);
                    cmd.Parameters.AddWithValue("@oID", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@pID", 0);
                    cmd.Parameters.AddWithValue("@oID", _kimlik);
                }
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                var bak = cmd.ExecuteScalar().ToString();
                mevcutBakiye = Convert.ToDouble(bak);
                connection.Close();
            }
            return mevcutBakiye;
        }


        #endregion
        
        private void DiliDegistir()
        {
            if(_dil=='E')
            {
                this.Text = "Cafeteria Home Page";
                //mainform kismi dil cevirme
                yemekSipTab.Text = "Meal Order"; 
                yemekIptalTab.Text = "Cancel Meal"; kullaniciGroupBox.Text = "User Information";
                sonGirisLabel.Text = "[Last Login]";
                yemekTab.Text = "Meal Information"; bakiyeLabel.Text = "[Current Balance]";
                //ekle kismi dil cevirme
                yemekSipGroupBox.Text = "Chose the meal";
                kahvCheckBox.Text = "Breakfast - 2.25 TL";
                ogleCheckBox.Text = "Lunch - 3.25 TL";
                aksamCheckBox.Text = "Dinner - 3.50 TL";
                label1.Text = "From -"; label1.Location = new Point(39, 179);
                label2.Text = "To -"; label2.Location = new Point(55, 210);
                ekleButton.Text = "Add";
                //menu kismi dil cevirme
                hakkindaToolStripMenuItem.Text = "About Program";
                kullaniciHakkindaToolStripMenuItem.Text = "About User";
                //iptal kismi dil cevirme
                groupBox2.Text = "Cancel the Meal";
                kahvaltiIptalCB.Text = "Breakfast - 2.25 TL";
                ogleIptalCB.Text = "Lunch - 3.25 TL";
                aksamIptalCB.Text = "Dinner - 3.50 TL";
                label4.Text = "From -"; label4.Location = new Point(39, 179);
                label3.Text = "To -"; label3.Location = new Point(55, 210);
                iptalButton.Text = "Delete";
                gosterButton.Text = "S H O W";

            }
            else
            {
                this.Text = "Yemekhane Ana Sayfa";
                //mainform kismi dil cevirme
                yemekSipTab.Text = "Yemek Siparis";
                yemekIptalTab.Text = "Yemek Iptal"; kullaniciGroupBox.Text = "Kullanici Bilgileri";
                sonGirisLabel.Text = "[Son Giris]";
                yemekTab.Text = "Yemek Bilgileri"; bakiyeLabel.Text = "[Mevcut Bakiye]";
                //ekle kismi dil cevirme
                yemekSipGroupBox.Text = "Almak istediginiz ogunleri isaretleyiniz : ";
                kahvCheckBox.Text = "Kahvalti - 2.25 TL";
                ogleCheckBox.Text = "Ogle Yemegi - 3.25 TL";
                aksamCheckBox.Text = "Aksam Yemegi - 3.50 TL";
                label1.Text = "Tarihinden -"; label1.Location = new Point(7, 179);
                label2.Text = "Tarihine -"; label2.Location = new Point(26, 210);
                ekleButton.Text = "Ekle";
                //menu kismi dil cevirme
                hakkindaToolStripMenuItem.Text = "Program Hakkinda";
                kullaniciHakkindaToolStripMenuItem.Text = "Kullanici Hakkinda";
                //iptal kismi dil cevirme
                groupBox2.Text = "Iptal Etmek istediginiz ogunleri isaretleyiniz : ";
                kahvaltiIptalCB.Text = "Kahvalti - 2.25 TL";
                ogleIptalCB.Text = "Ogle Yemegi - 3.25 TL";
                aksamIptalCB.Text = "Aksam Yemegi - 3.50 TL";
                label4.Text = "Tarihinden -"; label4.Location = new Point(7, 179);
                label3.Text = "Tarihine -"; label3.Location = new Point(26, 210);
                iptalButton.Text = "Sil";
                gosterButton.Text = "G O S T E R";
            }
        }
    }
}
