using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch0208
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("radiuse? ");

            string sradiuse = Console.ReadLine();
            int radiuse = int.Parse(sradiuse);

            double arc = 2 * Math.PI * radiuse;
            double w = 3.14 * radiuse * radiuse;

            Console.WriteLine("돌레: " + arc + "\t 넓이: " + w);

        }
    }
}
