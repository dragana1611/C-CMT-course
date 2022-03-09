
namespace Test2_Polaznik
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.akcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniPodatkeKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiPolaznikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacuvajPodatkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vasaPorukaNastavnikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.cbSkola = new System.Windows.Forms.ComboBox();
            this.cbGodine = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbMusko = new System.Windows.Forms.RadioButton();
            this.rbZensko = new System.Windows.Forms.RadioButton();
            this.dataGridViewPolaznik = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.textBoxNovaVrednost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolaznik)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akcijeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // akcijeToolStripMenuItem
            // 
            this.akcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izmeniPodatkeKorisnikaToolStripMenuItem,
            this.obrisiPolaznikaToolStripMenuItem,
            this.sacuvajPodatkeToolStripMenuItem,
            this.vasaPorukaNastavnikuToolStripMenuItem});
            this.akcijeToolStripMenuItem.Name = "akcijeToolStripMenuItem";
            this.akcijeToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.akcijeToolStripMenuItem.Text = "Akcije";
            // 
            // izmeniPodatkeKorisnikaToolStripMenuItem
            // 
            this.izmeniPodatkeKorisnikaToolStripMenuItem.Name = "izmeniPodatkeKorisnikaToolStripMenuItem";
            this.izmeniPodatkeKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.izmeniPodatkeKorisnikaToolStripMenuItem.Text = "Izmeni podatke korisnika";
            this.izmeniPodatkeKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.izmeniPodatkeKorisnikaToolStripMenuItem_Click);
            // 
            // obrisiPolaznikaToolStripMenuItem
            // 
            this.obrisiPolaznikaToolStripMenuItem.Name = "obrisiPolaznikaToolStripMenuItem";
            this.obrisiPolaznikaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.obrisiPolaznikaToolStripMenuItem.Text = "Obrisi polaznika";
            this.obrisiPolaznikaToolStripMenuItem.Click += new System.EventHandler(this.obrisiPolaznikaToolStripMenuItem_Click);
            // 
            // sacuvajPodatkeToolStripMenuItem
            // 
            this.sacuvajPodatkeToolStripMenuItem.Name = "sacuvajPodatkeToolStripMenuItem";
            this.sacuvajPodatkeToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.sacuvajPodatkeToolStripMenuItem.Text = "Sacuvaj podatke";
            this.sacuvajPodatkeToolStripMenuItem.Click += new System.EventHandler(this.sacuvajPodatkeToolStripMenuItem_Click);
            // 
            // vasaPorukaNastavnikuToolStripMenuItem
            // 
            this.vasaPorukaNastavnikuToolStripMenuItem.Name = "vasaPorukaNastavnikuToolStripMenuItem";
            this.vasaPorukaNastavnikuToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.vasaPorukaNastavnikuToolStripMenuItem.Text = "Vasa poruka nastavniku";
            this.vasaPorukaNastavnikuToolStripMenuItem.Click += new System.EventHandler(this.vasaPorukaNastavnikuToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "Dobrodosli";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 404);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Podaci";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewPolaznik);
            this.splitContainer1.Size = new System.Drawing.Size(786, 372);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblIme, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbIme, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPrezime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbSkola, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbGodine, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDodaj, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 372);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblIme
            // 
            this.lblIme.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(29, 24);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pol:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Godine";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Skola";
            // 
            // tbIme
            // 
            this.tbIme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIme.Location = new System.Drawing.Point(62, 20);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(194, 20);
            this.tbIme.TabIndex = 5;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrezime.Location = new System.Drawing.Point(62, 81);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(194, 20);
            this.tbPrezime.TabIndex = 6;
            // 
            // cbSkola
            // 
            this.cbSkola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSkola.FormattingEnabled = true;
            this.cbSkola.Location = new System.Drawing.Point(62, 264);
            this.cbSkola.Name = "cbSkola";
            this.cbSkola.Size = new System.Drawing.Size(194, 21);
            this.cbSkola.TabIndex = 8;
            // 
            // cbGodine
            // 
            this.cbGodine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGodine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGodine.FormattingEnabled = true;
            this.cbGodine.Location = new System.Drawing.Point(62, 203);
            this.cbGodine.Name = "cbGodine";
            this.cbGodine.Size = new System.Drawing.Size(194, 21);
            this.cbGodine.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.Location = new System.Drawing.Point(62, 327);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(194, 23);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.rbMusko);
            this.flowLayoutPanel1.Controls.Add(this.rbZensko);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(62, 141);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(194, 23);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // rbMusko
            // 
            this.rbMusko.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbMusko.AutoSize = true;
            this.rbMusko.Location = new System.Drawing.Point(3, 3);
            this.rbMusko.Name = "rbMusko";
            this.rbMusko.Size = new System.Drawing.Size(57, 17);
            this.rbMusko.TabIndex = 1;
            this.rbMusko.Text = "Musko";
            this.rbMusko.UseVisualStyleBackColor = true;
            // 
            // rbZensko
            // 
            this.rbZensko.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbZensko.AutoSize = true;
            this.rbZensko.Checked = true;
            this.rbZensko.Location = new System.Drawing.Point(66, 3);
            this.rbZensko.Name = "rbZensko";
            this.rbZensko.Size = new System.Drawing.Size(61, 17);
            this.rbZensko.TabIndex = 0;
            this.rbZensko.TabStop = true;
            this.rbZensko.Text = "Zensko";
            this.rbZensko.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPolaznik
            // 
            this.dataGridViewPolaznik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPolaznik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPolaznik.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPolaznik.MultiSelect = false;
            this.dataGridViewPolaznik.Name = "dataGridViewPolaznik";
            this.dataGridViewPolaznik.ReadOnly = true;
            this.dataGridViewPolaznik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPolaznik.Size = new System.Drawing.Size(503, 372);
            this.dataGridViewPolaznik.TabIndex = 0;
            this.dataGridViewPolaznik.SelectionChanged += new System.EventHandler(this.dataGridViewPolaznik_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDodaj);
            this.tabPage2.Controls.Add(this.textBoxNovaVrednost);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pomocni podaci";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(370, 30);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // textBoxNovaVrednost
            // 
            this.textBoxNovaVrednost.Location = new System.Drawing.Point(190, 32);
            this.textBoxNovaVrednost.Name = "textBoxNovaVrednost";
            this.textBoxNovaVrednost.Size = new System.Drawing.Size(164, 20);
            this.textBoxNovaVrednost.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nova ComboBox vrednost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMT";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolaznik)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem akcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmeniPodatkeKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiPolaznikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacuvajPodatkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vasaPorukaNastavnikuToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.ComboBox cbSkola;
        private System.Windows.Forms.ComboBox cbGodine;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dataGridViewPolaznik;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbMusko;
        private System.Windows.Forms.RadioButton rbZensko;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.TextBox textBoxNovaVrednost;
        private System.Windows.Forms.Label label5;
    }
}

