namespace Zadatak1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelIme = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.radioButtonMusko = new System.Windows.Forms.RadioButton();
            this.radioButtonZensko = new System.Windows.Forms.RadioButton();
            this.checkBoxStudent = new System.Windows.Forms.CheckBox();
            this.buttonOcisti = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.34607F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.65393F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Pol,
            this.Student});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(449, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Pol
            // 
            this.Pol.HeaderText = "Pol";
            this.Pol.Name = "Pol";
            this.Pol.ReadOnly = true;
            // 
            // Student
            // 
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.29825F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.66472F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.03704F));
            this.tableLayoutPanel2.Controls.Add(this.labelIme, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxIme, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxPrezime, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonMusko, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonZensko, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxStudent, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonOcisti, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonDodaj, 2, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(440, 444);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelIme
            // 
            this.labelIme.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(51, 37);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(30, 13);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Ime :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pol :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student :";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.textBoxIme, 2);
            this.textBoxIme.Location = new System.Drawing.Point(135, 34);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(254, 20);
            this.textBoxIme.TabIndex = 4;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.textBoxPrezime, 2);
            this.textBoxPrezime.Location = new System.Drawing.Point(132, 122);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(260, 20);
            this.textBoxPrezime.TabIndex = 5;
            // 
            // radioButtonMusko
            // 
            this.radioButtonMusko.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonMusko.AutoSize = true;
            this.radioButtonMusko.Location = new System.Drawing.Point(151, 211);
            this.radioButtonMusko.Name = "radioButtonMusko";
            this.radioButtonMusko.Size = new System.Drawing.Size(57, 17);
            this.radioButtonMusko.TabIndex = 6;
            this.radioButtonMusko.TabStop = true;
            this.radioButtonMusko.Text = "Musko";
            this.radioButtonMusko.UseVisualStyleBackColor = true;
            // 
            // radioButtonZensko
            // 
            this.radioButtonZensko.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonZensko.AutoSize = true;
            this.radioButtonZensko.Location = new System.Drawing.Point(327, 211);
            this.radioButtonZensko.Name = "radioButtonZensko";
            this.radioButtonZensko.Size = new System.Drawing.Size(61, 17);
            this.radioButtonZensko.TabIndex = 7;
            this.radioButtonZensko.TabStop = true;
            this.radioButtonZensko.Text = "Zensko";
            this.radioButtonZensko.UseVisualStyleBackColor = true;
            // 
            // checkBoxStudent
            // 
            this.checkBoxStudent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxStudent.AutoSize = true;
            this.checkBoxStudent.Location = new System.Drawing.Point(87, 301);
            this.checkBoxStudent.Name = "checkBoxStudent";
            this.checkBoxStudent.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.checkBoxStudent.Size = new System.Drawing.Size(40, 14);
            this.checkBoxStudent.TabIndex = 8;
            this.checkBoxStudent.UseVisualStyleBackColor = true;
            // 
            // buttonOcisti
            // 
            this.buttonOcisti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOcisti.Location = new System.Drawing.Point(142, 386);
            this.buttonOcisti.Name = "buttonOcisti";
            this.buttonOcisti.Size = new System.Drawing.Size(75, 23);
            this.buttonOcisti.TabIndex = 9;
            this.buttonOcisti.Text = "Ocisti";
            this.buttonOcisti.UseVisualStyleBackColor = true;
            this.buttonOcisti.Click += new System.EventHandler(this.buttonOcisti_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDodaj.Location = new System.Drawing.Point(320, 386);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 10;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Student;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.RadioButton radioButtonMusko;
        private System.Windows.Forms.RadioButton radioButtonZensko;
        private System.Windows.Forms.CheckBox checkBoxStudent;
        private System.Windows.Forms.Button buttonOcisti;
        private System.Windows.Forms.Button buttonDodaj;
    }
}

