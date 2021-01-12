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
    public partial class frmAracOtoparkKaydi : Form
    {
        public frmAracOtoparkKaydi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ferlatiltas;Initial Catalog=arac_otopark;Integrated Security=True");
        // Veri tabanımıza bağlanıyoruz

        private void frmAracOtoparkKaydi_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'arac_otoparkDataSet1.arac_otopark_kaydi' table. You can move, or remove it, as needed.
            this.arac_otopark_kaydiTableAdapter.Fill(this.arac_otoparkDataSet1.arac_otopark_kaydi);

            BosAraclar();

            Marka();

            
        }

        private void Marka()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka from marka_bilgii",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void BosAraclar()
        {
            baglanti.Open(); // Sql Connction açmazsak komutlar çalışmaz metottan sonra tekrar kapatmamız gerekiyor
            SqlCommand komut = new SqlCommand("select *from arac_durumu WHERE durumu = 'BOŞ' ", baglanti); // sorgu metodu
            SqlDataReader read = komut.ExecuteReader(); // veri tabanın okuma metodu
            while (read.Read()) // veriler okunduğu sürece
            {
                comboParkYeri.Items.Add(read["parkyeri"].ToString());
            }
            baglanti.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into arac_otopark_kaydi(tc,ad,soyad,telefon,email,plaka,marka,seri,renk,parkyeri,tarih) values(@tc,@ad,@soyad,@telefon,@email,@plaka,@marka,@seri,@renk,@parkyeri,@tarih)", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@marka", comboMarka.Text);
            komut.Parameters.AddWithValue("@seri", comboSeri.Text);
            komut.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@parkyeri", comboParkYeri.Text);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("update arac_durumu set durumu ='DOLU' WHERE parkyeri ='"+comboParkYeri.SelectedItem+"'",baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç kaydı başarıyla oluşturuldu. Listelemek için Kayıtları Listele butonuna tıklayınız.","Kayıt");
            comboParkYeri.Items.Clear();
            BosAraclar();
            comboMarka.Items.Clear();
            Marka();
            comboSeri.Items.Clear();

            foreach(Control item in grupKişi.Controls)
            {
                if(item is DevExpress.XtraEditors.TextEdit)
                {
                    item.Text = ""; // Kayıt butonuna basınca TextEdit içeriğini temizleyecez
                }
            }
            foreach (Control item in grupAraç.Controls)
            {
                if (item is DevExpress.XtraEditors.TextEdit)
                {
                    item.Text = ""; // Kayıt butonuna basınca TextEdit içeriğini temizleyecez
                }
            }
            foreach (Control item in grupAraç.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = ""; // Kayıt butonuna basınca ComboBox içeriğini temizleyecez
                }
            }
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            frmMarka marka =new  frmMarka();
            marka.ShowDialog();
        }
       

        private void btnSeri_Click_1(object sender, EventArgs e)
        {
            Seri seri = new Seri();
            seri.ShowDialog();
        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSeri.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka,seri from seri_bilgi where marka='"+comboMarka.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboSeri.Items.Add(read["seri"].ToString());
            }
            baglanti.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Herhangi bir hücreye tıklanıldığında bilgileri aktarıp güncelleme yapacağım

            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtTc.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
           
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.arac_otopark_kaydiTableAdapter.Fill(this.arac_otoparkDataSet1.arac_otopark_kaydi);

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutsil = new SqlCommand("Delete from arac_otopark_kaydi where tc=@tc1 ", baglanti);
            komutsil.Parameters.AddWithValue("@tc1", txtTc.Text);
            komutsil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayıt silindi. Kayıtları listelemek için Kayıtları Listele butonuna tıklayınız.");
        }

        private void labelControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutGuncelle = new SqlCommand("update arac_otopark_kaydi set ad=@a1,soyad=@a2,telefon=@a3,email=@a4 where tc=@a5", baglanti);
            komutGuncelle.Parameters.AddWithValue("@a1", txtAd.Text);
            komutGuncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@a3", txtTelefon.Text);
            komutGuncelle.Parameters.AddWithValue("@a4", txtEmail.Text);
            komutGuncelle.Parameters.AddWithValue("@a5", txtTc.Text);
            komutGuncelle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayıt güncellendi. Listelemek için Kayıtları Listele butonuna tıklayınız.");
        }
    }
}
