using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu
{
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ferlatiltas;Initial Catalog=arac_otopark;Integrated Security=True");
        DataSet daset = new DataSet();
        private void frmSatis_Load(object sender, EventArgs e)
        {
            SatislariListele();

            TutarHesapla();

        }

        private void TutarHesapla()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(tutar) from satis", baglanti);
            labelControl1.Text = "Toplam Tutar : " + komut.ExecuteScalar() + " TL";
            baglanti.Close();
        }

        private void SatislariListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satis ", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];
            baglanti.Close();
        }
    }
}
