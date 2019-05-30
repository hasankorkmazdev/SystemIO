using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemIOproject.Classes;

namespace SystemIOproject.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        int GirisSay = 2;
        private void button2_Click(object sender, EventArgs e)
        {
            LoginGiris lg = new LoginGiris();
            bool durum;
            

            durum = lg.LoginControl(txtLogin.Text, txtPass.Text);
            if (durum.Equals(true))
            {
                MessageBox.Show("Giriş Başarılı...\n" + "Hoşgeldiniz\n" + txtLogin.Text + " Bey" + "\nYönlendiriliyorsunuz...",
                    "Login Succes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
            else
            {
                if (GirisSay == 0)
                {
                    MessageBox.Show("Giriş Denemeleriniz Başarısız Oldu...\n" + +GirisSay + " Hakkınız Kaldığı için Uygulama Kapatılıyor",
                    "Login Unsuccesful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                    Application.Exit();

                }
                else
                {
                    
                    MessageBox.Show("Giriş Başarısız Oldu...\n" + +GirisSay + " Deneme Hakkınız Kaldı...",
                        "Login Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                    GirisSay--;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Uygulama Sonlandırılır
            Application.Exit();
        }

        private void lblKayıt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Kayıt Penceresi Açılır
            LoginKayit yeniKayit = new LoginKayit();
            yeniKayit.Show();
        }
    }
}
