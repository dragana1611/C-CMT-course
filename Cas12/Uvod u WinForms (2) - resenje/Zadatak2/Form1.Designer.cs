namespace Zadatak2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.radSaBazomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeSkoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeUcenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radSaBazomToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // radSaBazomToolStripMenuItem
            // 
            this.radSaBazomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodavanjeSkoleToolStripMenuItem,
            this.dodavanjeUcenikaToolStripMenuItem});
            this.radSaBazomToolStripMenuItem.Name = "radSaBazomToolStripMenuItem";
            this.radSaBazomToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.radSaBazomToolStripMenuItem.Text = "Rad sa bazom";
            // 
            // dodavanjeSkoleToolStripMenuItem
            // 
            this.dodavanjeSkoleToolStripMenuItem.Name = "dodavanjeSkoleToolStripMenuItem";
            this.dodavanjeSkoleToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.dodavanjeSkoleToolStripMenuItem.Text = "Dodavanje skole";
            this.dodavanjeSkoleToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeSkoleToolStripMenuItem_Click);
            // 
            // dodavanjeUcenikaToolStripMenuItem
            // 
            this.dodavanjeUcenikaToolStripMenuItem.Name = "dodavanjeUcenikaToolStripMenuItem";
            this.dodavanjeUcenikaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.dodavanjeUcenikaToolStripMenuItem.Text = "Dodavanje ucenika";
            this.dodavanjeUcenikaToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeUcenikaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 333);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Rad sa podacima";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem radSaBazomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeSkoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeUcenikaToolStripMenuItem;
    }
}

