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
    public partial class Seri : Form
    {
        public Seri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ferlatiltas;Initial Catalog=arac_otopark;Integrated Security=True");

        private void frmSeri_Load(object sender, EventArgs e)
        {
            Marka();
        }

        private void Marka()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka from marka_bilgii", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void simpleButtonSeri_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into seri_bilgi(marka,seri) values('" + comboBox1.Text+"', '" + textEditseri.Text + "')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Markaya bağlı araç serisi eklendi.");
            textEditseri.Text = "";
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            Marka();
        }
    }
}
