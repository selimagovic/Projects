using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Yetkili
{
    public partial class YetkilininGirisSayfasi : Form
    {
        private char _dil;
        public YetkilininGirisSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                              AttachDbFilename=C:\Users\Selim\Documents\YemekhaneData.mdf;
                                            Integrated Security=True;Connect Timeout=30");
        private void girisButton_Click(object sender, EventArgs e)
        {
            if (kartTextBox.Text == " " || sifreTextBox.Text == " ")
            {
                if (_dil == 'T')
                    MessageBox.Show("Girisiniz Gerceklestirilemedi Gerekli Bilgileri Giriniz!!!", "UYARI !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Log in unsuccessful Please Enter Your Information !!!", "WARNING !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                string myString = "SELECT COUNT (*) FROM YETKILI WHERE KartID=@id AND Sifre=@s";
                SqlDataAdapter da = new SqlDataAdapter(myString, connection);


                //SQL injection engelemek icin kullanilan kod
                da.SelectCommand.Parameters.AddWithValue("@ID", kartTextBox.Text);
                da.SelectCommand.Parameters.AddWithValue("@s", sifreTextBox.Text);
                DataTable dt = new DataTable();

                try
                {
                    da.Fill(dt);
                }
                catch(Exception)
                {

                }
                if(dt.Rows[0][0].ToString() == "1")
                {
                    if (trRadioButton.Checked == true)
                        _dil = 'T';
                    else
                        _dil = 'E';

                    YetkiliAnaSayfa yas = new YetkiliAnaSayfa();
                    yas.GetDil(_dil);
                    this.Dispose();
                    connection.Close();
                    yas.ShowDialog();
                    
                }                
               else
                {
                    if (trRadioButton.Checked == true)
                        MessageBox.Show("Kart numaranizi ya da sifrenizi hatali girdiniz!!!");
                    else
                        MessageBox.Show("Card Number or Password is typed wrong!!!");

                }
            }
        }

        private void DiliDegistir()
        {
            if (enRadioButton.Checked == true)
            {
                this.Text = "Cafeteria Admin Program";
                girisButton.Text = "LOG IN";
                sifreLabel.Text = "Password :";sifreLabel.Location = new Point(244, 145);
                yetkiliLabel.Text = "Card ID :";yetkiliLabel.Location = new Point(260, 94);
            }
            else
            {
                this.Text = "Yemekhane Takip Programi";
                sifreLabel.Text = "Sifre :"; sifreLabel.Location = new Point(280, 142);
                yetkiliLabel.Text = "Kart ID :"; yetkiliLabel.Location = new Point(260, 94);
                girisButton.Text = "GIRIS";
            }


        }

        private void kartTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void trRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            DiliDegistir();
        }

        private void enRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            DiliDegistir();
        }

        private void YetkilininGirisSayfasi_Load(object sender, EventArgs e)
        {
            DiliDegistir();
        }
    }
}
