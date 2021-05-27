using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YemekhaneTakipSistemi
{
    public partial class MisafirForm : Form
    {
        private char _dil;
        public MisafirForm()
        {
            InitializeComponent();
        }
        public void getDil(char dil)
        {
            _dil = dil;
        }

        int misafirID, yemek;

        private void tcTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                    AttachDbFilename=C:\Users\Selim\Documents\YemekhaneData.mdf;
                                            Integrated Security=True;Connect Timeout=30");
        private void adTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void soyadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void MisafirForm_Load(object sender, EventArgs e)
        {
            DiliDegistir();

            this.Size = new Size(304, 340); panel.Visible = false;
            connection.Open();
            SqlCommand cmdsay = new SqlCommand(@"SELECT COUNT (MisafirID) FROM MISAFIR ", connection);

            var a = cmdsay.ExecuteScalar();
            connection.Close();
            misafirID = Convert.ToInt32(a);

            connection.Open();
            SqlCommand cmdsay2 = new SqlCommand(@"SELECT COUNT (YemekID) FROM MISAFIRYEMEK ", connection);

            var a2 = cmdsay.ExecuteScalar();
            connection.Close();
            yemek = Convert.ToInt32(a2);
            tarih.MinDate = DateTime.Now;

            yaGroupBox.Visible = false;
            gecisGroupBox.Visible = false;
            tarihine.MaxDate = DateTime.Now;
            tarihinden.MaxDate = DateTime.Now;
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.ToLocalTime();

            if (tcTextBox.TextLength == 11)
            {
                if (tcTextBox.Text == "" || adTextBox.Text == "" || soyadTextBox.Text == "")
                {
                    tcTextBox.BackColor = Color.Red;
                    adTextBox.BackColor = Color.Red;
                    soyadTextBox.BackColor = Color.Red;
                    if(_dil == 'T')
                    if (MessageBox.Show("Zorunlu bigileri giriniz!", "HATA!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        tcTextBox.BackColor = Color.Azure;
                        adTextBox.BackColor = Color.Azure;
                        soyadTextBox.BackColor = Color.Azure;
                        tcTextBox.Clear();
                        adTextBox.Clear();
                        soyadTextBox.Clear();
                    }
                    else
                        if (MessageBox.Show("Enter the required information!", "ERROR!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            tcTextBox.BackColor = Color.Azure;
                            adTextBox.BackColor = Color.Azure;
                            soyadTextBox.BackColor = Color.Azure;
                            tcTextBox.Clear();
                            adTextBox.Clear();
                            soyadTextBox.Clear();
                        }
                }
                else
                {
                    misafirID++;
                    string myString = @"INSERT INTO MISAFIR (TCKimlik,Ad,Soyad,
                                           GirisTarihi,GirisSaati,MisafirID) 
                VALUES (@TC,@a,@s,@gt,@gs,@id)";
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    SqlCommand cmd = new SqlCommand(myString, connection);

                    cmd.Parameters.Add("@TC", SqlDbType.Decimal).Value = Convert.ToDecimal(tcTextBox.Text);
                    cmd.Parameters.AddWithValue("@a", adTextBox.Text);
                    cmd.Parameters.AddWithValue("@s", soyadTextBox.Text);
                    cmd.Parameters.AddWithValue("@gt", date.ToShortDateString());
                    cmd.Parameters.AddWithValue("@gs", date.ToShortTimeString());
                    cmd.Parameters.AddWithValue("@id", misafirID);
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    if (_dil == 'T')
                        MessageBox.Show("Giris Basarili");
                    else
                        MessageBox.Show("Log IN Successful");

                    misafirPanel.Visible = false;

                    this.Size = new Size(428, 358); panel.Visible = true;
                }
            }
            else
            {
                if(_dil == 'T')
                MessageBox.Show("Bilgilerinizi giriniz!");
                else
                    MessageBox.Show("Please enter your information!");
            }
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            this.Size = new Size(304, 340);
            misafirPanel.Visible = true;
        }

        private void misafirComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (misafirComboBox.Text == "Ogun Sec")
            {
                yaGroupBox.Size = new Size(406, 254);
                aksamCheckBox.Location = new Point(155, 139);
                ogleCheckBox.Location = new Point(155, 114);
                kahvCheckBox.Location = new Point(155, 86);
                tarih.Location = new Point(155, 187);
                tarihLabel.Location = new Point(107, 192);
                yaGroupBox.Visible = true;
                gecisGroupBox.Visible = false;
            }

            if (misafirComboBox.Text == "Gecis Bilgileri")
            {
                gecisGroupBox.Location = new Point(2, 43);
                gecisGroupBox.Size = new Size(405, 254);
                dataGridView1.Location = new Point(6, 88);
                dataGridView1.Size = new Size(393, 160);
                gecisGroupBox.Visible = true;
                yaGroupBox.Visible = false;
            }
        }

        private void gosterButton_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.ToLocalTime();
            DateTime dtarihinden = Convert.ToDateTime(tarihinden.Text);
            DateTime dtarihine = Convert.ToDateTime(tarihine.Text);
            int tden = Convert.ToInt32(dtarihinden.Day);
            int tye = Convert.ToInt32(dtarihine.Day);
            int fark = tye - tden;
            connection.Open();
            for (int i = 0; i <= fark; i++)
            {                
                string kayit = "SELECT * FROM MISAFIRYEMEK WHERE TC=@id and Tarih=@t ";
                SqlCommand cmd = new SqlCommand(kayit,connection);
                cmd.Parameters.AddWithValue("@id", tcTextBox.Text);
                cmd.Parameters.AddWithValue("@t", dtarihinden.AddDays(i));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                da.Fill(dtable);
                dataGridView1.DataSource = dtable;                
            }
            connection.Close();
        }
        

        private void ekleButton_Click(object sender, EventArgs e)
        {
            if (kahvCheckBox.Checked == false && ogleCheckBox.Checked == false && aksamCheckBox.Checked == false)
            {
                if(_dil == 'T')
                MessageBox.Show("Bir secim yapmaniz gerekmektedir...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("You need to chose something...", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime dt = DateTime.Now.ToLocalTime();
                DateTime dtarih = Convert.ToDateTime(tarih.Text);
                int tden = Convert.ToInt32(dtarih.Day);
                
                string kahvalti = kahvCheckBox.Checked ? "Alindi" : "Alinmadi";
                string ogleYemegi = ogleCheckBox.Checked ? "Alindi" : "Alinmadi";
                string aksamYemegi = aksamCheckBox.Checked ? "Alindi" : "Alinmadi";

                yemek++;
                SqlCommand cmd = new SqlCommand(@"INSERT INTO MISAFIRYEMEK (MYemekID,Kahvalti,OgleYemegi,
                                           AksamYemegi,Tarih,Saat,TC) 
                VALUES (@yID,@k,@o,@a,@t,@s,@TC)", connection);
                cmd.Parameters.AddWithValue("@yID", yemek);
                cmd.Parameters.AddWithValue("@k", kahvalti);
                cmd.Parameters.AddWithValue("@o", ogleYemegi);
                cmd.Parameters.AddWithValue("@a", aksamYemegi);
                cmd.Parameters.AddWithValue("@t", dtarih.ToShortDateString());
                cmd.Parameters.AddWithValue("@s", dt.ToLongTimeString());
                cmd.Parameters.AddWithValue("@TC", tcTextBox.Text);

                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                if(_dil == 'T')
                MessageBox.Show("\r\tIslem Basrili  ");
                else
                    MessageBox.Show("\r\tProcessing Successful  ");
            }            
        }
        private void DiliDegistir()
        {
            if(_dil=='E')
            {
                tcKimlikLabel.Text = "TC Number :";tcKimlikLabel.Location = new Point(56, 210);
                adLabel.Text = "First Name :"; adLabel.Location = new Point(60, 231);
                label1.Text = "Last Name :"; label1.Location = new Point(60, 254);
                yaGroupBox.Text = "Chose the meal";
                geriButton.Text = "BACK";
                girisButton.Text = "LOG IN";
                aksamCheckBox.Text = "Dinner - 5.25 TL";
                ogleCheckBox.Text = "Lunch - 4.25 TL";
                kahvCheckBox.Text = "Dinner - 3.50 TL";
                tarihindenGecLabel.Text = "From -"; tarihindenGecLabel.Location = new Point(28, 24);
                tarihineGecLabel.Text = "To -"; tarihineGecLabel.Location = new Point(44, 56);
                tarihLabel.Text = "Date";
                gecisGroupBox.Text = "Toggle Information";
                ekleButton.Text = "Add";
                cikisButton.Text = "Log Out";
                gosterButton.Text = "SHOW";
                secimLabel.Text = "Sign Election";
            }
            else
            {
                tcKimlikLabel.Text = "TC Kimlik Numarasi: "; tcKimlikLabel.Location = new Point(8, 209);
                adLabel.Text = "Ad :";adLabel.Location = new Point(108, 234);
                label1.Text = "Soyad :"; label1.Location = new Point(85, 256);
                geriButton.Text = "GERI";
                girisButton.Text = "GIRIS";
                tarihindenGecLabel.Text = "Tarihinden -"; tarihindenGecLabel.Location = new Point(0, 21);
                tarihineGecLabel.Text = "Tarihine -"; tarihineGecLabel.Location = new Point(11, 56);
                aksamCheckBox.Text = "Aksam Yemegi - 5.25 TL";
                ogleCheckBox.Text = "Ogle Yemegi - 4.25 TL";
                kahvCheckBox.Text = "Kahvalti - 3.50 TL";
                tarihLabel.Text = "Tarih";
                ekleButton.Text = "Ekle";
                yaGroupBox.Text = "Almak istediginiz ogunleri isaretleyiniz :";
                cikisButton.Text = "Cikis";
                gosterButton.Text = "GOSTER";
                secimLabel.Text = "Secim Yapiniz :";
            }
        }
    } 
}
