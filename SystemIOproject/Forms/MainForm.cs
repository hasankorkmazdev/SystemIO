using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SystemIOproject.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void personelAramaEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Personel Arama Penceresini Aç
            PersonelAra pa = new PersonelAra();
            pa.MdiParent = this;
            pa.Show();
            #endregion
        }
        //Uygulamayı Kapat
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void personelKayıtEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region PersonelKayıt Penceresi Aç
            PersKayit pk = new PersKayit();
            pk.MdiParent = this;
            pk.Show();
            #endregion
        }

        private void logintxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region user.txt Dosyasını Aç
            Process.Start(Application.StartupPath + @"\users.txt");
            #endregion
        }

        private void personellertxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Personeller.txt Dosyasını aç
            if (File.Exists(Application.StartupPath + @"\Personeller.txt"))
            {
                Process.Start(Application.StartupPath + @"\Personeller.txt");
            }
            else
            {
                MessageBox.Show("Personeller.txt Bulunamadı ", "Personeller Dosyası Oluşmamış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion
        }
    }
}
