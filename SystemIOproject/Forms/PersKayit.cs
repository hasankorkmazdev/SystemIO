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
    public partial class PersKayit : Form
    {
        public PersKayit()
        {
            InitializeComponent();
        }

        #region Aranan Personelin Bilgileri
        public PersKayit(Personel p)
        {
            InitializeComponent();
            txtAd.Text = p.PersonelAdi;
            txtSoyad.Text = p.PersonelSoyadi;
            txtMeslek.Text = p.PersonelMeslek;
            NumericMaas.Value = (decimal)p.PersonelMaas;
            DateTimeDogum.Value = (DateTime)p.PersonelDogumtarihi;
            richAdres.Text = p.PersonelAddress;
            txtMail.Text = p.PersonelEmail;
            txtIs.Text = p.PersonelAjanda[0].TelNumara;
            txtGSM.Text = p.PersonelAjanda[1].TelNumara;
            if (p.PersonelMedeni == Personel.MedeniHal.Bekar)
            {
                RadioBekar.Checked = true;
            }
            else
            {
                RadioEvli.Checked = true;
            }
            if (p.PersonelCinsiyet == Personel.Cinsiyet.Kadın)
            {
                RadioKadın.Checked = true;

            }
            else
            {
                RadioErkek.Checked = true;
            }
            
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            #region Yeni Personel Kaydet
            List<Ajanda> PersonelAjandası;

            Personel pers = new Personel(txtAd.Text, txtSoyad.Text);
            if (RadioErkek.Checked.Equals(true))
            {
                pers.PersonelCinsiyet = Personel.Cinsiyet.Erkek;
            }
            else if (RadioKadın.Checked.Equals(true))
            {
                pers.PersonelCinsiyet = Personel.Cinsiyet.Kadın;
            }
            if (RadioEvli.Checked.Equals(true))
            {
                pers.PersonelMedeni = Personel.MedeniHal.Evli;

            }
            else
            {
                pers.PersonelMedeni = Personel.MedeniHal.Bekar;

            }

            PersonelAjandası = new List<Ajanda>()
            {
                new Ajanda()
                {
                    TelAdi = "İş Telefonu",
                    TelNumara = txtIs.Text
                },
                new Ajanda()
                {
                    TelAdi = "GSM",
                    TelNumara = txtGSM.Text
                }
            };


            pers.PersonelDogumtarihi = DateTimeDogum.Value;
            pers.PersonelMaas = (double)NumericMaas.Value;
            pers.PersonelMeslek = txtMeslek.Text;
            pers.PersonelEmail = txtMail.Text;
            pers.PersonelAddress = richAdres.Text;
            pers.PersonelAjanda = PersonelAjandası;
            pers.dosyayaYaz();
            #endregion
        }
        //Bu Formu Kapat
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
