using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proje1._1
{

    public partial class Form1 : Form
    {
        static Random random = new Random(DateTime.Now.Millisecond);
        int general_total = 0;
        int general_birthdays = 0;
        double general_average = 0;
        float males = 0;
        float females = 0;

        int[][] matrix_e = new int[24][];
        int[][] matrix_k = new int[24][];
        string[] aylar = { "OCAK", "SUBAT", "MART", "NISAN", "MAYIS", "HAZIRAN", "TEMUZ", 
                             "AGUSTOS", "EYLUL", "EKIM", "KASIM", "ARALIK","OCAK", 
                             "SUBAT", "MART", "NISAN", "MAYIS", "HAZIRAN", "TEMUZ", 
                             "AGUSTOS", "EYLUL", "EKIM", "KASIM", "ARALIK" };

        public Form1()
        {
            
            InitializeComponent();
            listView1.BackColor = Color.Lavender;
            listView1.GridLines = true;
            label4.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 7; i++)
            {
                if (i == 1)
                {
                    matrix_e[i] = new int[28];
                    matrix_k[i] = new int[28];
                    continue;
                }
                if (i == 0)
                {
                    matrix_e[i] = new int[31];
                    matrix_k[i] = new int[31];
                    continue;
                }

                if (i % 2 == 0)
                {
                    matrix_e[i] = new int[31];
                    matrix_k[i] = new int[31];
                }
                else
                {
                    matrix_e[i] = new int[30];
                    matrix_k[i] = new int[30];
                }
            }

            for (int i = 7; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    matrix_e[i] = new int[30];
                    matrix_k[i] = new int[30];
                }
                else
                {
                    matrix_e[i] = new int[31];
                    matrix_k[i] = new int[31];
                }
            }

            for (int i = 11; i < 18; i++)
            {
                if (i == 12)
                {
                    matrix_e[i] = new int[28];
                    matrix_k[i] = new int[28];
                    continue;
                }
                if (i == 11)
                {
                    matrix_e[i] = new int[31];
                    matrix_k[i] = new int[31];
                    continue;
                }

                if (i % 2 == 0)
                {
                    matrix_e[i] = new int[31];
                    matrix_k[i] = new int[31];
                }
                else
                {
                    matrix_e[i] = new int[30];
                    matrix_k[i] = new int[30];
                }
            }

            for (int i = 18; i < 24; i++)
            {
                if (i % 2 == 0)
                {
                    matrix_e[i] = new int[30];
                    matrix_k[i] = new int[30];
                }
                else
                {
                    matrix_e[i] = new int[31];
                    matrix_k[i] = new int[31];
                }
            }
        }

        private void ButtonStartClick(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int total = 0;
            if (String.IsNullOrEmpty(textBoxBirthday.Text))
            {
                MessageBox.Show("Missing No. Of Birthdays", "Randomize Birthday", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else if (String.IsNullOrEmpty(textBoxSeries.Text))
            {
                MessageBox.Show("Missing No. Of Series", "Randomize Birthday", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                label4.Visible = true;
                int birthdays = Convert.ToInt16(textBoxBirthday.Text);
                int series = Convert.ToInt16(textBoxSeries.Text);
                
                for (int i = 0; i < series; ++i)
                {
                    Randomize(matrix_k, matrix_e, random, birthdays, series, aylar);
                    total += match(matrix_k, matrix_e);
                    cls(matrix_k);
                    cls(matrix_e);
                }
                males = (float)(series * birthdays) * 0.75f;
                females = (float)(series * birthdays) * 0.25f;
                
                general_total += total;
                general_birthdays += birthdays * series;
                general_average = ((double)general_total / (double)general_birthdays) * 100;

                labelM.Text = total.ToString();
                labelMatches.Text = general_total.ToString();
                labelBirthdays.Text = general_birthdays.ToString();
                labelAverages.Text = Convert.ToString(String.Format("{0:0.00}", general_average));

                total = 0;
                cls(matrix_e);
                cls(matrix_k);

            }
        }
     public void Randomize(int [][] matrix_k,int[][] matrix_e, Random random,
            int birthdays,int series,string [] aylar)
        {
            int erkek_sayac = 0;
            int kiz_sayac = 0;

            for (int i = 0; i < birthdays; i++)
            {
                int a = (int)random.Next(24);
                int g = (int)random.Next(matrix_e[a].GetLength(0));

                string cinsiyet = "";
                float kiz;
                int k;
                float erkek;
                int e;
                int test = 0;


                kiz = birthdays * 0.25f;
                erkek = (birthdays * 0.75f);

                k = (int)kiz;
                e = (int)erkek;

                int ek = ((int)random.Next(2));

                if (ek == 0 && kiz_sayac != k)
                {
                    matrix_k[a][g]++;
                    kiz_sayac++;
                    cinsiyet = "KIZ";
                    test = 1;
                }
                else
                {
                    ek = 1;
                }

                if (ek == 1 && erkek_sayac != e)
                {
                    matrix_e[a][g]++;
                    erkek_sayac++;
                    cinsiyet = "ERKEK";

                }
                else
                {
                    ek = 0;
                    if (test == 0)
                    {
                        matrix_k[a][g]++;
                        kiz_sayac++;
                        cinsiyet = "KIZ";
                    }
                }
                g = g + 1;
                int yil;
                if (a > 11)
                    yil = 1997;
                else
                    yil = 1996;

                string[] rows = { g.ToString(), aylar[a], yil.ToString(), cinsiyet };
                
                var list = new ListViewItem(rows);
                foreach (ListViewItem item in listView1.Items)
                {
                    item.BackColor = item.Index % 2 == 0 ? Color.Gold : Color.ForestGreen;
                }
                listView1.Items.Add(list);
            }           
        }

        public int match(int[][] matrixWoman, int[][] matrixMan)
        {
            int mat = 0,mat2 = 0;
            for (int i = 0; i < 24; i++)
                for (int j = 0; j < matrixWoman[i].GetLength(0); j++)
                    if (matrixWoman[i][j] > 1)
                        mat += (matrixWoman[i][j] - 1);

            for (int i = 0; i < 24; i++)
                for (int j = 0; j < matrixMan[i].GetLength(0); j++)
                    if (matrixMan[i][j] > 1)
                        mat2 += (matrixMan[i][j] - 1);

            return mat+mat2;
        }

        public void cls(int[][] m)
        {
            for (int i = 0; i < 24; i++)
                for (int j = 0; j < m[i].GetLength(0); j++)
                    m[i][j] = 0;
        }

        private void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.ShowDialog();
        }

        private void ButtonRessetClick(object sender, EventArgs e)
        {
            labelM.Text = "0";
            listView1.Items.Clear();
            labelMatches.Text = "0";
            labelAverages.Text = "0.0";
            labelBirthdays.Text = "0";
            general_total = 0;
            general_birthdays = 0;
            general_average = 0;
            textBoxBirthday.Clear();
            textBoxSeries.Clear();
            label4.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
