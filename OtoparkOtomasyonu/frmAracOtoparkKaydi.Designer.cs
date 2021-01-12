using System;
using System.Windows.Forms;

namespace OtoparkOtomasyonu
{
    partial class frmAracOtoparkKaydi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTc = new DevExpress.XtraEditors.TextEdit();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtPlaka = new DevExpress.XtraEditors.TextEdit();
            this.txtRenk = new DevExpress.XtraEditors.TextEdit();
            this.grupKişi = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTcs = new DevExpress.XtraEditors.LabelControl();
            this.grupAraç = new DevExpress.XtraEditors.GroupControl();
            this.btnSeri = new DevExpress.XtraEditors.SimpleButton();
            this.btnMarka = new DevExpress.XtraEditors.SimpleButton();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.comboSeri = new System.Windows.Forms.ComboBox();
            this.comboParkYeri = new System.Windows.Forms.ComboBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkyeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracotoparkkaydiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracotoparkDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arac_otoparkDataSet1 = new OtoparkOtomasyonu.arac_otoparkDataSet1();
            this.arac_otoparkDataSet2 = new OtoparkOtomasyonu.arac_otoparkDataSet2();
            this.aracotoparkDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arac_otopark_kaydiTableAdapter = new OtoparkOtomasyonu.arac_otoparkDataSet1TableAdapters.arac_otopark_kaydiTableAdapter();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupKişi)).BeginInit();
            this.grupKişi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupAraç)).BeginInit();
            this.grupAraç.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracotoparkkaydiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracotoparkDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arac_otoparkDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arac_otoparkDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracotoparkDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(150, 51);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(125, 22);
            this.txtTc.TabIndex = 0;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(150, 100);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(125, 22);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(150, 149);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(125, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(150, 198);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(125, 22);
            this.txtTelefon.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 247);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(125, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(135, 47);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(125, 22);
            this.txtPlaka.TabIndex = 5;
            this.txtPlaka.EditValueChanged += new System.EventHandler(this.textEdit6_EditValueChanged);
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(135, 204);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(125, 22);
            this.txtRenk.TabIndex = 6;
            // 
            // grupKişi
            // 
            this.grupKişi.Controls.Add(this.labelControl5);
            this.grupKişi.Controls.Add(this.txtSoyad);
            this.grupKişi.Controls.Add(this.labelControl4);
            this.grupKişi.Controls.Add(this.txtTc);
            this.grupKişi.Controls.Add(this.labelControl3);
            this.grupKişi.Controls.Add(this.labelControl2);
            this.grupKişi.Controls.Add(this.txtAd);
            this.grupKişi.Controls.Add(this.txtTcs);
            this.grupKişi.Controls.Add(this.txtTelefon);
            this.grupKişi.Controls.Add(this.txtEmail);
            this.grupKişi.Location = new System.Drawing.Point(12, 12);
            this.grupKişi.Name = "grupKişi";
            this.grupKişi.Size = new System.Drawing.Size(383, 309);
            this.grupKişi.TabIndex = 10;
            this.grupKişi.Text = "Kişi Bilgileri";
            this.grupKişi.Paint += new System.Windows.Forms.PaintEventHandler(this.grupKişi_Paint);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(74, 251);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 17);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "E-posta :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(74, 201);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 17);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Telefon :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(73, 151);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 17);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Soyisim :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(93, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 17);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "İsim :";
            // 
            // txtTcs
            // 
            this.txtTcs.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcs.Appearance.Options.UseFont = true;
            this.txtTcs.Location = new System.Drawing.Point(101, 51);
            this.txtTcs.Name = "txtTcs";
            this.txtTcs.Size = new System.Drawing.Size(26, 17);
            this.txtTcs.TabIndex = 10;
            this.txtTcs.Text = "TC :";
            this.txtTcs.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // grupAraç
            // 
            this.grupAraç.Controls.Add(this.btnSeri);
            this.grupAraç.Controls.Add(this.btnMarka);
            this.grupAraç.Controls.Add(this.comboMarka);
            this.grupAraç.Controls.Add(this.comboSeri);
            this.grupAraç.Controls.Add(this.comboParkYeri);
            this.grupAraç.Controls.Add(this.labelControl10);
            this.grupAraç.Controls.Add(this.labelControl9);
            this.grupAraç.Controls.Add(this.txtPlaka);
            this.grupAraç.Controls.Add(this.labelControl8);
            this.grupAraç.Controls.Add(this.labelControl7);
            this.grupAraç.Controls.Add(this.labelControl6);
            this.grupAraç.Controls.Add(this.txtRenk);
            this.grupAraç.Location = new System.Drawing.Point(447, 12);
            this.grupAraç.Name = "grupAraç";
            this.grupAraç.Size = new System.Drawing.Size(356, 309);
            this.grupAraç.TabIndex = 11;
            this.grupAraç.Text = "Araç Bilgileri";
            this.grupAraç.Paint += new System.Windows.Forms.PaintEventHandler(this.grupAraç_Paint);
            // 
            // btnSeri
            // 
            this.btnSeri.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeri.Appearance.Options.UseFont = true;
            this.btnSeri.Location = new System.Drawing.Point(266, 152);
            this.btnSeri.Name = "btnSeri";
            this.btnSeri.Size = new System.Drawing.Size(39, 24);
            this.btnSeri.TabIndex = 20;
            this.btnSeri.Text = "+";
            this.btnSeri.Click += new System.EventHandler(this.btnSeri_Click_1);
            // 
            // btnMarka
            // 
            this.btnMarka.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarka.Appearance.Options.UseFont = true;
            this.btnMarka.Location = new System.Drawing.Point(266, 99);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(39, 24);
            this.btnMarka.TabIndex = 19;
            this.btnMarka.Text = "+";
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(135, 98);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(125, 24);
            this.comboMarka.TabIndex = 18;
            this.comboMarka.SelectedIndexChanged += new System.EventHandler(this.comboMarka_SelectedIndexChanged);
            // 
            // comboSeri
            // 
            this.comboSeri.FormattingEnabled = true;
            this.comboSeri.Location = new System.Drawing.Point(135, 151);
            this.comboSeri.Name = "comboSeri";
            this.comboSeri.Size = new System.Drawing.Size(125, 24);
            this.comboSeri.TabIndex = 17;
            // 
            // comboParkYeri
            // 
            this.comboParkYeri.FormattingEnabled = true;
            this.comboParkYeri.Location = new System.Drawing.Point(135, 255);
            this.comboParkYeri.Name = "comboParkYeri";
            this.comboParkYeri.Size = new System.Drawing.Size(125, 24);
            this.comboParkYeri.TabIndex = 14;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(43, 263);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(65, 17);
            this.labelControl10.TabIndex = 16;
            this.labelControl10.Text = "Park Yeri :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(70, 209);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(38, 17);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "Renk :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(78, 155);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(30, 17);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Seri :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(62, 101);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 17);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Marka :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(68, 47);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 17);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Plaka :";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(14, 368);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(647, 368);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 29);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Text = "Geri";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataGridView1);
            this.groupControl1.Location = new System.Drawing.Point(12, 414);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(791, 154);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.seriDataGridViewTextBoxColumn,
            this.renkDataGridViewTextBoxColumn,
            this.parkyeriDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aracotoparkkaydiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(787, 127);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "tc";
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "plaka";
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // seriDataGridViewTextBoxColumn
            // 
            this.seriDataGridViewTextBoxColumn.DataPropertyName = "seri";
            this.seriDataGridViewTextBoxColumn.HeaderText = "seri";
            this.seriDataGridViewTextBoxColumn.Name = "seriDataGridViewTextBoxColumn";
            // 
            // renkDataGridViewTextBoxColumn
            // 
            this.renkDataGridViewTextBoxColumn.DataPropertyName = "renk";
            this.renkDataGridViewTextBoxColumn.HeaderText = "renk";
            this.renkDataGridViewTextBoxColumn.Name = "renkDataGridViewTextBoxColumn";
            // 
            // parkyeriDataGridViewTextBoxColumn
            // 
            this.parkyeriDataGridViewTextBoxColumn.DataPropertyName = "parkyeri";
            this.parkyeriDataGridViewTextBoxColumn.HeaderText = "parkyeri";
            this.parkyeriDataGridViewTextBoxColumn.Name = "parkyeriDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // aracotoparkkaydiBindingSource
            // 
            this.aracotoparkkaydiBindingSource.DataMember = "arac_otopark_kaydi";
            this.aracotoparkkaydiBindingSource.DataSource = this.aracotoparkDataSet1BindingSource;
            // 
            // aracotoparkDataSet1BindingSource
            // 
            this.aracotoparkDataSet1BindingSource.DataSource = this.arac_otoparkDataSet1;
            this.aracotoparkDataSet1BindingSource.Position = 0;
            // 
            // arac_otoparkDataSet1
            // 
            this.arac_otoparkDataSet1.DataSetName = "arac_otoparkDataSet1";
            this.arac_otoparkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // arac_otoparkDataSet2
            // 
            this.arac_otoparkDataSet2.DataSetName = "arac_otoparkDataSet2";
            this.arac_otoparkDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aracotoparkDataSet2BindingSource
            // 
            this.aracotoparkDataSet2BindingSource.DataSource = this.arac_otoparkDataSet2;
            this.aracotoparkDataSet2BindingSource.Position = 0;
            // 
            // arac_otopark_kaydiTableAdapter
            // 
            this.arac_otopark_kaydiTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.Location = new System.Drawing.Point(138, 368);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(94, 29);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Appearance.Options.UseFont = true;
            this.btnListele.Location = new System.Drawing.Point(405, 368);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(150, 29);
            this.btnListele.TabIndex = 16;
            this.btnListele.Text = "Kayıtları Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(250, 368);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(94, 29);
            this.simpleButton3.TabIndex = 17;
            this.simpleButton3.Text = "Sil";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 327);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(739, 19);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Güncelle ve Sil özelliklerini kullanabilmek için Kayıtlar kısmında istediğiniz hü" +
    "creye çift tıklayınız";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click_1);
            // 
            // frmAracOtoparkKaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(841, 575);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.grupAraç);
            this.Controls.Add(this.grupKişi);
            this.Name = "frmAracOtoparkKaydi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Otopark Kayıt Sayfası";
            this.Load += new System.EventHandler(this.frmAracOtoparkKaydi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupKişi)).EndInit();
            this.grupKişi.ResumeLayout(false);
            this.grupKişi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupAraç)).EndInit();
            this.grupAraç.ResumeLayout(false);
            this.grupAraç.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracotoparkkaydiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracotoparkDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arac_otoparkDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arac_otoparkDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracotoparkDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        private void labelControl6_Click(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void grupAraç_Paint(object sender, PaintEventArgs e)
        {
            //  throw new NotImplementedException();
          //  throw new NotImplementedException();

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
          //  throw new NotImplementedException();
        }

        private void grupKişi_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void textEdit6_EditValueChanged(object sender, EventArgs e)
        {
          //  throw new NotImplementedException();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTc;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtPlaka;
        private DevExpress.XtraEditors.TextEdit txtRenk;
        private DevExpress.XtraEditors.GroupControl grupKişi;
        private DevExpress.XtraEditors.GroupControl grupAraç;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl txtTcs;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private ComboBox comboParkYeri;
        private ComboBox comboMarka;
        private ComboBox comboSeri;
        private DevExpress.XtraEditors.SimpleButton btnSeri;
        private DevExpress.XtraEditors.SimpleButton btnMarka;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DataGridView dataGridView1;
        private BindingSource aracotoparkDataSet1BindingSource;
        private arac_otoparkDataSet1 arac_otoparkDataSet1;
        private BindingSource aracotoparkDataSet2BindingSource;
        private arac_otoparkDataSet2 arac_otoparkDataSet2;
        private BindingSource aracotoparkkaydiBindingSource;
        private arac_otoparkDataSet1TableAdapters.arac_otopark_kaydiTableAdapter arac_otopark_kaydiTableAdapter;
        private DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn seriDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn renkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn parkyeriDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}