namespace SystemIOproject.Forms
{
    partial class MainForm
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
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personellertxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logintxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelKayıtEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelAramaEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.görünümToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personellertxtToolStripMenuItem,
            this.logintxtToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // personellertxtToolStripMenuItem
            // 
            this.personellertxtToolStripMenuItem.Name = "personellertxtToolStripMenuItem";
            this.personellertxtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personellertxtToolStripMenuItem.Text = "Personeller.txt";
            this.personellertxtToolStripMenuItem.Click += new System.EventHandler(this.personellertxtToolStripMenuItem_Click);
            // 
            // logintxtToolStripMenuItem
            // 
            this.logintxtToolStripMenuItem.Name = "logintxtToolStripMenuItem";
            this.logintxtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logintxtToolStripMenuItem.Text = "users.txt";
            this.logintxtToolStripMenuItem.Click += new System.EventHandler(this.logintxtToolStripMenuItem_Click);
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelKayıtEkranıToolStripMenuItem,
            this.personelAramaEkranıToolStripMenuItem});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // personelKayıtEkranıToolStripMenuItem
            // 
            this.personelKayıtEkranıToolStripMenuItem.Name = "personelKayıtEkranıToolStripMenuItem";
            this.personelKayıtEkranıToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.personelKayıtEkranıToolStripMenuItem.Text = "Personel Kayıt Ekranı";
            this.personelKayıtEkranıToolStripMenuItem.Click += new System.EventHandler(this.personelKayıtEkranıToolStripMenuItem_Click);
            // 
            // personelAramaEkranıToolStripMenuItem
            // 
            this.personelAramaEkranıToolStripMenuItem.Name = "personelAramaEkranıToolStripMenuItem";
            this.personelAramaEkranıToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.personelAramaEkranıToolStripMenuItem.Text = "Personel Arama Ekranı";
            this.personelAramaEkranıToolStripMenuItem.Click += new System.EventHandler(this.personelAramaEkranıToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 495);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelKayıtEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelAramaEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personellertxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logintxtToolStripMenuItem;
    }
}