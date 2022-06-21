namespace Arheolog
{
    partial class AntikvitetInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AntikvitetInfo));
            this.btnZatvori = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLokalitet = new System.Windows.Forms.Label();
            this.lblTipAnt = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblDatPron = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnBrisanjeAntikviteta = new System.Windows.Forms.Button();
            this.btnDodavanjeUC = new System.Windows.Forms.Button();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.tbDatPronal = new System.Windows.Forms.TextBox();
            this.tbPeriod = new System.Windows.Forms.TextBox();
            this.tbTipAntikv = new System.Windows.Forms.TextBox();
            this.tbLokalitet = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.lblImgName = new System.Windows.Forms.Label();
            this.tbImgNaziv = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.Transparent;
            this.btnZatvori.FlatAppearance.BorderSize = 0;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnZatvori.Location = new System.Drawing.Point(519, -1);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(24, 29);
            this.btnZatvori.TabIndex = 12;
            this.btnZatvori.Text = "X";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnZatvori);
            this.panel1.Controls.Add(this.pbImg);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 290);
            this.panel1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 52);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.lblInfo.Location = new System.Drawing.Point(11, 17);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(261, 23);
            this.lblInfo.TabIndex = 105;
            this.lblInfo.Tag = "Info";
            this.lblInfo.Text = "INFO infi ifififif fififif fifififf fififfiff ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblImgName);
            this.groupBox2.Controls.Add(this.tbImgNaziv);
            this.groupBox2.Controls.Add(this.lblLokalitet);
            this.groupBox2.Controls.Add(this.lblTipAnt);
            this.groupBox2.Controls.Add(this.lblPeriod);
            this.groupBox2.Controls.Add(this.lblDatPron);
            this.groupBox2.Controls.Add(this.lblNaziv);
            this.groupBox2.Controls.Add(this.btnBrisanjeAntikviteta);
            this.groupBox2.Controls.Add(this.btnDodavanjeUC);
            this.groupBox2.Controls.Add(this.tbDatPronal);
            this.groupBox2.Controls.Add(this.tbPeriod);
            this.groupBox2.Controls.Add(this.tbTipAntikv);
            this.groupBox2.Controls.Add(this.tbLokalitet);
            this.groupBox2.Controls.Add(this.tbNaziv);
            this.groupBox2.Location = new System.Drawing.Point(11, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 171);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            // 
            // lblLokalitet
            // 
            this.lblLokalitet.AutoSize = true;
            this.lblLokalitet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokalitet.Location = new System.Drawing.Point(206, 77);
            this.lblLokalitet.Name = "lblLokalitet";
            this.lblLokalitet.Size = new System.Drawing.Size(55, 14);
            this.lblLokalitet.TabIndex = 117;
            this.lblLokalitet.Text = "Lokalitet";
            // 
            // lblTipAnt
            // 
            this.lblTipAnt.AutoSize = true;
            this.lblTipAnt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipAnt.Location = new System.Drawing.Point(34, 76);
            this.lblTipAnt.Name = "lblTipAnt";
            this.lblTipAnt.Size = new System.Drawing.Size(85, 14);
            this.lblTipAnt.TabIndex = 116;
            this.lblTipAnt.Text = "Tip antikviteta";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(397, 20);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(42, 14);
            this.lblPeriod.TabIndex = 115;
            this.lblPeriod.Text = "Period";
            // 
            // lblDatPron
            // 
            this.lblDatPron.AutoSize = true;
            this.lblDatPron.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatPron.Location = new System.Drawing.Point(206, 17);
            this.lblDatPron.Name = "lblDatPron";
            this.lblDatPron.Size = new System.Drawing.Size(108, 14);
            this.lblDatPron.TabIndex = 114;
            this.lblDatPron.Text = "Datum pronalaska";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(36, 17);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(97, 14);
            this.lblNaziv.TabIndex = 113;
            this.lblNaziv.Text = "Naziv antikviteta";
            // 
            // btnBrisanjeAntikviteta
            // 
            this.btnBrisanjeAntikviteta.BackColor = System.Drawing.Color.Maroon;
            this.btnBrisanjeAntikviteta.FlatAppearance.BorderSize = 0;
            this.btnBrisanjeAntikviteta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisanjeAntikviteta.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisanjeAntikviteta.ForeColor = System.Drawing.Color.White;
            this.btnBrisanjeAntikviteta.Location = new System.Drawing.Point(436, 140);
            this.btnBrisanjeAntikviteta.Name = "btnBrisanjeAntikviteta";
            this.btnBrisanjeAntikviteta.Size = new System.Drawing.Size(80, 25);
            this.btnBrisanjeAntikviteta.TabIndex = 112;
            this.btnBrisanjeAntikviteta.Text = "Delete";
            this.btnBrisanjeAntikviteta.UseVisualStyleBackColor = false;
            this.btnBrisanjeAntikviteta.Click += new System.EventHandler(this.btnBrisanjeAntikviteta_Click);
            // 
            // btnDodavanjeUC
            // 
            this.btnDodavanjeUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnDodavanjeUC.FlatAppearance.BorderSize = 0;
            this.btnDodavanjeUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodavanjeUC.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodavanjeUC.ForeColor = System.Drawing.Color.White;
            this.btnDodavanjeUC.Location = new System.Drawing.Point(315, 140);
            this.btnDodavanjeUC.Name = "btnDodavanjeUC";
            this.btnDodavanjeUC.Size = new System.Drawing.Size(115, 25);
            this.btnDodavanjeUC.TabIndex = 111;
            this.btnDodavanjeUC.Text = "Dodaj antikvitet";
            this.btnDodavanjeUC.UseVisualStyleBackColor = false;
            this.btnDodavanjeUC.Click += new System.EventHandler(this.btnDodavanjeUC_Click);
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbImg.Location = new System.Drawing.Point(429, 19);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(80, 80);
            this.pbImg.TabIndex = 110;
            this.pbImg.TabStop = false;
            // 
            // tbDatPronal
            // 
            this.tbDatPronal.Location = new System.Drawing.Point(209, 38);
            this.tbDatPronal.Name = "tbDatPronal";
            this.tbDatPronal.Size = new System.Drawing.Size(100, 20);
            this.tbDatPronal.TabIndex = 109;
            // 
            // tbPeriod
            // 
            this.tbPeriod.Location = new System.Drawing.Point(398, 38);
            this.tbPeriod.Name = "tbPeriod";
            this.tbPeriod.Size = new System.Drawing.Size(100, 20);
            this.tbPeriod.TabIndex = 108;
            // 
            // tbTipAntikv
            // 
            this.tbTipAntikv.Location = new System.Drawing.Point(37, 96);
            this.tbTipAntikv.Name = "tbTipAntikv";
            this.tbTipAntikv.Size = new System.Drawing.Size(100, 20);
            this.tbTipAntikv.TabIndex = 107;
            // 
            // tbLokalitet
            // 
            this.tbLokalitet.Location = new System.Drawing.Point(209, 96);
            this.tbLokalitet.Name = "tbLokalitet";
            this.tbLokalitet.Size = new System.Drawing.Size(100, 20);
            this.tbLokalitet.TabIndex = 106;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(37, 38);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(100, 20);
            this.tbNaziv.TabIndex = 105;
            this.tbNaziv.Tag = "Naziv antikviteta";
            // 
            // lblImgName
            // 
            this.lblImgName.AutoSize = true;
            this.lblImgName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImgName.Location = new System.Drawing.Point(395, 77);
            this.lblImgName.Name = "lblImgName";
            this.lblImgName.Size = new System.Drawing.Size(34, 14);
            this.lblImgName.TabIndex = 119;
            this.lblImgName.Text = "Slika";
            // 
            // tbImgNaziv
            // 
            this.tbImgNaziv.Location = new System.Drawing.Point(398, 96);
            this.tbImgNaziv.Name = "tbImgNaziv";
            this.tbImgNaziv.Size = new System.Drawing.Size(100, 20);
            this.tbImgNaziv.TabIndex = 118;
            // 
            // AntikvitetInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 290);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AntikvitetInfo";
            this.Text = "AntikvitetInfo";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLokalitet;
        private System.Windows.Forms.Label lblTipAnt;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblDatPron;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnBrisanjeAntikviteta;
        private System.Windows.Forms.Button btnDodavanjeUC;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.TextBox tbDatPronal;
        private System.Windows.Forms.TextBox tbPeriod;
        private System.Windows.Forms.TextBox tbTipAntikv;
        private System.Windows.Forms.TextBox tbLokalitet;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label lblImgName;
        private System.Windows.Forms.TextBox tbImgNaziv;
    }
}