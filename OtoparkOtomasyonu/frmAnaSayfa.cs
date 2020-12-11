using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmAracOtoparkCikisi cikis = new frmAracOtoparkCikisi();
            cikis.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmAracOtoparkKaydi kayit = new frmAracOtoparkKaydi();
            kayit.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmAracOtoparkYerleri yer = new frmAracOtoparkYerleri();
            yer.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void satisListelemeSayfasi_Click(object sender, EventArgs e)
        {
            frmSatis satis = new frmSatis();
            satis.ShowDialog();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
