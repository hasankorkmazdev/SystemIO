using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SystemIOproject.Classes
{
    public class Personel
    {
        private string _PersonelAdi, _PersonelSoyadi, _PersonelMeslek, _PersonelEmail;
        private Cinsiyet _PersonelCinsiyet;
        private MedeniHal _PersonelMedeni;
        private double _PersonelMaas;
        private DateTime _PersonelDogumtarihi;
        private string _PersonelAddress;
        private List<Ajanda> _PersonelAjanda;
        private short _PersonelYas;
        private double tamponbellek;
        public enum Cinsiyet
        {
            Erkek = 0,
            Kadın = 1
        }
        public enum MedeniHal
        {
            Bekar = 0,
            Evli = 1
        }

        /// <summary>
        /// Boş Yapıcı Metot Bazı Fonksyonlara Doğrudan erişmek için Kullanıldı
        /// </summary>
        public Personel()
        {
            ///Dosyadan oku metodu çağrılabilmesi için boş yapıcı metod oluşturuldu
            /// Bunun yerine static metotda tanımlayabilirdik.
        }
        /// <summary>
        /// Personel Sınıfının Ad Soyad Yapıcı Metodu
        /// </summary>
        /// <param name="PersonelAdi">Personel Adı</param>
        /// <param name="PersonelSoyadi">Personel Soyadı</param>
        public Personel(string PersonelAdi, string PersonelSoyadi)
        {
            this._PersonelAdi = PersonelAdi;
            this._PersonelSoyadi = PersonelSoyadi;
        }

        #region Getter-Setter
        public string PersonelAdi { get => _PersonelAdi; set => _PersonelAdi = value; }
        public string PersonelSoyadi { get => _PersonelSoyadi; set => _PersonelSoyadi = value; }
        public string PersonelMeslek { get => _PersonelMeslek; set => _PersonelMeslek = value; }
        public Cinsiyet PersonelCinsiyet { get => _PersonelCinsiyet; set => _PersonelCinsiyet = value; }
        public MedeniHal PersonelMedeni { get => _PersonelMedeni; set => _PersonelMedeni = value; }
        public double PersonelMaas { get => _PersonelMaas; set => _PersonelMaas = value; }
        public DateTime PersonelDogumtarihi { get => _PersonelDogumtarihi; set => _PersonelDogumtarihi = value; }
        public string PersonelEmail { get => _PersonelEmail; set => _PersonelEmail = value; }
        public string PersonelAddress { get => _PersonelAddress; set => _PersonelAddress = value; }
        public List<Ajanda> PersonelAjanda { get => _PersonelAjanda; set => _PersonelAjanda = value; }

        public short PersonelYas
        {
            get
            {
                TimeSpan ts = DateTime.Now - _PersonelDogumtarihi;
                tamponbellek = ts.TotalDays / 365;
                _PersonelYas = (short)Math.Floor(tamponbellek);
                return _PersonelYas;
            }
        }


        #endregion

        /// <summary>
        /// Verilen Miktar Kadar Zam Yapar
        /// </summary>
        /// <param name="zamMiktar"> </param>
        /// <returns></returns>
        public bool ZamYap(double zamMiktar)
        {
            if (_PersonelMaas > 0)
            {
                _PersonelMaas = PersonelMaas + zamMiktar;
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 57 Yaşına Kalan Gün Sayısını Hesaplar
        /// </summary>
        /// <returns>-1 Dönerse Kişi Emeklidir</returns>
        ///<returns>Diğer Koşullarda Emekliliğe Kalan Süre Hesaplar</returns>
        public int KalanGünSayısı()
        {
            int kalangun;
            /// Şuanki Yaş Hesaplanır Ve Emeklilik için Doldurulması gereken süreden çıkarılır
            TimeSpan kalan = DateTime.Now - _PersonelDogumtarihi;
            kalangun = (57 * 365 - (kalan.Days));
            if (kalangun <= 0)
            {
                return -1;
            }
            else
            {
                return kalangun;
            }
        }
        public void dosyayaYaz()
        {
            FileStream fs;
            //Çalışılacak Dosya Yolu
            string Path = Application.StartupPath + @"\Personeller.txt";
            if (File.Exists(Path))//Personeller.txt Varmı ?
                fs = new FileStream(Path, FileMode.Append, FileAccess.Write);//Evet Var
                                                                             //Yolu,  Dosyanın Varlığı, Kullanım Tipi
            else
                fs = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write);

            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(_PersonelAdi + "|");
            sw.Write(_PersonelSoyadi + "|");
            sw.Write(_PersonelDogumtarihi.ToShortDateString() + "|");
            sw.Write(_PersonelMeslek + "|");
            sw.Write(_PersonelCinsiyet + "|");
            sw.Write(_PersonelMedeni + "|");
            sw.Write(_PersonelMaas + "|");
            sw.Write(_PersonelEmail + "|");
            sw.Write(_PersonelAddress + "|");
            foreach (var item in _PersonelAjanda)
            {
                sw.Write(item.TelAdi + "," + item.TelNumara + "+");
            }
            sw.WriteLine();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Flush();
            sw.Close();
            fs.Close();
            MessageBox.Show("Dosyaya yazma işlemi bitmiştir...", "Dosya Yazma İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Personeller.txt Dosyasını Okur
        /// Eğer verilen dosya yolunda Personeller.txt dosyası yok ise boş bi liste döner
        /// </summary>
        /// <returns>List<Personel> Döndürür</returns>
        public List<Personel> DosyadanOku()
        {
            //Personeller.txt deki verileri Listpersonel arrayine aktarılarak tampon bölge oluşuyor.
            List<Personel> _Personel = new List<Personel>();
            List<Ajanda> PersonelAjandası;
            string[] numaralar = new string[10];
            //Herbir Personelin 9 Adet Verisi Vardır. Bunlar
            //Ad|Soyad|DogumTarihi|Meslek|Cinsiyet|MedeniHal|Maas|Adressdir
            string[] PersonelsData = new string[10];
            string Path = Application.StartupPath + @"\Personeller.txt";
            if (File.Exists(Path))//Personeller.txt Varmı ?
            {
                FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
                //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
                //2.parametre dosyanın açılacağını,
                //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
                StreamReader sw = new StreamReader(fs);
                //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
                string yazi = sw.ReadLine();
                while (yazi != null)
                {
                    PersonelsData = yazi.Split('|');
                    Personel p = new Personel(PersonelsData[0], PersonelsData[1]);
                    p.PersonelDogumtarihi = Convert.ToDateTime(PersonelsData[2]);
                    p.PersonelMeslek = PersonelsData[3];
                    p.PersonelMaas = Convert.ToDouble(PersonelsData[6]);
                    p.PersonelEmail = PersonelsData[7];
                    p.PersonelAddress = PersonelsData[8];
                    numaralar = PersonelsData[9].Split('+');
                    string num1 = numaralar[0].Split(',')[0];
                    string num2 = numaralar[0].Split(',')[1];
                    string num3 = numaralar[1].Split(',')[0];
                    string num4 = numaralar[1].Split(',')[1];
                    PersonelAjandası = new List<Ajanda>()
                    {
                        new Ajanda()
                        {
                            TelAdi =  (numaralar[0].Split(','))[0],
                            TelNumara=(numaralar[0].Split(','))[1]

                        },
                        new Ajanda()
                        {
                             TelAdi =  (numaralar[1].Split(','))[0],
                            TelNumara=(numaralar[1].Split(','))[1]
                        }
                    };
                    p.PersonelAjanda = PersonelAjandası;
                    //PersonelCinsiyetin Öğreniliyor
                    if (PersonelsData[4].Equals(Cinsiyet.Erkek.ToString()))
                        p.PersonelCinsiyet = Cinsiyet.Erkek;
                    else if (PersonelsData[4].Equals(Cinsiyet.Kadın.ToString()))
                        p.PersonelCinsiyet = Cinsiyet.Kadın;
                    //Personelin Medeni Hali Öğreniliyor
                    if (PersonelsData[5].Equals(Personel.MedeniHal.Bekar.ToString()))
                        p.PersonelMedeni = MedeniHal.Bekar;
                    else if (PersonelsData[5].Equals(Personel.MedeniHal.Evli.ToString()))
                        p.PersonelMedeni = MedeniHal.Evli;

                    //Hazırlamış Olduğumuz Diziye Personelimizi Ekliyoruz 
                    _Personel.Add(p);
                    yazi = sw.ReadLine();
                }
                sw.Close();
                fs.Close();
                //İşimiz bitince kullandığımız nesneleri iade ettik.

                return _Personel;
            }
            else
            {
                return _Personel;
            }

        }
    }
}
