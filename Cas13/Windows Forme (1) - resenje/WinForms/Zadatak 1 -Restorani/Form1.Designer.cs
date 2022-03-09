namespace Zadatak_1__Restorani
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSviRestorani = new System.Windows.Forms.TabPage();
            this.dataGridViewRestorani = new System.Windows.Forms.DataGridView();
            this.tabDodajRestoran = new System.Windows.Forms.TabPage();
            this.btnDodajRestoran = new System.Windows.Forms.Button();
            this.dodavanjeRestorana1 = new Zadatak_1__Restorani.DodavanjeRestorana();
            this.tabControl1.SuspendLayout();
            this.tabSviRestorani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestorani)).BeginInit();
            this.tabDodajRestoran.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSviRestorani);
            this.tabControl1.Controls.Add(this.tabDodajRestoran);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSviRestorani
            // 
            this.tabSviRestorani.Controls.Add(this.dataGridViewRestorani);
            this.tabSviRestorani.Location = new System.Drawing.Point(4, 22);
            this.tabSviRestorani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSviRestorani.Name = "tabSviRestorani";
            this.tabSviRestorani.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSviRestorani.Size = new System.Drawing.Size(592, 340);
            this.tabSviRestorani.TabIndex = 1;
            this.tabSviRestorani.Text = "SviRestorani";
            this.tabSviRestorani.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRestorani
            // 
            this.dataGridViewRestorani.AllowUserToAddRows = false;
            this.dataGridViewRestorani.AllowUserToDeleteRows = false;
            this.dataGridViewRestorani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRestorani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRestorani.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewRestorani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewRestorani.Name = "dataGridViewRestorani";
            this.dataGridViewRestorani.ReadOnly = true;
            this.dataGridViewRestorani.RowTemplate.Height = 24;
            this.dataGridViewRestorani.Size = new System.Drawing.Size(588, 336);
            this.dataGridViewRestorani.TabIndex = 0;
            // 
            // tabDodajRestoran
            // 
            this.tabDodajRestoran.Controls.Add(this.btnDodajRestoran);
            this.tabDodajRestoran.Controls.Add(this.dodavanjeRestorana1);
            this.tabDodajRestoran.Location = new System.Drawing.Point(4, 22);
            this.tabDodajRestoran.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDodajRestoran.Name = "tabDodajRestoran";
            this.tabDodajRestoran.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDodajRestoran.Size = new System.Drawing.Size(592, 340);
            this.tabDodajRestoran.TabIndex = 0;
            this.tabDodajRestoran.Text = "Dodaj restoran";
            this.tabDodajRestoran.UseVisualStyleBackColor = true;
            // 
            // btnDodajRestoran
            // 
            this.btnDodajRestoran.Location = new System.Drawing.Point(431, 118);
            this.btnDodajRestoran.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajRestoran.Name = "btnDodajRestoran";
            this.btnDodajRestoran.Size = new System.Drawing.Size(100, 50);
            this.btnDodajRestoran.TabIndex = 1;
            this.btnDodajRestoran.Text = "Dodaj Restoran";
            this.btnDodajRestoran.UseVisualStyleBackColor = true;
            this.btnDodajRestoran.Click += new System.EventHandler(this.btnDodajRestoran_Click);
            // 
            // dodavanjeRestorana1
            // 
            this.dodavanjeRestorana1.Location = new System.Drawing.Point(6, 5);
            this.dodavanjeRestorana1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dodavanjeRestorana1.Name = "dodavanjeRestorana1";
            this.dodavanjeRestorana1.Size = new System.Drawing.Size(377, 315);
            this.dodavanjeRestorana1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Dodavanje restorana";
            this.tabControl1.ResumeLayout(false);
            this.tabSviRestorani.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRestorani)).EndInit();
            this.tabDodajRestoran.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDodajRestoran;
        private System.Windows.Forms.TabPage tabSviRestorani;
        private System.Windows.Forms.Button btnDodajRestoran;
        private DodavanjeRestorana dodavanjeRestorana1;
        private System.Windows.Forms.DataGridView dataGridViewRestorani;
    }
}

