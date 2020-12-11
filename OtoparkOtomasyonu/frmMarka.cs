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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ferlatiltas;Initial Catalog=arac_otopark;Integrated Security=True");

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();    
            SqlCommand komut = new SqlCommand("insert into marka_bilgii(marka) values('" + textEdit1.Text + "')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Marka Eklendi");
            textEdit1.Text = "";
        }

        private void frmMarka_Load(object sender, EventArgs e)
        {

        }
    }
}
