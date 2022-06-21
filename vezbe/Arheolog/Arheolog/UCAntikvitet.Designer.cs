namespace Arheolog
{
    partial class UCAntikvitet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAntikvitet = new System.Windows.Forms.ListBox();
            this.pnltop = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDodavanjeUC = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbLokalitet = new System.Windows.Forms.ComboBox();
            this.cbTipAnt = new System.Windows.Forms.ComboBox();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            this.cbArheolozi = new System.Windows.Forms.ComboBox();
            this.pnltop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAntikvitet
            // 
            this.lbAntikvitet.BackColor = System.Drawing.SystemColors.Window;
            this.lbAntikvitet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAntikvitet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lbAntikvitet.FormattingEnabled = true;
            this.lbAntikvitet.ItemHeight = 19;
            this.lbAntikvitet.Location = new System.Drawing.Point(8, 73);
            this.lbAntikvitet.Name = "lbAntikvitet";
            this.lbAntikvitet.Size = new System.Drawing.Size(660, 270);
            this.lbAntikvitet.TabIndex = 90;
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.pnltop.Controls.Add(this.lbl);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(675, 59);
            this.pnltop.TabIndex = 75;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.lbl.Location = new System.Drawing.Point(273, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(171, 39);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Antikvitet";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.lbAntikvitet);
            this.panel1.Controls.Add(this.pnltop);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 605);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnDodavanjeUC);
            this.groupBox2.Controls.Add(this.btnBrisanje);
            this.groupBox2.Location = new System.Drawing.Point(363, 519);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 66);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(165)))), ((int)(((byte)(135)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(208, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 29);
            this.btnRefresh.TabIndex = 95;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDodavanjeUC
            // 
            this.btnDodavanjeUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnDodavanjeUC.FlatAppearance.BorderSize = 0;
            this.btnDodavanjeUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodavanjeUC.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodavanjeUC.ForeColor = System.Drawing.Color.White;
            this.btnDodavanjeUC.Location = new System.Drawing.Point(9, 19);
            this.btnDodavanjeUC.Name = "btnDodavanjeUC";
            this.btnDodavanjeUC.Size = new System.Drawing.Size(82, 29);
            this.btnDodavanjeUC.TabIndex = 93;
            this.btnDodavanjeUC.Text = "Dodavanje";
            this.btnDodavanjeUC.UseVisualStyleBackColor = false;
            this.btnDodavanjeUC.Click += new System.EventHandler(this.btnDodavanjeUC_Click);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.BackColor = System.Drawing.Color.Maroon;
            this.btnBrisanje.FlatAppearance.BorderSize = 0;
            this.btnBrisanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisanje.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisanje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBrisanje.Location = new System.Drawing.Point(110, 19);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(82, 29);
            this.btnBrisanje.TabIndex = 91;
            this.btnBrisanje.Text = "Brisanje";
            this.btnBrisanje.UseVisualStyleBackColor = false;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.cbLokalitet);
            this.groupBox1.Controls.Add(this.cbTipAnt);
            this.groupBox1.Controls.Add(this.cbPeriod);
            this.groupBox1.Controls.Add(this.cbArheolozi);
            this.groupBox1.Location = new System.Drawing.Point(7, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 135);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Strela",
            "Slika",
            "Novac",
            "Puške",
            "Statua",
            "Fosili",
            "Sarkofag",
            "Viljuška",
            "Vaza",
            "Mač",
            "Kostur dinosaurusa",
            "Čekić",
            "Knjiga",
            "Kruna",
            "Ogrlica",
            "Prsten",
            "Štit",
            "Knjiga1",
            "Knjiga2",
            "Knjiga3"});
            this.comboBox1.Location = new System.Drawing.Point(17, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 26);
            this.comboBox1.TabIndex = 106;
            this.comboBox1.Tag = "Period";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(343, 38);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown2.TabIndex = 105;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(240, 38);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown1.TabIndex = 104;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbLokalitet
            // 
            this.cbLokalitet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbLokalitet.Font = new System.Drawing.Font("Calibri", 11F);
            this.cbLokalitet.FormattingEnabled = true;
            this.cbLokalitet.Items.AddRange(new object[] {
            "Smitsonijan SAD",
            "Luvr Francuska",
            "Muzej Iraklion Grčka",
            "Narodni muzej Srbija",
            "Britanski Muzej Engleska",
            "Etnografski muzej Austrija",
            "Muzej Kairo Egipat",
            "Nalazište Mikena Grčka",
            "Muzej Korbridž Engleska",
            "Muzej Iraklion Grčka",
            "Smitsonijan SAD",
            "Britanski Muzej Engleska",
            "Nalazište Mikena Grčka",
            "Muzej Kairo Egipat",
            "Etnografski muzej Austrija",
            "Muzej Kairo Egipat",
            "Luvr Francuska",
            "Nalazište Mikena Grčka",
            "Muzej Iraklion Grčka",
            "Britanski Muzej Engleska"});
            this.cbLokalitet.Location = new System.Drawing.Point(466, 85);
            this.cbLokalitet.Name = "cbLokalitet";
            this.cbLokalitet.Size = new System.Drawing.Size(180, 26);
            this.cbLokalitet.TabIndex = 103;
            this.cbLokalitet.Tag = "Lokalitet";
            // 
            // cbTipAnt
            // 
            this.cbTipAnt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTipAnt.Font = new System.Drawing.Font("Calibri", 11F);
            this.cbTipAnt.FormattingEnabled = true;
            this.cbTipAnt.Items.AddRange(new object[] {
            "Strela",
            "Slika",
            "Novac",
            "Puška",
            "Statua",
            "Fosili",
            "Sarkofag",
            "Viljuška",
            "Vaza",
            "Mač",
            "Fosili",
            "Čekić",
            "Knjiga",
            "Kruna",
            "Ogrlica",
            "Prsten",
            "Štit",
            "Knjiga",
            "Knjiga",
            "Knjiga"});
            this.cbTipAnt.Location = new System.Drawing.Point(240, 85);
            this.cbTipAnt.Name = "cbTipAnt";
            this.cbTipAnt.Size = new System.Drawing.Size(180, 26);
            this.cbTipAnt.TabIndex = 102;
            this.cbTipAnt.Tag = "Tip antikviteta";
            // 
            // cbPeriod
            // 
            this.cbPeriod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbPeriod.Font = new System.Drawing.Font("Calibri", 11F);
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Items.AddRange(new object[] {
            "Bakarno doba",
            "Srednji vek",
            "Stara Grčka",
            "Savremeno doba",
            "Rimsko Carstvo",
            "Neolit",
            "Stari Egipat",
            "Stara Grčka",
            "Mesopotamija",
            "Stari vek",
            "Paleolit",
            "Bakarno doba",
            "Stara Grčka",
            "Srednji vek",
            "Mesopotamija",
            "Stari Egipat",
            "Rimsko Carstvo",
            "Rimsko Carstvo",
            "Stara Grčka",
            "Rimsko Carstvo"});
            this.cbPeriod.Location = new System.Drawing.Point(17, 85);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(180, 26);
            this.cbPeriod.TabIndex = 101;
            this.cbPeriod.Tag = "Period";
            // 
            // cbArheolozi
            // 
            this.cbArheolozi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbArheolozi.Font = new System.Drawing.Font("Calibri", 11F);
            this.cbArheolozi.FormattingEnabled = true;
            this.cbArheolozi.Items.AddRange(new object[] {
            "Angus, Leverenz,  Prag, Ceska Republika",
            "Heard, Kavanagh, Rocklin, SAD",
            "Roberto, Hüseynov, Schuring Anouk, Holandija",
            "Galip, Bianco,  Paris, Francuska",
            "Noor-Ali, Mohammad, Kairo, Egipat",
            "Osbourne, Darzi,  Hamburg, Nemacka",
            "Avinash, Rains, Mumbai, Indija",
            "Aðalsteinn, Wheeler, Stokholm, Svedska",
            "Marko, Stanojevic,Nis, Srbija",
            "Sandro, De Laurentis,Rim, Italija"});
            this.cbArheolozi.Location = new System.Drawing.Point(466, 38);
            this.cbArheolozi.Name = "cbArheolozi";
            this.cbArheolozi.Size = new System.Drawing.Size(180, 26);
            this.cbArheolozi.TabIndex = 94;
            this.cbArheolozi.Tag = "Arheolozi";
            // 
            // UCAntikvitet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCAntikvitet";
            this.Size = new System.Drawing.Size(681, 611);
            this.Load += new System.EventHandler(this.UCAntikvitet_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAntikvitet;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Button btnDodavanjeUC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbArheolozi;
        private System.Windows.Forms.ComboBox cbLokalitet;
        private System.Windows.Forms.ComboBox cbTipAnt;
        private System.Windows.Forms.ComboBox cbPeriod;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
