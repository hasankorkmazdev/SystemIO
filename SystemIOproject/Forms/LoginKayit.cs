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
    public partial class LoginKayit : Form
    {
        public LoginKayit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginGiris userkayit = new LoginGiris();
            userkayit.YeniKayıt(txtLogin.Text, txtPass.Text);
        }
    }
}
