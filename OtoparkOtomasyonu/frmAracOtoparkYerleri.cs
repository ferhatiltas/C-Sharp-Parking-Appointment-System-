using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtoparkOtomasyonu
{
    public partial class frmAracOtoparkYerleri : Form
    {
        public frmAracOtoparkYerleri()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=ferlatiltas;Initial Catalog=arac_otopark;Integrated Security=True");
        private void frmAracOtoparkYerleri_Load(object sender, EventArgs e)
        {
            BosParkYerleri();
            DoluParkYerleri();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from arac_otopark_kaydi", baglanti);

            SqlDataReader read = komut.ExecuteReader();

            while (read.Read()) 
            {
                foreach (Control item in Controls) 
                {
                    if (item is DevExpress.XtraEditors.SimpleButton) 
                    {
                        if (item.Text == read["parkyeri"].ToString())
                        {
                            item.Text = read["plaka"].ToString();
                        }
                    }
                }
            }

            baglanti.Close();
        }

        private void DoluParkYerleri()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select *from arac_durumu", baglanti);


            SqlDataReader read = komut.ExecuteReader();

            while (read.Read()) // veriler okunduğu sürece
            {
                foreach (Control item in Controls) // Kontrolleri dolaş
                {
                    if (item is DevExpress.XtraEditors.SimpleButton) // Dolaşılan kontroller SimpleButton ise
                    {
                        if (item.Text == read["parkyeri"].ToString() && read["durumu"].ToString() == "DOLU")
                        { // Veri tabanındaki parkyeri eşit ise simpleButtonun ismine ve durumu DOLU ise
                            item.ForeColor = Color.Red; // simpleButtonun kırmızı yapsın
                        }
                        else if (item.Text == read["parkyeri"].ToString() && read["durumu"].ToString() == "BOŞ")
                        {
                            item.ForeColor = Color.Green;
                        }
                    }
                }
            }

            baglanti.Close();
        }

        private void BosParkYerleri()
        {
            int sayac = 1;
            foreach (Control item in Controls) // Kontrolleri dolaşsın SimpleButtonları bulacağız
                
            {
                
                 if (item is DevExpress.XtraEditors.SimpleButton)// Park yerlerinin simpleButton isimlerini buradan atadım
                {
                    item.Text = "P-" + sayac;
                    item.Name = "P-" + sayac;
                    sayac++;
                }
                simpleButton1.Text = "Geri";
            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {

        }
    }
}
