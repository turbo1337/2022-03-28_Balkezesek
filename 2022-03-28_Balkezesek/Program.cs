using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_28_Balkezesek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<sportolo> sportolok = new List<sportolo>();
            foreach (var sor in File.readallines("balkesezek.csv").skip(1))
            {
                sportolok.Add(new sportolo(sor));
            }

            Console.ReadKey();
        }
    }
}
