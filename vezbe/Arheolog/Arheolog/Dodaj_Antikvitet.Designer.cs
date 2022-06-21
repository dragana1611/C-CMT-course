namespace Arheolog
{
    partial class Dodaj_Antikvitet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dodaj_Antikvitet));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblImg = new System.Windows.Forms.Label();
            this.tbImgNaziv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDodavanjeUC = new System.Windows.Forms.Button();
            this.btnBrisanjeAntikviteta = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLokalitet = new System.Windows.Forms.Label();
            this.lblTipAnt = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblDatPron = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.tbDatPronal = new System.Windows.Forms.TextBox();
            this.tbPeriod = new System.Windows.Forms.TextBox();
            this.tbTipAntikv = new System.Windows.Forms.TextBox();
            this.tbLokalitet = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.tbPrikazAnt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 324);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(231)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.tbPrikazAnt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.lblImg);
            this.panel1.Controls.Add(this.tbImgNaziv);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblLokalitet);
            this.panel1.Controls.Add(this.lblTipAnt);
            this.panel1.Controls.Add(this.lblPeriod);
            this.panel1.Controls.Add(this.lblDatPron);
            this.panel1.Controls.Add(this.lblNaziv);
            this.panel1.Controls.Add(this.tbDatPronal);
            this.panel1.Controls.Add(this.tbPeriod);
            this.panel1.Controls.Add(this.tbTipAntikv);
            this.panel1.Controls.Add(this.tbLokalitet);
            this.panel1.Controls.Add(this.tbNaziv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 318);
            this.panel1.TabIndex = 1;
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImg.Location = new System.Drawing.Point(347, 82);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(34, 14);
            this.lblImg.TabIndex = 106;
            this.lblImg.Text = "Slika";
            // 
            // tbImgNaziv
            // 
            this.tbImgNaziv.Location = new System.Drawing.Point(350, 101);
            this.tbImgNaziv.Name = "tbImgNaziv";
            this.tbImgNaziv.Size = new System.Drawing.Size(100, 20);
            this.tbImgNaziv.TabIndex = 5;
            this.tbImgNaziv.Tag = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzmeni);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnDodavanjeUC);
            this.groupBox1.Controls.Add(this.btnBrisanjeAntikviteta);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Location = new System.Drawing.Point(6, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(463, 86);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(165)))), ((int)(((byte)(135)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(293, 34);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 25);
            this.btnReset.TabIndex = 98;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDodavanjeUC
            // 
            this.btnDodavanjeUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnDodavanjeUC.FlatAppearance.BorderSize = 0;
            this.btnDodavanjeUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodavanjeUC.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodavanjeUC.ForeColor = System.Drawing.Color.White;
            this.btnDodavanjeUC.Location = new System.Drawing.Point(5, 34);
            this.btnDodavanjeUC.Name = "btnDodavanjeUC";
            this.btnDodavanjeUC.Size = new System.Drawing.Size(115, 25);
            this.btnDodavanjeUC.TabIndex = 94;
            this.btnDodavanjeUC.Text = "Dodaj antikvitet";
            this.btnDodavanjeUC.UseVisualStyleBackColor = false;
            this.btnDodavanjeUC.Click += new System.EventHandler(this.btnDodavanjeUC_Click);
            // 
            // btnBrisanjeAntikviteta
            // 
            this.btnBrisanjeAntikviteta.BackColor = System.Drawing.Color.Maroon;
            this.btnBrisanjeAntikviteta.FlatAppearance.BorderSize = 0;
            this.btnBrisanjeAntikviteta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrisanjeAntikviteta.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisanjeAntikviteta.ForeColor = System.Drawing.Color.White;
            this.btnBrisanjeAntikviteta.Location = new System.Drawing.Point(208, 34);
            this.btnBrisanjeAntikviteta.Name = "btnBrisanjeAntikviteta";
            this.btnBrisanjeAntikviteta.Size = new System.Drawing.Size(80, 25);
            this.btnBrisanjeAntikviteta.TabIndex = 95;
            this.btnBrisanjeAntikviteta.Text = "Delete";
            this.btnBrisanjeAntikviteta.UseVisualStyleBackColor = false;
            this.btnBrisanjeAntikviteta.Click += new System.EventHandler(this.btnBrisanjeAntikviteta_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(377, 34);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 97;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLokalitet
            // 
            this.lblLokalitet.AutoSize = true;
            this.lblLokalitet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokalitet.Location = new System.Drawing.Point(216, 82);
            this.lblLokalitet.Name = "lblLokalitet";
            this.lblLokalitet.Size = new System.Drawing.Size(55, 14);
            this.lblLokalitet.TabIndex = 104;
            this.lblLokalitet.Text = "Lokalitet";
            // 
            // lblTipAnt
            // 
            this.lblTipAnt.AutoSize = true;
            this.lblTipAnt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipAnt.Location = new System.Drawing.Point(87, 82);
            this.lblTipAnt.Name = "lblTipAnt";
            this.lblTipAnt.Size = new System.Drawing.Size(85, 14);
            this.lblTipAnt.TabIndex = 103;
            this.lblTipAnt.Text = "Tip antikviteta";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(347, 19);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(42, 14);
            this.lblPeriod.TabIndex = 102;
            this.lblPeriod.Text = "Period";
            // 
            // lblDatPron
            // 
            this.lblDatPron.AutoSize = true;
            this.lblDatPron.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatPron.Location = new System.Drawing.Point(216, 19);
            this.lblDatPron.Name = "lblDatPron";
            this.lblDatPron.Size = new System.Drawing.Size(108, 14);
            this.lblDatPron.TabIndex = 101;
            this.lblDatPron.Text = "Datum pronalaska";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(90, 19);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(97, 14);
            this.lblNaziv.TabIndex = 100;
            this.lblNaziv.Text = "Naziv antikviteta";
            // 
            // tbDatPronal
            // 
            this.tbDatPronal.Location = new System.Drawing.Point(219, 40);
            this.tbDatPronal.Name = "tbDatPronal";
            this.tbDatPronal.Size = new System.Drawing.Size(100, 20);
            this.tbDatPronal.TabIndex = 1;
            // 
            // tbPeriod
            // 
            this.tbPeriod.Location = new System.Drawing.Point(350, 40);
            this.tbPeriod.Name = "tbPeriod";
            this.tbPeriod.Size = new System.Drawing.Size(100, 20);
            this.tbPeriod.TabIndex = 2;
            // 
            // tbTipAntikv
            // 
            this.tbTipAntikv.Location = new System.Drawing.Point(90, 101);
            this.tbTipAntikv.Name = "tbTipAntikv";
            this.tbTipAntikv.Size = new System.Drawing.Size(100, 20);
            this.tbTipAntikv.TabIndex = 3;
            // 
            // tbLokalitet
            // 
            this.tbLokalitet.Location = new System.Drawing.Point(219, 101);
            this.tbLokalitet.Name = "tbLokalitet";
            this.tbLokalitet.Size = new System.Drawing.Size(100, 20);
            this.tbLokalitet.TabIndex = 4;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(90, 40);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(100, 20);
            this.tbNaziv.TabIndex = 0;
            this.tbNaziv.Tag = "Naziv antikviteta";
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(24, 40);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(52, 20);
            this.ID.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 14);
            this.label1.TabIndex = 108;
            this.label1.Text = "ID";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(119)))), ((int)(((byte)(126)))));
            this.btnIzmeni.FlatAppearance.BorderSize = 0;
            this.btnIzmeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeni.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.ForeColor = System.Drawing.Color.White;
            this.btnIzmeni.Location = new System.Drawing.Point(124, 34);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(80, 25);
            this.btnIzmeni.TabIndex = 99;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // tbPrikazAnt
            // 
            this.tbPrikazAnt.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrikazAnt.Location = new System.Drawing.Point(41, 169);
            this.tbPrikazAnt.Name = "tbPrikazAnt";
            this.tbPrikazAnt.Size = new System.Drawing.Size(390, 27);
            this.tbPrikazAnt.TabIndex = 109;
            // 
            // Dodaj_Antikvitet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 324);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dodaj_Antikvitet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Antikvitet";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbDatPronal;
        private System.Windows.Forms.TextBox tbPeriod;
        private System.Windows.Forms.TextBox tbTipAntikv;
        private System.Windows.Forms.TextBox tbLokalitet;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Button btnBrisanjeAntikviteta;
        private System.Windows.Forms.Button btnDodavanjeUC;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLokalitet;
        private System.Windows.Forms.Label lblTipAnt;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblDatPron;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbImgNaziv;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox tbPrikazAnt;
        private System.Windows.Forms.Button btnIzmeni;
    }
}