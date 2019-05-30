using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIOproject.Classes
{
    class LoginGiris
    {
        /// <summary>
        /// Eğer Giriş doğru ise tru değilse false döner
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns>true Succes</returns>
        /// <returns>false Error</returns>
        public bool LoginControl(string UserName, string Password)
        {   
            //2 Değişkenimiz var Birincisi Kullanıcı Adı ikincisi Şifre Bu Yüzden 2 Elemanlı Sabit Dizi Tanımladık
            string[] UserNameAndPass = new string[2];
            string Path = Application.StartupPath + @"\users.txt";
            if (File.Exists(Path))//user.txt Varmı ? //Var
            {
                //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
                FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
                StreamReader sw = new StreamReader(fs);
                string yazi = sw.ReadLine();
                while (yazi != null)
                {
                    UserNameAndPass = yazi.Split('|');
                    if (UserNameAndPass[0].Equals(UserName) && UserNameAndPass[1].Equals(Password))
                    {
                        return true;
                    }
                    yazi = sw.ReadLine();
                }
                //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
                //Son satır okunduktan sonra okuma işlemini bitirdik
                sw.Close();
                fs.Close();
                //İşimiz bitince kullandığımız nesneleri iade ettik.
                return false;
            }
            else
                MessageBox.Show("Login.txt Bulunamadı ","Login Dosyası Oluşmamış", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            return false;
        }

        public bool YeniKayıt(string UserName,string Password)
        {
            FileStream fs;
            //Çalışılacak Dosya Yolu
            string Path = Application.StartupPath + @"\users.txt";
            if (File.Exists(Path))//Personeller.txt Varmı ?
                fs = new FileStream(Path, FileMode.Append, FileAccess.Write);//Evet Var
                                                                             //Yolu,  Dosyanın Varlığı, Kullanım Tipi
            else
                fs = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write);

            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(UserName + "|");
            sw.WriteLine(Password );
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Flush();
            sw.Close();
            fs.Close();
            MessageBox.Show("Dosyaya yazma işlemi bitmiştir...", "Dosya Yazma İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
    }
}
