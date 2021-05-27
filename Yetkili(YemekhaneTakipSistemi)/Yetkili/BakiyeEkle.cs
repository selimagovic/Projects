using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Yetkili
{
    public partial class BakiyeEkle : Form
    {
        private char _dil;
        public BakiyeEkle()
        {
            InitializeComponent();
        }
        public void getDil(char dil)
        {
            _dil = dil;
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                              AttachDbFilename=C:\Users\Selim\Documents\YemekhaneData.mdf;
                                            Integrated Security=True;Connect Timeout=30");
        double bakiye = 0.0f;
        private bool KontrolEt()
        {
            bool kabuletti = false;
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            string myString;
            if (personelRadioButton.Checked == true)
                myString = "SELECT COUNT (*) FROM PERSONEL WHERE PersonelKartID=@id";
            else
                myString = "SELECT COUNT (*) FROM OGRENCILER WHERE OgrenciKartID=@id";

            SqlDataAdapter da = new SqlDataAdapter(myString, connection);


            //SQL injection engelemek icin kullanilan kod
            da.SelectCommand.Parameters.AddWithValue("@ID", kartTextBox.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                kabuletti = true;
            }
            connection.Close();
            return kabuletti;
        }
        private double bakiyeOku(string data)
        {
            double mevcutBakiye;
            using (var cmd = new SqlCommand(data, connection))
            {
                if (personelRadioButton.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@pID", kartTextBox.Text);
                    cmd.Parameters.AddWithValue("@oID", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@pID", 0);
                    cmd.Parameters.AddWithValue("@oID", kartTextBox.Text);
                }
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                var bak = cmd.ExecuteScalar().ToString();
                mevcutBakiye = Convert.ToDouble(bak);
                connection.Close();
            }
            return mevcutBakiye;
        }

        private void BakiyeGuncelleme(string data, double bakiye, DateTime date, double miktar)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE BAKIYE SET  Tarih=@t,Saat=@s,Bakiye=@b 
                    WHERE PersonelKartID=@pID and OgrenciKartID=@oID", connection);

            cmd.Parameters.AddWithValue("@t", date.ToShortDateString());
            cmd.Parameters.AddWithValue("@s", date.ToShortTimeString());
            cmd.Parameters.AddWithValue("@b", bakiye);
            if (personelRadioButton.Checked == true)
            {
                cmd.Parameters.AddWithValue("@pID", kartTextBox.Text);
                cmd.Parameters.AddWithValue("@oID", 0);
            }
            else
            {
                cmd.Parameters.AddWithValue("@pID", 0);
                cmd.Parameters.AddWithValue("@oID", kartTextBox.Text);
            }
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show(" Islem Basarili !!! ");
        }
        private void bakiyeEkleButton_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.ToLocalTime();

            if (onCheckBox.Checked == false && yirmiCheckBox.Checked == false && eliCheckBox.Checked == false && yuzCheckBox.Checked == false)
            {
                if (_dil == 'T')
                    MessageBox.Show("\tBir secim yapmaniz gerekmektedir...   ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("\tYou Need To Make a Choice... ", "WARNING !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // bool kontrol;
                int on = onCheckBox.Checked ? 10 : 0;
                int yirmi = yirmiCheckBox.Checked ? 20 : 0;
                int elli = eliCheckBox.Checked ? 50 : 0;
                int yuz = yuzCheckBox.Checked ? 100 : 0;
                double miktar = Convert.ToDouble(on + yirmi + elli + yuz);

                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                string myBakiye = "select Bakiye from BAKIYE where PersonelKartID=@pID and OgrenciKartID=@oID";
                //kontrol = KontrolEt();
                if (KontrolEt())
                {
                    bakiye = bakiyeOku(myBakiye);
                    bakiye += Convert.ToDouble(miktar);
                    BakiyeGuncelleme(myBakiye, bakiye, dt, miktar);
                }
                else
                {
                    if (_dil == 'T')
                        MessageBox.Show("Kart numaranizi hatali girdiniz!!!");
                    else
                        MessageBox.Show("Card Number is typed wrong!!!");
                }

            }
        }

        private void BakiyeEkle_Load(object sender, EventArgs e)
        {
            DilDegistir();
        }

        private void DilDegistir()
        {
            if (_dil == 'E')
            {
                label1.Text = "BALANCE Load Process";
                this.Text = "Balance Inserting Page";
                bakiyeEkleButton.Text = "INSERT BALANCE";
                groupBox.Text = "Chose Balance : ";
                personelRadioButton.Text = "Stuff";
                ogrenciRadioButton.Text = "Student";
                kartLabel.Text = "Card Number :"; kartLabel.Location = new System.Drawing.Point(10, 157);
            }
            else
            {
                label1.Text = "Bakiye Ekleme Islemi";
                this.Text = "Bakiye Ekle Sayfasi";
                bakiyeEkleButton.Text = "BAKIYE EKLE";
                groupBox.Text = "Miktar Seciniz : ";
                personelRadioButton.Text = "Personel";
                ogrenciRadioButton.Text = "Ogrenci";
                kartLabel.Text = "Kart Numarasi :"; kartLabel.Location = new System.Drawing.Point(3, 157);
            }
        }

        private void kartTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
