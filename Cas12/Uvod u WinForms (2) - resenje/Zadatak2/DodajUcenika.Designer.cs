namespace Zadatak2
{
    partial class DodajUcenika
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbSkola = new System.Windows.Forms.ComboBox();
            this.prezimeUcenika = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imeUcenika = new System.Windows.Forms.TextBox();
            this.cbRazred = new System.Windows.Forms.ComboBox();
            this.datumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.UpisiUcenikeUFajl = new System.Windows.Forms.Button();
            this.IscitajUcenikeIzFajla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(521, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.48402F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.51598F));
            this.tableLayoutPanel1.Controls.Add(this.cbSkola, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.prezimeUcenika, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.imeUcenika, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbRazred, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.datumRodjenja, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 241);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbSkola
            // 
            this.cbSkola.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbSkola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkola.FormattingEnabled = true;
            this.cbSkola.Location = new System.Drawing.Point(96, 206);
            this.cbSkola.Name = "cbSkola";
            this.cbSkola.Size = new System.Drawing.Size(236, 21);
            this.cbSkola.TabIndex = 11;
            // 
            // prezimeUcenika
            // 
            this.prezimeUcenika.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.prezimeUcenika.Location = new System.Drawing.Point(96, 62);
            this.prezimeUcenika.Name = "prezimeUcenika";
            this.prezimeUcenika.Size = new System.Drawing.Size(236, 20);
            this.prezimeUcenika.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Razred";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum rodjenja:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Škola:";
            // 
            // imeUcenika
            // 
            this.imeUcenika.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imeUcenika.Location = new System.Drawing.Point(96, 14);
            this.imeUcenika.Name = "imeUcenika";
            this.imeUcenika.Size = new System.Drawing.Size(236, 20);
            this.imeUcenika.TabIndex = 7;
            // 
            // cbRazred
            // 
            this.cbRazred.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbRazred.DisplayMember = "1";
            this.cbRazred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRazred.FormattingEnabled = true;
            this.cbRazred.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbRazred.Location = new System.Drawing.Point(96, 109);
            this.cbRazred.Name = "cbRazred";
            this.cbRazred.Size = new System.Drawing.Size(236, 21);
            this.cbRazred.TabIndex = 9;
            // 
            // datumRodjenja
            // 
            this.datumRodjenja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.datumRodjenja.Location = new System.Drawing.Point(96, 158);
            this.datumRodjenja.Name = "datumRodjenja";
            this.datumRodjenja.Size = new System.Drawing.Size(236, 20);
            this.datumRodjenja.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj Učenika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpisiUcenikeUFajl
            // 
            this.UpisiUcenikeUFajl.Location = new System.Drawing.Point(82, 521);
            this.UpisiUcenikeUFajl.Name = "UpisiUcenikeUFajl";
            this.UpisiUcenikeUFajl.Size = new System.Drawing.Size(117, 28);
            this.UpisiUcenikeUFajl.TabIndex = 3;
            this.UpisiUcenikeUFajl.Text = "Upisi ucenike u fajl";
            this.UpisiUcenikeUFajl.UseVisualStyleBackColor = true;
            this.UpisiUcenikeUFajl.Click += new System.EventHandler(this.UpisiUcenikeUFajl_Click);
            // 
            // IscitajUcenikeIzFajla
            // 
            this.IscitajUcenikeIzFajla.Location = new System.Drawing.Point(321, 521);
            this.IscitajUcenikeIzFajla.Name = "IscitajUcenikeIzFajla";
            this.IscitajUcenikeIzFajla.Size = new System.Drawing.Size(117, 28);
            this.IscitajUcenikeIzFajla.TabIndex = 4;
            this.IscitajUcenikeIzFajla.Text = "Iscitaj ucenike iz fajla";
            this.IscitajUcenikeIzFajla.UseVisualStyleBackColor = true;
            this.IscitajUcenikeIzFajla.Click += new System.EventHandler(this.IscitajUcenikeIzFajla_Click);
            // 
            // DodajUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 556);
            this.Controls.Add(this.IscitajUcenikeIzFajla);
            this.Controls.Add(this.UpisiUcenikeUFajl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DodajUcenika";
            this.Text = "DodajUcenika";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbSkola;
        private System.Windows.Forms.TextBox prezimeUcenika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox imeUcenika;
        private System.Windows.Forms.ComboBox cbRazred;
        private System.Windows.Forms.DateTimePicker datumRodjenja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UpisiUcenikeUFajl;
        private System.Windows.Forms.Button IscitajUcenikeIzFajla;
    }
}