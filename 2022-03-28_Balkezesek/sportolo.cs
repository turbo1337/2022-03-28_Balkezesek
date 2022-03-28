using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_28_Balkezesek
{
    class sportolo
    {

        public string Név { get; set; }
        public string Elsö { get; set; }
        public string Utolso { get; set; }
        public int Súly { get; set; }
        public int Magasság { get; set; }

        public sportolo(string sor)
        {
            string[] t = sor.Split(';');
            Név = t[0];
            Elsö = t[1];
            Utolso = t[2];
            Súly= int.Parse(t[3]);
            Magasság=int.Parse(t[4]);
        }
    }
}
