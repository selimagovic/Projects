using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace YemekhaneTakipSistemi
{
    public partial class GirisForm : Form
    {
        private char radio_ID,_dil;
        private decimal kimlik_ID;
        private DateTime date = DateTime.Parse("30/12/2014");
        
        public GirisForm()
        {
            InitializeComponent();
        }
        public void GetRadio(char dil)
        {
            _dil = dil;
        }
        //Veritabanı ile kod arasında baglantı 
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                      AttachDbFilename=C:\Users\Selim\Documents\YemekhaneData.mdf;
                                                   Integrated Security=True;Connect Timeout=30");

        #region TextBoxControls
        //Sayi haricinde ifade kabul etmeyecek
        private void gkartTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void personelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gkartTextBox.Clear();
            sifreTextBox.Clear();
        }

        private void ogrenciRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gkartTextBox.Clear();
            sifreTextBox.Clear();
        }
        #endregion
        #region BUTTONS

        private void geriButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void girisButton_Click(object sender, EventArgs e)
        {
            
            //Textbox bos olmamasi sagliyor if kontrol
            if ((gkartTextBox.Text == "") || (sifreTextBox.Text == ""))
            {
                if(_dil == 'T')
                MessageBox.Show("Lutfen Sifre Ya da Kart Numarasi giriniz!!!");
                else
                    MessageBox.Show("Please write Password and Card Number into fields!!!");
            }
                
            else
            {
                if (personelRadioButton.Checked == true)
                {
                    radio_ID = 'P';
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    string mySelect = "SELECT COUNT (*) FROM PERSONEL WHERE PersonelKartID=@ID and Sifre=@Sifre";
                    //Kullaıcıdan alınan verilerle veritabanındaki verileri karsilastirma
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelect, connection);

                    //SQL injection engelemek icin kullanilan kod
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@ID", gkartTextBox.Text);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Sifre", sifreTextBox.Text);

                    //Veri tablosu olusturma
                    DataTable table = new DataTable();
                    try
                    {
                        dataAdapter.Fill(table);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    if (table.Rows[0][0].ToString() == "1")
                    {   
                        kimlik_ID = Convert.ToDecimal(gkartTextBox.Text);
                        date = DateTime.Now.ToLocalTime();
                        MainForm mf = new MainForm();
                        mf.setId(radio_ID);
                        mf.setKimlik(kimlik_ID);
                        mf.setDate(date);
                        mf.getDil(_dil);
                        this.Dispose();
                        mf.ShowDialog();
                        connection.Close();
                    }
                    else
                    {
                        if (_dil == 'T')
                            MessageBox.Show("Kart numaranizi ya da sifrenizi hatali girdiniz!!!");
                        else
                            MessageBox.Show("Card Number or Password is typed wrong!!!");

                    }                    
                }
                else
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    radio_ID = 'O';
                    string mySelect = "SELECT COUNT (*) FROM OGRENCILER WHERE OgrenciKartID=@ID and Sifre=@Sifre";
                    //Kullaıcıdan alınan verilerle veritabanındaki verileri karsilastirma
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelect, connection);

                    //SQL injection engelemek icin kullanilan kod
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@ID", gkartTextBox.Text);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Sifre", sifreTextBox.Text);
                        //Veri tablosu olusturma
                        DataTable table = new DataTable();

                        dataAdapter.Fill(table);
                    if (table.Rows[0][0].ToString() == "1")
                    {

                        kimlik_ID = Convert.ToDecimal(gkartTextBox.Text);
                        date = DateTime.Now.ToLocalTime();
                        MainForm mf = new MainForm();
                        mf.setId(radio_ID);
                        mf.setDate(date);
                        mf.setKimlik(kimlik_ID);
                        mf.getDil(_dil);
                        mf.ShowDialog();
                        connection.Close();
                        this.Dispose();
                    }
                    else
                    {
                        if (_dil == 'T')
                            MessageBox.Show("Kart numaranizi ya da sifrenizi hatali girdiniz!!!");
                        else
                            MessageBox.Show("Card Number or Password is typed wrong!!!");
                    }                   
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UnutulanSifre us = new UnutulanSifre();
            us.GetRadio(_dil);
            us.ShowDialog();
            this.Show();
        }
        #endregion
        private void GirisForm_Load(object sender, EventArgs e)
        {
            DiliDegistir();
        }

        
        private void DiliDegistir()
        {
            if(_dil=='E')
            {
                anaLabel.Text = "Cafeteria Log In Page";
                girisButton.Text = "Log In";
                geriButton.Text = "Back";
                sifreLabel.Text = "Password :";
                sifreLabel.Location = new Point(337, 172);
                kartLabel.Text = "Card Number :";
                kartLabel.Location = new Point(314, 146);
                personelRadioButton.Text = "Stuff";
                ogrenciRadioButton.Text = "Student";
                linkLabel1.Text = "Forgot password?";
                linkLabel1.Location = new Point(468, 205);
            }
            else
            {
                anaLabel.Text = "Yemekhanenin Giris Sayfasi";
                girisButton.Text = "Giris";
                geriButton.Text = "Geri";
                sifreLabel.Text = "Sifre :";
                sifreLabel.Location = new Point(365, 172);
                kartLabel.Text = "Kart Numarasi :";
                kartLabel.Location = new Point(306, 146);
                personelRadioButton.Text = "Peronel";
                ogrenciRadioButton.Text = "Ogrenci";
                linkLabel1.Text = "Sifrenizi mi unuttunuz?";
                linkLabel1.Location = new Point(451, 204);
            }
        }
    }
}
