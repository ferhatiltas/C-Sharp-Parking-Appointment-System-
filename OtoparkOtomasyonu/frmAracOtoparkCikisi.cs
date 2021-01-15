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
    public partial class frmAracOtoparkCikisi : Form
    {
        public frmAracOtoparkCikisi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ferlatiltas;Initial Catalog=arac_otopark;Integrated Security=True");

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAracOtoparkCikisi_Load(object sender, EventArgs e)
        {
            DoluYerler();

            Plakalar();
            timer1.Enabled = true;
        }

        private void Plakalar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from arac_otopark_kaydi", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboPlaka.Items.Add(read["plaka"].ToString());
            }
            baglanti.Close();
        }

        private void DoluYerler()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from arac_durumu where durumu ='DOLU'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboParkYeri.Items.Add(read["parkyeri"].ToString());
            }
            baglanti.Close();
        }

        private void comboPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from arac_otopark_kaydi where plaka ='"+comboPlaka.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtParkYeri.Text=read["parkyeri"].ToString();
            }
            baglanti.Close();
        }

        private void comboParkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from arac_otopark_kaydi where parkyeri ='" + comboParkYeri.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtParkYeri2.Text = read["parkyeri"].ToString();
                txtTc.Text = read["tc"].ToString();
                txtAd.Text = read["ad"].ToString();
                txtSoyad.Text = read["soyad"].ToString();
                txtSeri.Text = read["seri"].ToString();
                txtpPlaka.Text = read["plaka"].ToString();
                txtMarka.Text = read["marka"].ToString();
                lblGelisTarihi.Text = read["tarih"].ToString();

            }
            baglanti.Close();

            DateTime gelis, cikis;
            TimeSpan fark;
            gelis = DateTime.Parse(lblGelisTarihi.Text);
            cikis = DateTime.Parse(lblCikisTarihi.Text);
            fark = cikis - gelis;
            lblSure.Text = fark.TotalHours.ToString("0.00");
            lblToplamUcret.Text = (double.Parse(lblSure.Text)*0.75).ToString("0.0"); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCikisTarihi.Text = DateTime.Now.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete  from arac_otopark_kaydi where plaka='"+txtpPlaka.Text+"'",baglanti);
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("update arac_durumu set durumu = 'BOŞ' where parkyeri='" + txtParkYeri2.Text + "'", baglanti);
            komut2.ExecuteNonQuery();

            SqlCommand komu3 = new SqlCommand("insert into satis(parkyeri,plaka,gelis_tarihi,cikis_tarihi,sure,tutar) values(@parkyeri,@plaka,@gelis_tarihi,@cikis_tarihi,@sure,@tutar)", baglanti);
            komu3.Parameters.AddWithValue("@parkyeri",txtParkYeri2.Text);
            komu3.Parameters.AddWithValue("@plaka",txtpPlaka.Text);
            komu3.Parameters.AddWithValue("@gelis_tarihi",lblGelisTarihi.Text);
            komu3.Parameters.AddWithValue("@cikis_tarihi",lblCikisTarihi.Text);
            komu3.Parameters.AddWithValue("@sure",double.Parse(lblSure.Text));
            komu3.Parameters.AddWithValue("@tutar",double.Parse(lblToplamUcret.Text));
            komu3.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Araç çıkışı yapıldı.");
            foreach(Control item in groupControl2.Controls)
            {
                if(item is DevExpress.XtraEditors.TextEdit)
                {
                    item.Text = "";
                    comboParkYeri.Text = "";
                    txtParkYeri.Text = "";
                    comboPlaka.Text = "";
                }

            }

            comboPlaka.Items.Clear();
            comboParkYeri.Items.Clear();
            DoluYerler();
            Plakalar();
        }

        private void lblSure_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
