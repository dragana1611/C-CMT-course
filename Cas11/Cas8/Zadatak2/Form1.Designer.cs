namespace Zadatak2
{
    partial class Albumi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNazivAlbuma = new System.Windows.Forms.ComboBox();
            this.textBoxIzvodjac = new System.Windows.Forms.TextBox();
            this.textBoxDatum = new System.Windows.Forms.TextBox();
            this.richTextBoxPesme = new System.Windows.Forms.RichTextBox();
            this.pictureBoxSlikaOmota = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaOmota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv albuma :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izvodjac :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum izdavanja :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pesme na albumu :";
            // 
            // comboBoxNazivAlbuma
            // 
            this.comboBoxNazivAlbuma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNazivAlbuma.FormattingEnabled = true;
            this.comboBoxNazivAlbuma.Location = new System.Drawing.Point(209, 60);
            this.comboBoxNazivAlbuma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxNazivAlbuma.Name = "comboBoxNazivAlbuma";
            this.comboBoxNazivAlbuma.Size = new System.Drawing.Size(297, 24);
            this.comboBoxNazivAlbuma.TabIndex = 4;
            this.comboBoxNazivAlbuma.SelectedIndexChanged += new System.EventHandler(this.comboBoxNazivAlbuma_SelectedIndexChanged);
            // 
            // textBoxIzvodjac
            // 
            this.textBoxIzvodjac.Location = new System.Drawing.Point(209, 111);
            this.textBoxIzvodjac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIzvodjac.Name = "textBoxIzvodjac";
            this.textBoxIzvodjac.ReadOnly = true;
            this.textBoxIzvodjac.Size = new System.Drawing.Size(297, 22);
            this.textBoxIzvodjac.TabIndex = 5;
            // 
            // textBoxDatum
            // 
            this.textBoxDatum.Location = new System.Drawing.Point(209, 169);
            this.textBoxDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDatum.Name = "textBoxDatum";
            this.textBoxDatum.ReadOnly = true;
            this.textBoxDatum.Size = new System.Drawing.Size(297, 22);
            this.textBoxDatum.TabIndex = 6;
            // 
            // richTextBoxPesme
            // 
            this.richTextBoxPesme.Location = new System.Drawing.Point(209, 222);
            this.richTextBoxPesme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxPesme.Name = "richTextBoxPesme";
            this.richTextBoxPesme.ReadOnly = true;
            this.richTextBoxPesme.Size = new System.Drawing.Size(297, 246);
            this.richTextBoxPesme.TabIndex = 7;
            this.richTextBoxPesme.Text = "";
            // 
            // pictureBoxSlikaOmota
            // 
            this.pictureBoxSlikaOmota.Location = new System.Drawing.Point(659, 60);
            this.pictureBoxSlikaOmota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxSlikaOmota.Name = "pictureBoxSlikaOmota";
            this.pictureBoxSlikaOmota.Size = new System.Drawing.Size(312, 267);
            this.pictureBoxSlikaOmota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSlikaOmota.TabIndex = 8;
            this.pictureBoxSlikaOmota.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(743, 331);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Slika sa omota albuma";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Albumi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBoxSlikaOmota);
            this.Controls.Add(this.richTextBoxPesme);
            this.Controls.Add(this.textBoxDatum);
            this.Controls.Add(this.textBoxIzvodjac);
            this.Controls.Add(this.comboBoxNazivAlbuma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Albumi";
            this.Text = "Albumi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlikaOmota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxNazivAlbuma;
        private System.Windows.Forms.TextBox textBoxIzvodjac;
        private System.Windows.Forms.TextBox textBoxDatum;
        private System.Windows.Forms.RichTextBox richTextBoxPesme;
        private System.Windows.Forms.PictureBox pictureBoxSlikaOmota;
        private System.Windows.Forms.Label label5;
    }
}

