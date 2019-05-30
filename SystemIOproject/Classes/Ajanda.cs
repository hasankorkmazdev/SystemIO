using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOproject.Classes
{
    public class Ajanda
    {
        private string _telAdi, _TelNumara;

        #region Getter-Setter
        public string TelAdi { get => _telAdi; set => _telAdi = value; }
        public string TelNumara { get => _TelNumara; set => _TelNumara = value; }
        #endregion
    }
}
