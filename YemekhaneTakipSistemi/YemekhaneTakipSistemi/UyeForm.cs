using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YemekhaneTakipSistemi
{
    public partial class UyeForm : Form
    {
        private char _dil;
        public UyeForm()
        {
            InitializeComponent();
        }
        public void setDil(char dil)
        {
            _dil = dil;
        }
        int bakiye = 0;

        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                           AttachDbFilename=C:\Users\Selim\Documents\YemekhaneData.mdf;
                                         Integrated Security=True;Connect Timeout=30");

        #region TextBoxControls 
        //Sayi haricinde ifade kabul etmeyecek
        private void oKartTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //Harf haricinde ifade kabul etmeyecek
        private void pAdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //Harf haricinde ifade kabul etmeyecek
        private void pSoyadTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //Harf haricinde ifade kabul etmeyecek
        private void oAdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //Harf haricinde ifade kabul etmeyecek
        private void oSoyadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //Harf haricinde ifade kabul etmeyecek
        private void fakulteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //Harf haricinde ifade kabul etmeyecek
        private void oBolumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //Harf haricinde ifade kabul etmeyecek
        private void bolumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //Harf haricinde ifade kabul etmeyecek
        private void departTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //Harf haricinde ifade kabul etmeyecek
        private void sirketTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //Harf haricinde ifade kabul etmeyecek
        private void univanTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        //Sayi haricinde ifade kabul etmeyecek
        private void pKartTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
        #region Buttons
        private void uyeOlButton_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.ToLocalTime();

            if (persRadioButton.Checked == true)
            {
                if (pKartTextBox.Text == "" || pAdTextBox.Text == "" ||
                    pSoyadTextbox.Text == "" || pSifreTextBox.Text == "" || pSifreTekrarTextBox.Text == "")
                {

                    pKartTextBox.BackColor = Color.Red;
                    pAdTextBox.BackColor = Color.Red;
                    pSoyadTextbox.BackColor = Color.Red;
                    pSifreTextBox.BackColor = Color.Red;
                    pSifreTekrarTextBox.BackColor = Color.Red;
                    if (_dil == 'T')
                    {
                        if (MessageBox.Show("Zorunlu Bilgileri Giriniz", "HATA!!!",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
                              == DialogResult.OK)
                        {
                            pKartTextBox.BackColor = Color.Yellow;
                            pAdTextBox.BackColor = Color.LimeGreen;
                            pSoyadTextbox.BackColor = Color.Aqua;
                            pSifreTextBox.BackColor = Color.Azure;
                            pSifreTekrarTextBox.BackColor = Color.SandyBrown;
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Please insert Required Information", "ERROR!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                        == DialogResult.OK)
                        {
                            pKartTextBox.BackColor = Color.Yellow;
                            pAdTextBox.BackColor = Color.LimeGreen;
                            pSoyadTextbox.BackColor = Color.Aqua;
                            pSifreTextBox.BackColor = Color.Azure;
                            pSifreTekrarTextBox.BackColor = Color.SandyBrown;
                        }
                    }

                }//End Bosluk if
                else
                {
                    if (pKartTextBox.TextLength == 11)
                    {
                        if (pSifreTextBox.Text == pSifreTekrarTextBox.Text)
                        {
                            DateTime date = DateTime.Now.ToLocalTime();
                            //Cinsiyeti Erkek olarak secse "Erkek" Yazacak DataBase aksine "Kadin" Yazar
                            string c = pErkekRadioButton.Checked ? "ERKEK" : "KADIN";

                            try
                            {
                                SqlCommand cmd = new SqlCommand(
                                @"INSERT INTO PERSONEL (PersonelKartID,Ad,Soyad,Cinsiyet,Sirket,Departman
                            ,Bolum,Unvan,Sifre,IseGirisTarihi,SonGiris,SonSaat)
                            VALUES(@pg,@ad,@sd,@cin,@sir,@dep,@b,@unvan,@sif,@isegt,@sg,@ss)", connection);

                                cmd.Parameters.AddWithValue("@pg", pKartTextBox.Text);
                                cmd.Parameters.AddWithValue("@ad", pAdTextBox.Text);
                                cmd.Parameters.AddWithValue("@sd", pSoyadTextbox.Text);
                                cmd.Parameters.AddWithValue("@cin", c);
                                cmd.Parameters.AddWithValue("@sir", sirketTextBox.Text);
                                cmd.Parameters.AddWithValue("@dep", departTextBox.Text);
                                cmd.Parameters.AddWithValue("@b", pBolumTextBox.Text);
                                cmd.Parameters.AddWithValue("@unvan", unvanTextBox.Text);
                                cmd.Parameters.AddWithValue("@sif", pSifreTextBox.Text);
                                cmd.Parameters.AddWithValue("@isegt", girisDateTimePicker.Text);
                                cmd.Parameters.AddWithValue("@sg", String.Format("{0:dd/MM/yyyy}", date.ToShortDateString()));
                                cmd.Parameters.AddWithValue("@ss", date.ToShortTimeString()); ;
                                SqlCommand cmd1 = new SqlCommand(@"INSERT INTO BAKIYE 
                        (BakiyeID,Tarih,Saat,Bakiye,PersonelKartID,OgrenciKartID)
                        VALUES(@bID,@t,@s,@b,@pID,@oID)", connection);
                                bakiye++;
                                cmd1.Parameters.AddWithValue("@bID", bakiye);
                                cmd1.Parameters.AddWithValue("@t", dt.ToShortDateString());
                                cmd1.Parameters.AddWithValue("@s", dt.ToShortTimeString());
                                cmd1.Parameters.AddWithValue("@b", 0);
                                cmd1.Parameters.AddWithValue("@pID", pKartTextBox.Text);
                                cmd1.Parameters.AddWithValue("@oID", 0);
                                if (connection.State == ConnectionState.Closed)
                                    connection.Open();
                                cmd1.ExecuteNonQuery();
                                cmd.ExecuteNonQuery();
                                connection.Close();
                                if (_dil == 'T')
                                    MessageBox.Show("Uyeliginiz gerceklesti.\nGiris yapabilirsiniz",
                                        pAdTextBox.Text + " " + pSoyadTextbox.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    MessageBox.Show("Account is created.\nYou can log in now",
                                    pAdTextBox.Text + " " + pSoyadTextbox.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (_dil == 'T')
                                {
                                    if (MessageBox.Show("Giris yapmak istiyor musunuz?", pAdTextBox.Text
                                          + " " + pSoyadTextbox.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        this.Dispose();
                                        GirisForm gf = new GirisForm();
                                        gf.ShowDialog();
                                    }
                                    else
                                        this.Dispose();
                                }
                                else
                                {
                                    if (MessageBox.Show("Do you want to Log in?", pAdTextBox.Text
                                        + " " + pSoyadTextbox.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        this.Dispose();
                                        GirisForm gf = new GirisForm();
                                        gf.ShowDialog();
                                    }
                                    else
                                        this.Dispose();
                                }
                            }
                            catch
                            {
                                if (_dil == 'T')
                                    MessageBox.Show("Girdiginiz Bilgileri kayit altinda bulunmaktadir");
                                else
                                    MessageBox.Show("The Information that you wrote is in our database");
                            }
                        }// end sifre tekrari if
                        else
                        {

                            pSifreTekrarTextBox.BackColor = Color.Red;
                            pSifreTextBox.BackColor = Color.Red;
                            if (_dil == 'T')
                            {
                                if (MessageBox.Show("Sifre eslestirilemedi!!!", "HATA!!!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                                {
                                    pSifreTekrarTextBox.Clear();
                                    pSifreTextBox.Clear();
                                    pSifreTextBox.BackColor = Color.Aqua;
                                    pSifreTekrarTextBox.BackColor = Color.SandyBrown;
                                }
                            }
                            else
                            {
                                if (MessageBox.Show("Passwords do not Match!!!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                                {
                                    pSifreTekrarTextBox.Clear();
                                    pSifreTextBox.Clear();
                                    pSifreTextBox.BackColor = Color.Aqua;
                                    pSifreTekrarTextBox.BackColor = Color.SandyBrown;
                                }
                            }

                        }//end sifre tekrari else
                    }//end pkart if
                    else
                    {
                        pKartTextBox.BackColor = Color.Magenta;
                        if (_dil == 'T')
                        {
                            if (MessageBox.Show("Kart numarasi 11 haneli olmalidir!", "HATA!!!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                            {
                                pKartTextBox.Clear();
                                pKartTextBox.BackColor = Color.Azure;
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Card Number must contain 11 numbers!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                            {
                                pKartTextBox.Clear();
                                pKartTextBox.BackColor = Color.Azure;
                            }
                        }
                    }/*END 3rd else*/
                }/*End 2nd else*/
            }/*End pRadioButton if*/
            else
            {
                if (oKartTextBox.Text == "" || oAdTextBox.Text == "" ||
                    oSoyadTextBox.Text == "" || oSifreTextBox.Text == "" || oSifreTekTextBox.Text == "")
                {
                    oKartTextBox.BackColor = Color.Red;
                    oAdTextBox.BackColor = Color.Red;
                    oSoyadTextBox.BackColor = Color.Red;
                    oSifreTextBox.BackColor = Color.Red;
                    oSifreTekTextBox.BackColor = Color.Red;
                    if (_dil == 'T')
                    {
                        if (MessageBox.Show("Zorunlu Bilgileri Giriniz", "HATA!!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                            == DialogResult.OK)
                        {
                            oKartTextBox.BackColor = Color.Yellow;
                            oAdTextBox.BackColor = Color.LimeGreen;
                            oSoyadTextBox.BackColor = Color.Aqua;
                            oSifreTextBox.BackColor = Color.Aqua;
                            oSifreTekTextBox.BackColor = Color.SandyBrown;
                        }
                }
                else
                {
                    if (MessageBox.Show("Please insert Required Information", "ERROR!!!",
                      MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                            oKartTextBox.BackColor = Color.Yellow;
                            oAdTextBox.BackColor = Color.LimeGreen;
                            oSoyadTextBox.BackColor = Color.Aqua;
                            oSifreTextBox.BackColor = Color.Aqua;
                            oSifreTekTextBox.BackColor = Color.SandyBrown;
                        }
                }
                }/*End Bosluk Kontrolu (IF)*/
                else
                {
                    if (oKartTextBox.TextLength == 11)
                    {
                        if (oSifreTextBox.Text == oSifreTekTextBox.Text)
                        {
                            DateTime date = DateTime.Now.ToLocalTime();
                            string c = oErkekRadioButton.Checked ? "ERKEK" : "KADIN";
                            try
                            {

                                SqlCommand cmd = new SqlCommand(@"INSERT INTO OGRENCILER (OgrenciKartID,Ad,Soyad,Cinsiyet,Universite,
                                                             Fakulte,Bolum,Sifre,FakulteyeGirisTarihi,SonGiris,SonSaat)
                            VALUES(@og,@ad,@sd,@cin,@uni,@fak,@b,@sif,@fakgt,@sg,@ss)", connection);

                                cmd.Parameters.AddWithValue("@og", oKartTextBox.Text);
                                cmd.Parameters.AddWithValue("@ad", oAdTextBox.Text);
                                cmd.Parameters.AddWithValue("@sd", oSoyadTextBox.Text);
                                cmd.Parameters.AddWithValue("@cin", c);
                                cmd.Parameters.AddWithValue("@uni", universiteTextBox.Text);
                                cmd.Parameters.AddWithValue("@fak", fakulteTextBox.Text);
                                cmd.Parameters.AddWithValue("@b", oBolumTextBox.Text);
                                cmd.Parameters.AddWithValue("@sif", oSifreTextBox.Text);
                                cmd.Parameters.AddWithValue("@fakgt", fgirisDateTimePicker.Text);
                                cmd.Parameters.AddWithValue("@sg", String.Format("{0:dd/MM/yyyy}", date.ToShortDateString()));
                                cmd.Parameters.AddWithValue("@ss", date.ToShortTimeString()); SqlCommand cmd1 = new SqlCommand(@"INSERT INTO BAKIYE 
                        (BakiyeID,Tarih,Saat,Bakiye,PersonelKartID,OgrenciKartID)
                        VALUES(@bID,@t,@s,@b,@pID,@oID)", connection);
                                bakiye++;
                                cmd1.Parameters.AddWithValue("@bID", bakiye);
                                cmd1.Parameters.AddWithValue("@t", dt.ToShortDateString());
                                cmd1.Parameters.AddWithValue("@s", dt.ToShortTimeString());
                                cmd1.Parameters.AddWithValue("@b", 0);
                                cmd1.Parameters.AddWithValue("@oID", oKartTextBox.Text);
                                cmd1.Parameters.AddWithValue("@pID", 0);
                                if (connection.State == ConnectionState.Closed)
                                    connection.Open();
                                cmd1.ExecuteNonQuery();
                                cmd.ExecuteNonQuery();
                                connection.Close();
                                if (_dil == 'T')
                                    MessageBox.Show("Uyeliginiz gerceklesti.\nGiris yapabilirsiniz",
                                    oAdTextBox.Text + " " + oSoyadTextBox.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    MessageBox.Show("Account is created.\nYou can log in now",
                                    pAdTextBox.Text + " " + pSoyadTextbox.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (_dil == 'T')
                                {
                                    if (MessageBox.Show("Giris yapmak istiyor musunuz?", oAdTextBox.Text + " " + oSoyadTextBox.Text,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        this.Dispose();
                                        GirisForm gf = new GirisForm();
                                        gf.ShowDialog();
                                    }
                                    else
                                        this.Dispose();
                                }
                                else
                                {
                                    if (MessageBox.Show("Do you want to Log in?", pAdTextBox.Text
                                        + " " + pSoyadTextbox.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        this.Dispose();
                                        GirisForm gf = new GirisForm();
                                        gf.ShowDialog();
                                    }
                                    else
                                        this.Dispose();
                                }
                             }
                            catch
                            {
                                if (_dil == 'T')
                                    MessageBox.Show("Girdiginiz Bilgileri kayit altinda bulunmaktadir");
                                else
                                    MessageBox.Show("The Information that you wrote is in our database");
                            }
                        }/*End IF (Sifre=SifreTekrari)*/
                        else
                        {
                            oSifreTekTextBox.BackColor = Color.Red;
                            oSifreTextBox.BackColor = Color.Red;
                            if(_dil == 'T')
                            if (MessageBox.Show("Sifre eslestirilemedi!!!", "HATA!!!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                            {
                                oSifreTekTextBox.Clear();
                                oSifreTextBox.Clear();
                                oSifreTextBox.BackColor = Color.Aqua;
                                oSifreTekTextBox.BackColor = Color.SandyBrown;
                            }
                            else
                                if (MessageBox.Show("Passwords do not Match!!!", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                            {
                                oSifreTekTextBox.Clear();
                                oSifreTextBox.Clear();
                                oSifreTextBox.BackColor = Color.Aqua;
                                oSifreTekTextBox.BackColor = Color.SandyBrown;
                            }
                        }
                    }/*End Okart 11 haneli olma Kontrolu*/
                    else
                    {
                        oKartTextBox.BackColor = Color.Magenta;
                        if(_dil == 'T')
                        if (MessageBox.Show("Kart numarasi 11 haneli olmalidir!", "HATA!!!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            oKartTextBox.Clear();
                            oKartTextBox.BackColor = Color.Azure;
                        }
                        else
                           if (MessageBox.Show("Card Number must contain 11 numbers!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                           {
                                    oKartTextBox.Clear();
                                    oKartTextBox.BackColor = Color.Azure;
                           }
                            

                    }
                }/*End Bosluk Kontrolu (else)*/
            }/*End RadioButton else*/
        }
        //Harf haricinde ifade kabul etmeyecek
        private void universiteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
        private void UyeForm_Load(object sender, EventArgs e)
        {
            DiliDegistir();
            connection.Open();
            SqlCommand b = new SqlCommand(@"SELECT COUNT (BakiyeID) FROM BAKIYE ", connection);
            var bak = b.ExecuteScalar().ToString();
            connection.Close();
            bakiye = Convert.ToInt32(bak);
            //Ilk durumda personel secilmis durumdadir
            persRadioButton.Checked = true;
            ogrGroupBox.Visible = false;
        }
        
        #region RadioButtons

        private void persRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ogrGroupBox.Visible = false;
            oKartTextBox.Clear();
            oAdTextBox.Clear();
            oSoyadTextBox.Clear();
            oBolumTextBox.Clear();
            fakulteTextBox.Clear();
            oSifreTextBox.Clear();
            persGroupBox.Visible = true;
        }

        private void ogrRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ogrGroupBox.Visible = true;
            pKartTextBox.Clear();
            pAdTextBox.Clear();
            pSoyadTextbox.Clear();
            pSifreTextBox.Clear();
            sirketTextBox.Clear();
            departTextBox.Clear();
            unvanTextBox.Clear();
            pBolumTextBox.Clear();
            persGroupBox.Visible = false;
        }
        #endregion

        #region MouseHover

        private void pKartTextBox_MouseHover(object sender, EventArgs e)
        {
            if (_dil == 'T')
                toolTip1.Show("Kart Numarasini Girmek Zorunludur.", pKartTextBox);
            else
                toolTip1.Show("You have to enter your Cart Number.", pKartTextBox);
        }

        private void pAdTextBox_MouseHover(object sender, EventArgs e)
        {
            if (_dil == 'T')
                toolTip1.Show("Adi Girmek Zorunludur.", pAdTextBox);
            else
                toolTip1.Show("You have to enter your First name.", pAdTextBox);
        }

        private void oKartTextBox_MouseHover(object sender, EventArgs e)
        {
            if (_dil == 'T')
                toolTip1.Show("Kart Numarasini Girmek Zorunludur.", oKartTextBox);
            else
                toolTip1.Show("You have to enter your Cart Number.", oKartTextBox);
        }

        private void oAdTextBox_MouseHover(object sender, EventArgs e)
        {
            if (_dil == 'T')
                toolTip1.Show("Adi Girmek Zorunludur.", oAdTextBox);
            else
                toolTip1.Show("You have to enter your First name.", oAdTextBox);
        }

        private void pSoyadTextbox_MouseHover(object sender, EventArgs e)
        {
            if (_dil == 'T')
                toolTip1.Show("Soyadi Girmek Zorunludur.", pSoyadTextbox);
            else
                toolTip1.Show("You have to enter your Last name.", pSoyadTextbox);
        }

        private void oSoyadTextBox_MouseHover(object sender, EventArgs e)
        {
            if (_dil == 'T')
                toolTip1.Show("Soyadi Girmek Zorunludur.", oSoyadTextBox);
            else
                toolTip1.Show("You have to enter your Last name.", oSoyadTextBox);
        }

        private void pSifreTextBox_MouseHover(object sender, EventArgs e)
        {
            if (_dil == 'T')
                toolTip1.Show("Sifre Girmek Zorunludur.", pSifreTextBox);
            else
                toolTip1.Show("You have to enter your Password.", pSifreTextBox);
        }

        private void oSifreTextBox_MouseHover(object sender, EventArgs e)
        {
            if (_dil == 'T')
                toolTip1.Show("Sifre Girmek Zorunludur.", oSifreTextBox);
            else
                toolTip1.Show("You have to enter your Password.", oSifreTextBox);
        }

        private void pSifreTekrarTextBox_MouseHover(object sender, EventArgs e)
        {
            if (_dil == 'T')
                toolTip1.Show("Sifre Girmek Zorunludur.", pSifreTekrarTextBox);
            else
                toolTip1.Show("You have to enter your Password.", pSifreTekrarTextBox);
        }

        private void oSifreTekTextBox_MouseHover(object sender, EventArgs e)
        {
            if (_dil == 'T')
                toolTip1.Show("Sifre Girmek Zorunludur.", oSifreTekTextBox);
            else
                toolTip1.Show("You have to enter your Password.", oSifreTekTextBox);
        }
        #endregion
        private void DiliDegistir()
        {
            if(_dil == 'E')
            {
                label17.Text = "";
                uyeOlButton.Text = "Sign IN";
                geriButton.Text = "Back";
                ogrRadioButton.Text = "Student";
                persRadioButton.Text = "Stuff";
                persGroupBox.Text = "Staff Information"; ogrGroupBox.Text = "Student Information";
                //personel icin
                pKartLabel.Text = "Card Number :";pKartLabel.Location = new Point(25, 37);
                pAdLabel.Text = "First Name :"; pAdLabel.Location = new Point(36, 61);
                psoyadLabel.Text = "Last Name :"; psoyadLabel.Location = new Point(36, 83);
                label3.Text = "Sex :"; label3.Location = new Point(68, 104);
                sirketLabel.Text = "Company :"; sirketLabel.Location = new Point(43, 128);
                departLabel.Text = "Department :"; departLabel.Location = new Point(32, 150);
                pBolumLabel.Text = "Section :"; pBolumLabel.Location = new Point(51, 173);
                unvanLabel.Text = "Title :"; unvanLabel.Location = new Point(68, 196);
                label1.Text = "Password :"; label1.Location = new Point(43, 222);
                label18.Text = "Password Again :"; label18.Location = new Point(14, 241);
                girisLabel.Text = "Job Application Date :"; girisLabel.Location = new Point(-3, 263);
                pKadinRadioButton.Text = "Female";
                pErkekRadioButton.Text = "Male";

                //ogrenci icin
                label9.Text = "Card Number :"; label9.Location = new Point(40, 37);
                label8.Text = "First Name :"; label8.Location = new Point(52, 61);
                label7.Text = "Last Name :"; label7.Location = new Point(51, 83);
                label22.Text = "Sex :"; label22.Location = new Point(84, 106);
                label23.Text = "University :"; label23.Location = new Point(56, 128);
                label6.Text = "Faculty :"; label6.Location = new Point(68, 150);
                label5.Text = "Section :"; label5.Location = new Point(66, 173);
                sifreLabel.Text = "Password :"; sifreLabel.Location = new Point(56, 222);
                label19.Text = "Password Again :"; label19.Location = new Point(26, 241);
                label2.Text = "Faculty Signin Date :"; label2.Location = new Point(10, 269);
                oKadinRadioButton.Text = "Female";
                oErkekRadioButton.Text = "Male";
            }
            else
            {
                uyeOlButton.Text = "Uye OL";
                geriButton.Text = "Geri";
                label17.Text = "Uye Giris Sayfasi"; ogrRadioButton.Text = "Ogrenci";
                persGroupBox.Text = "Personel Bilgileri"; ogrGroupBox.Text = "Ogrenci Bilgileri";
                //personel icin
                pKartLabel.Text = "Kard No :"; pKartLabel.Location = new Point(41, 37);
                pAdLabel.Text = "Ad :"; pAdLabel.Location = new Point(67, 59);
                psoyadLabel.Text = "Soyad :"; psoyadLabel.Location = new Point(50, 83);
                label3.Text = "Cinsiyet :"; label3.Location = new Point(44, 104);
                departLabel.Text = "Departman :"; departLabel.Location = new Point(28, 150);
                sirketLabel.Text = "Sirket :"; sirketLabel.Location = new Point(59, 128);
                pBolumLabel.Text = "Bolum :"; pBolumLabel.Location = new Point(51, 173);
                unvanLabel.Text = "Unvan :"; unvanLabel.Location = new Point(46, 196);
                label1.Text = "Sifre :";label1.Location = new Point(59, 222);
                label18.Text = "Sifre Tekrar :"; label18.Location = new Point(28, 241);
                girisLabel.Text = "Ise Giris Tarihi :"; girisLabel.Location = new Point(14, 263);
                pKadinRadioButton.Text = "Kadin";
                pErkekRadioButton.Text = "Erkek";

                //ogrenci icin
                label9.Text = "Kard No :"; label9.Location = new Point(66, 37);
                label8.Text = "Ad :"; label8.Location = new Point(92, 59);
                label7.Text = "Soyad :"; label7.Location = new Point(75, 83);
                label22.Text = "Cinsiyet :"; label22.Location = new Point(69, 106);
                label23.Text = "Universite :"; label23.Location = new Point(58, 128);
                label6.Text = "Fakulte :"; label6.Location = new Point(70, 150);
                label5.Text = "Bolum :"; label5.Location = new Point(76, 173);
                unvanLabel.Text = "Unvan :"; unvanLabel.Location = new Point(46, 196);
                sifreLabel.Text = "Sifre :"; sifreLabel.Location = new Point(84, 222);
                label19.Text = "Sifre Tekrar :"; label19.Location = new Point(47, 241);
                label2.Text = "Fakulteye Giris Tarihi :"; label2.Location = new Point(7, 269);
                oKadinRadioButton.Text = "Kadin";
                oErkekRadioButton.Text = "Erkek";


            }
        }
    }
}
