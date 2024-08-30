using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOn40
{
    internal class inimine
    {
        public string Nimi {  get; set; }
        public int Vanus { get; set; }

        public inimine(string nimi)
        {
            Nimi = nimi;
        }
        public inimine(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
    }
}
