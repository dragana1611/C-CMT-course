
namespace Test2
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.akcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacuvajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPodaci = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.cbSkola = new System.Windows.Forms.ComboBox();
            this.lblSkola = new System.Windows.Forms.Label();
            this.cbGodine = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbMusko = new System.Windows.Forms.RadioButton();
            this.rbZensko = new System.Windows.Forms.RadioButton();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblPol = new System.Windows.Forms.Label();
            this.lblGodine = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgwPodaci = new System.Windows.Forms.DataGridView();
            this.tabPomocniPodaci = new System.Windows.Forms.TabPage();
            this.btnComboBoxVrednost = new System.Windows.Forms.Button();
            this.lblComboBoxVrednost = new System.Windows.Forms.Label();
            this.tbComboBoxVrednost = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPodaci)).BeginInit();
            this.tabPomocniPodaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akcijeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(927, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // akcijeToolStripMenuItem
            // 
            this.akcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izmeniToolStripMenuItem,
            this.obrisiToolStripMenuItem,
            this.sacuvajToolStripMenuItem,
            this.porukaToolStripMenuItem});
            this.akcijeToolStripMenuItem.Name = "akcijeToolStripMenuItem";
            this.akcijeToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.akcijeToolStripMenuItem.Text = "Akcije";
            // 
            // izmeniToolStripMenuItem
            // 
            this.izmeniToolStripMenuItem.Name = "izmeniToolStripMenuItem";
            this.izmeniToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.izmeniToolStripMenuItem.Text = "Izmeni podatke polaznika";
            this.izmeniToolStripMenuItem.Click += new System.EventHandler(this.izmeniToolStripMenuItem_Click);
            // 
            // obrisiToolStripMenuItem
            // 
            this.obrisiToolStripMenuItem.Name = "obrisiToolStripMenuItem";
            this.obrisiToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.obrisiToolStripMenuItem.Text = "Obrisi polaznika";
            this.obrisiToolStripMenuItem.Click += new System.EventHandler(this.obrisiToolStripMenuItem_Click);
            // 
            // sacuvajToolStripMenuItem
            // 
            this.sacuvajToolStripMenuItem.Name = "sacuvajToolStripMenuItem";
            this.sacuvajToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.sacuvajToolStripMenuItem.Text = "Sacuvaj podatke";
            this.sacuvajToolStripMenuItem.Click += new System.EventHandler(this.sacuvajToolStripMenuItem_Click);
            // 
            // porukaToolStripMenuItem
            // 
            this.porukaToolStripMenuItem.Name = "porukaToolStripMenuItem";
            this.porukaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.porukaToolStripMenuItem.Text = "Vasa poruka nastavniku";
            this.porukaToolStripMenuItem.Click += new System.EventHandler(this.porukaToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 464);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(927, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(65, 17);
            this.statusLabel.Text = "Dobrodosli";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPodaci);
            this.tabControl1.Controls.Add(this.tabPomocniPodaci);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 440);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPodaci
            // 
            this.tabPodaci.Controls.Add(this.splitContainer1);
            this.tabPodaci.Location = new System.Drawing.Point(4, 22);
            this.tabPodaci.Name = "tabPodaci";
            this.tabPodaci.Padding = new System.Windows.Forms.Padding(3);
            this.tabPodaci.Size = new System.Drawing.Size(919, 414);
            this.tabPodaci.TabIndex = 0;
            this.tabPodaci.Text = "Podaci";
            this.tabPodaci.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel2.Controls.Add(this.dgwPodaci);
            this.splitContainer1.Size = new System.Drawing.Size(913, 408);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tbIme, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPrezime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbSkola, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSkola, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbGodine, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblIme, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPrezime, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPol, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGodine, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDodaj, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66945F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 408);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tbIme
            // 
            this.tbIme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIme.Location = new System.Drawing.Point(69, 23);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(194, 20);
            this.tbIme.TabIndex = 3;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrezime.Location = new System.Drawing.Point(69, 90);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(194, 20);
            this.tbPrezime.TabIndex = 4;
            // 
            // cbSkola
            // 
            this.cbSkola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSkola.FormattingEnabled = true;
            this.cbSkola.Location = new System.Drawing.Point(69, 291);
            this.cbSkola.Name = "cbSkola";
            this.cbSkola.Size = new System.Drawing.Size(194, 21);
            this.cbSkola.TabIndex = 1;
            // 
            // lblSkola
            // 
            this.lblSkola.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSkola.AutoSize = true;
            this.lblSkola.Location = new System.Drawing.Point(26, 295);
            this.lblSkola.Name = "lblSkola";
            this.lblSkola.Size = new System.Drawing.Size(37, 13);
            this.lblSkola.TabIndex = 2;
            this.lblSkola.Text = "Skola:";
            // 
            // cbGodine
            // 
            this.cbGodine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGodine.FormattingEnabled = true;
            this.cbGodine.Location = new System.Drawing.Point(69, 224);
            this.cbGodine.Name = "cbGodine";
            this.cbGodine.Size = new System.Drawing.Size(194, 21);
            this.cbGodine.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.rbMusko);
            this.flowLayoutPanel1.Controls.Add(this.rbZensko);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(69, 156);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(194, 23);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // rbMusko
            // 
            this.rbMusko.AutoSize = true;
            this.rbMusko.Location = new System.Drawing.Point(3, 3);
            this.rbMusko.Name = "rbMusko";
            this.rbMusko.Size = new System.Drawing.Size(57, 17);
            this.rbMusko.TabIndex = 6;
            this.rbMusko.TabStop = true;
            this.rbMusko.Text = "Musko";
            this.rbMusko.UseVisualStyleBackColor = true;
            // 
            // rbZensko
            // 
            this.rbZensko.AutoSize = true;
            this.rbZensko.Checked = true;
            this.rbZensko.Location = new System.Drawing.Point(66, 3);
            this.rbZensko.Name = "rbZensko";
            this.rbZensko.Size = new System.Drawing.Size(61, 17);
            this.rbZensko.TabIndex = 7;
            this.rbZensko.TabStop = true;
            this.rbZensko.Text = "Zensko";
            this.rbZensko.UseVisualStyleBackColor = true;
            // 
            // lblIme
            // 
            this.lblIme.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(36, 27);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 11;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(16, 94);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 12;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblPol
            // 
            this.lblPol.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPol.AutoSize = true;
            this.lblPol.Location = new System.Drawing.Point(38, 161);
            this.lblPol.Name = "lblPol";
            this.lblPol.Size = new System.Drawing.Size(25, 13);
            this.lblPol.TabIndex = 13;
            this.lblPol.Text = "Pol:";
            // 
            // lblGodine
            // 
            this.lblGodine.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGodine.AutoSize = true;
            this.lblGodine.Location = new System.Drawing.Point(19, 228);
            this.lblGodine.Name = "lblGodine";
            this.lblGodine.Size = new System.Drawing.Size(44, 13);
            this.lblGodine.TabIndex = 14;
            this.lblGodine.Text = "Godine:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.Location = new System.Drawing.Point(69, 360);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(194, 23);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgwPodaci
            // 
            this.dgwPodaci.AllowUserToAddRows = false;
            this.dgwPodaci.AllowUserToDeleteRows = false;
            this.dgwPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPodaci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPodaci.Location = new System.Drawing.Point(0, 0);
            this.dgwPodaci.MultiSelect = false;
            this.dgwPodaci.Name = "dgwPodaci";
            this.dgwPodaci.ReadOnly = true;
            this.dgwPodaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPodaci.Size = new System.Drawing.Size(623, 408);
            this.dgwPodaci.TabIndex = 0;
            this.dgwPodaci.SelectionChanged += new System.EventHandler(this.dgwPodaci_SelectionChanged);
            // 
            // tabPomocniPodaci
            // 
            this.tabPomocniPodaci.Controls.Add(this.btnComboBoxVrednost);
            this.tabPomocniPodaci.Controls.Add(this.lblComboBoxVrednost);
            this.tabPomocniPodaci.Controls.Add(this.tbComboBoxVrednost);
            this.tabPomocniPodaci.Location = new System.Drawing.Point(4, 22);
            this.tabPomocniPodaci.Name = "tabPomocniPodaci";
            this.tabPomocniPodaci.Padding = new System.Windows.Forms.Padding(3);
            this.tabPomocniPodaci.Size = new System.Drawing.Size(919, 414);
            this.tabPomocniPodaci.TabIndex = 1;
            this.tabPomocniPodaci.Text = "Pomocni podaci";
            this.tabPomocniPodaci.UseVisualStyleBackColor = true;
            // 
            // btnComboBoxVrednost
            // 
            this.btnComboBoxVrednost.Location = new System.Drawing.Point(354, 21);
            this.btnComboBoxVrednost.Name = "btnComboBoxVrednost";
            this.btnComboBoxVrednost.Size = new System.Drawing.Size(78, 23);
            this.btnComboBoxVrednost.TabIndex = 4;
            this.btnComboBoxVrednost.Text = "Dodaj";
            this.btnComboBoxVrednost.UseVisualStyleBackColor = true;
            this.btnComboBoxVrednost.Click += new System.EventHandler(this.btnComboBoxVrednost_Click);
            // 
            // lblComboBoxVrednost
            // 
            this.lblComboBoxVrednost.AutoSize = true;
            this.lblComboBoxVrednost.Location = new System.Drawing.Point(36, 26);
            this.lblComboBoxVrednost.Name = "lblComboBoxVrednost";
            this.lblComboBoxVrednost.Size = new System.Drawing.Size(134, 13);
            this.lblComboBoxVrednost.TabIndex = 1;
            this.lblComboBoxVrednost.Text = "Nova ComboBox vrednost:";
            // 
            // tbComboBoxVrednost
            // 
            this.tbComboBoxVrednost.Location = new System.Drawing.Point(176, 23);
            this.tbComboBoxVrednost.Name = "tbComboBoxVrednost";
            this.tbComboBoxVrednost.Size = new System.Drawing.Size(164, 20);
            this.tbComboBoxVrednost.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 486);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMT";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPodaci.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPodaci)).EndInit();
            this.tabPomocniPodaci.ResumeLayout(false);
            this.tabPomocniPodaci.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem akcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porukaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPodaci;
        private System.Windows.Forms.ComboBox cbSkola;
        private System.Windows.Forms.TabPage tabPomocniPodaci;
        private System.Windows.Forms.Button btnComboBoxVrednost;
        private System.Windows.Forms.Label lblComboBoxVrednost;
        private System.Windows.Forms.TextBox tbComboBoxVrednost;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgwPodaci;
        private System.Windows.Forms.Label lblSkola;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.RadioButton rbMusko;
        private System.Windows.Forms.RadioButton rbZensko;
        private System.Windows.Forms.ComboBox cbGodine;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblPol;
        private System.Windows.Forms.Label lblGodine;
        private System.Windows.Forms.ToolStripMenuItem izmeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacuvajToolStripMenuItem;
    }
}

