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
    public partial class PersonelAra : Form
    {
        Personel pers = new Personel();
        List<Personel> persListe = new List<Personel>();
        public PersonelAra()
        {
            InitializeComponent();
            persListe = pers.DosyadanOku();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            foreach (var item in persListe)
            {
                if (item.PersonelAdi == txtAra.Text)
                {
                    PersKayit pk = new PersKayit(item);
                    pk.MdiParent = this.MdiParent;//  pk nın babası bunun babasıdır.
                    pk.Show();
                    this.Close();
                }
            }
            
        }
    }
}
