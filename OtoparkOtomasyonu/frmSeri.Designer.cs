namespace OtoparkOtomasyonu
{
    partial class Seri
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
            this.simpleButtonSeri = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditseri = new DevExpress.XtraEditors.TextEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEditseri.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonSeri
            // 
            this.simpleButtonSeri.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonSeri.Appearance.Options.UseFont = true;
            this.simpleButtonSeri.Location = new System.Drawing.Point(205, 120);
            this.simpleButtonSeri.Name = "simpleButtonSeri";
            this.simpleButtonSeri.Size = new System.Drawing.Size(94, 29);
            this.simpleButtonSeri.TabIndex = 8;
            this.simpleButtonSeri.Text = "Ekle";
            this.simpleButtonSeri.Click += new System.EventHandler(this.simpleButtonSeri_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(103, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 17);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Seri :";
            // 
            // textEditseri
            // 
            this.textEditseri.Location = new System.Drawing.Point(154, 80);
            this.textEditseri.Name = "textEditseri";
            this.textEditseri.Size = new System.Drawing.Size(145, 22);
            this.textEditseri.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(85, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 17);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Marka :";
            // 
            // Seri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(406, 223);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.simpleButtonSeri);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditseri);
            this.Name = "Seri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSeri";
            this.Load += new System.EventHandler(this.frmSeri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditseri.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonSeri;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditseri;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}