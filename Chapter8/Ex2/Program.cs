using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string binNum = "1111010110011110";
            int dec = Convert.ToInt32(binNum, 2);

            Console.WriteLine(dec);
            Console.WriteLine("{0:X2}", dec);

        }
    }
}
