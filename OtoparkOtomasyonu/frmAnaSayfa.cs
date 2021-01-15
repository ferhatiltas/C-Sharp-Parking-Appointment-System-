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
            panelAnaSayfa.Controls.Clear();
            frmAracOtoparkCikisi cikis = new frmAracOtoparkCikisi();
            cikis.TopLevel = false;


            panelAnaSayfa.Controls.Add(cikis);
            cikis.Show();
            cikis.Dock = DockStyle.Fill;
            cikis.BringToFront();
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
             


            panelAnaSayfa.Controls.Clear();
            frmAracOtoparkKaydi kayit = new frmAracOtoparkKaydi();
            kayit.TopLevel = false;

           
            panelAnaSayfa.Controls.Add(kayit);
            kayit.Show();
            kayit.Dock = DockStyle.Fill;
            kayit.BringToFront();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            panelAnaSayfa.Controls.Clear();
            frmAracOtoparkYerleri yer = new frmAracOtoparkYerleri();
            yer.TopLevel = false;


            panelAnaSayfa.Controls.Add(yer);
            yer.Show();
            yer.Dock = DockStyle.Fill;
            yer.BringToFront();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void satisListelemeSayfasi_Click(object sender, EventArgs e)
        {
            panelAnaSayfa.Controls.Clear();
            frmSatis satiss = new frmSatis();
            satiss.TopLevel = false;


            panelAnaSayfa.Controls.Add(satiss);
            satiss.Show();
            satiss.Dock = DockStyle.Fill;
            satiss.BringToFront();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelAna_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
