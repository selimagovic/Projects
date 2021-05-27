using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YemekhaneTakipSistemi
{
    public partial class UnutulanSifre : Form
    {
        private char radio;
        public UnutulanSifre()
        {
            InitializeComponent();
        }
        public void GetRadio(char rad)
        {
            radio = rad;
        }

        //Veritabanı ile kod arasında baglantı 
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                        AttachDbFilename=C:\Users\Selim\Documents\YemekhaneData.mdf;
                        Integrated Security=True;Connect Timeout=30");
        private void UnutulanSifre_Load(object sender, EventArgs e)
        {
            DiliDegistir();
            this.Size = new Size(430, 170);
            soyadLabel.Visible = false;
            ysLabel.Visible = false;
            ysTextBox.Visible = false;
            ystLabel.Visible = false;
            ystTextBox.Visible = false;
            degistirButton.Visible = false;
            label3.Visible = false;
            adLabel.Visible = false;

        }

        private void devamButton_Click(object sender, EventArgs e)
        {
            if (syKartTextBox.Text == "")
            {
                syKartTextBox.BackColor = Color.Red;
                string dil = radio=='T' ? "Kart Numaranizi giriniz" : "Please write Card Number!";
                string uyari = radio == 'T' ?  "UYARI":"Warning";
                if (MessageBox.Show(dil, uyari, MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    syKartTextBox.BackColor = Color.Moccasin;
                    syKartTextBox.Clear();
                }
            }/*END SYKART Kontrol*/
            else
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                string mySelect = persRadioButton.Checked ?
                    "SELECT COUNT(*) FROM PERSONEL WHERE PersonelKartID=@ID" :
                    "SELECT Count(*) FROM OGRENCILER WHERE OgrenciKartID=@ID";

                SqlDataAdapter dtAdapter = new SqlDataAdapter(mySelect, connection);
                dtAdapter.SelectCommand.Parameters.AddWithValue("@ID", syKartTextBox.Text);
                //Veri tablosu olusturma
                DataTable table = new DataTable();
                dtAdapter.Fill(table);

                // Tablodaki Kart Numarasi olup olmadigini kontrol eder
                if (table.Rows[0][0].ToString() =="1" )
                {
                    this.Size = new Size(430, 265);

                    if(persRadioButton.Checked == true)
                    {
                        string myAd = "select Ad from PERSONEL WHERE  PersonelKartID=@ID";
                        string mySoyad = "select Soyad from PERSONEL WHERE  PersonelKartID=@ID2";
                        SqlCommand cmd = new SqlCommand(myAd, connection);
                        cmd.Parameters.AddWithValue("@ID", syKartTextBox.Text);
                        var a = cmd.ExecuteScalar().ToString();
                        adLabel.Text = a;
                        cmd.CommandText = mySoyad;
                        cmd.Parameters.AddWithValue("@ID2", syKartTextBox.Text);
                        var b = cmd.ExecuteScalar().ToString();
                        soyadLabel.Text =" "+b;
                    }
                    else
                    {
                        string myAd = "select Ad from OGRENCILER WHERE  OgrenciKartID=@ID";
                        string mySoyad = "select Soyad from OGRENCILER WHERE  OgrenciKartID=@ID2";
                        SqlCommand cmd = new SqlCommand(myAd, connection);
                        cmd.Parameters.AddWithValue("@ID", syKartTextBox.Text);
                        var a = cmd.ExecuteScalar().ToString();
                        adLabel.Text = a;
                        cmd.CommandText = mySoyad;
                        cmd.Parameters.AddWithValue("@ID2", syKartTextBox.Text);
                        var b = cmd.ExecuteScalar().ToString();
                        soyadLabel.Text = " "+b;
                    }

                    soyadLabel.Visible = true;
                    ysLabel.Visible = true;
                    ysTextBox.Visible = true;
                    ystLabel.Visible = true;
                    ystTextBox.Visible = true;
                    degistirButton.Visible = true;
                    label3.Visible = true;
                    adLabel.Visible = true;
                    connection.Close();
                }/*END Tablo kontrol*/
                else
                {
                    if (radio == 'T')
                        MessageBox.Show("Girdiginiz kart numaranizi Database Bulunmamaktadir!!!");
                    else
                        MessageBox.Show("We cannot find this Card Number in our database");
                    ysLabel.Visible = false;
                    ysTextBox.Visible = false;
                    ystLabel.Visible = false;
                    ystTextBox.Visible = false;
                    degistirButton.Visible = false;
                    label3.Visible = false;
                    adLabel.Visible = false;
                }/*END IKINCI ELSE*/
            }/*END BIRINCI ELSE*/
        }
        // Sifre degistirme islemi icin yeni sifre alma metodu
        private void degistirButton_Click(object sender, EventArgs e)
        {            
            if (ysTextBox.Text == " " || ystTextBox.Text == "")
            {
                ystTextBox.BackColor = Color.Red;
                ysTextBox.BackColor = Color.Red;

                string dil = radio == 'T' ? "Kart Numaranizi giriniz" : "Please write Card Number!";
                string uyari = radio == 'T' ? "UYARI" : "Warning";
                if (MessageBox.Show(dil, uyari, MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ystTextBox.BackColor = Color.Moccasin;
                    ysTextBox.BackColor = Color.Moccasin;
                    ysTextBox.Clear();
                    ystTextBox.Clear();
                }
            }
            else
            {
                if (persRadioButton.Checked == true)
                {
                    if (ysTextBox.Text == ystTextBox.Text)
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();
                        string mySelect = "SELECT COUNT (*) FROM PERSONEL WHERE PersonelKartID=@ID";
                        SqlDataAdapter da = new SqlDataAdapter(mySelect, connection);
                        da.SelectCommand.Parameters.AddWithValue("@ID", syKartTextBox.Text);                       

                        try
                        {
                            if (connection.State == ConnectionState.Closed)
                                connection.Open();
                            SqlCommand cmd = new SqlCommand("UPDATE PERSONEL SET Sifre='"+ysTextBox.Text+
                                "' WHERE PersonelKartID ='"+syKartTextBox.Text+"'", connection);
                                                                                  
                            cmd.ExecuteNonQuery();
                            if(radio == 'T')
                                MessageBox.Show("Gunceleme Islemi Basarili");
                            else
                                MessageBox.Show("Password Change Successful");
                            this.Dispose();

                        }
                        catch(SqlException)
                        {
                            if (radio == 'T')
                                MessageBox.Show("Hata olustu");
                            else
                                MessageBox.Show("Error ocured");
                        }
                        finally
                        {
                            connection.Close();
                        }                        
                    }
                    else
                    {
                        ysTextBox.BackColor = Color.Red;
                        ystTextBox.BackColor = Color.Red;
                        string dil = radio == 'T' ? "Sifreler eslestirilemedi!!" : "Passwords Do not Match";
                        string uyari = radio == 'T' ? "Hata" : "Error";
                        if (MessageBox.Show(dil, uyari, 
                            MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            ysTextBox.BackColor = Color.Moccasin;
                            ystTextBox.BackColor = Color.Moccasin;
                            ysTextBox.Clear();
                            ystTextBox.Clear();
                        }
                    }
                }
                else
                {
                    if (ysTextBox.Text == ystTextBox.Text)
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE OGRENCILER SET Sifre='" + ysTextBox.Text + 
                            "' WHERE OgrenciKartID ='" + syKartTextBox.Text + "'", connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        if(radio == 'T')
                        MessageBox.Show("Gunceleme Islemi Basarili");
                        else
                            MessageBox.Show("Update Successful");
                        this.Dispose();
                        
                    }
                    else
                    {
                        ysTextBox.BackColor = Color.Red;
                        ystTextBox.BackColor = Color.Red;
                        string dil = radio == 'T' ? "Sifreler eslestirilemedi!!" : "Passwords Do not Match";
                        string uyari = radio == 'T' ? "Hata" : "Error";
                        if (MessageBox.Show(dil,uyari, 
                            MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            ysTextBox.BackColor = Color.Moccasin;
                            ystTextBox.BackColor = Color.Moccasin;
                            ysTextBox.Clear();
                            ystTextBox.Clear();
                        }
                    }
                }
            }
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void syKartTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void DiliDegistir()
        {
            if(radio == 'E')
            {
                devamButton.Text = "Continue";
                persRadioButton.Text = "Stuff";
                ogrRadioButton.Text = "Student";
                label1.Text = "Card Number :";
                ysLabel.Text = "New Password :";
                ysLabel.Location = new Point(54, 158);
                ystLabel.Text = "New Password Again :";
                ystLabel.Location = new Point(8, 183);
                label2.Text = "Password Change Page";
                label2.Location = new Point(115, 9);
                label3.Text = "Dear, ";
                degistirButton.Text = "Change";
                geriButton.Text = "BACK";

            }
            else
            {
                label2.Text = "Sifre Yenileme Sayfasi";
                label2.Location = new Point(125, 9);
                ysLabel.Text = "Yeni Sifre :";
                ysLabel.Location = new Point(88, 158);
                ystLabel.Text = "Yeni Sifrenin Tekrari :";
                ystLabel.Location = new Point(8, 183);
                degistirButton.Text = "Degistir";
                geriButton.Text = "GERI";
                label3.Text = "Sayin, ";
            }
        }
    }
}
