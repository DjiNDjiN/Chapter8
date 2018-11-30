using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexNumber = Console.ReadLine();
            uint decNumber = 0;
            uint multiplicator = 1;
            for (int i = hexNumber.Length - 1; i >= 0; i--)
            {
                if (hexNumber[i] == 'A')
                {
                    decNumber += 10 * multiplicator;
                }
                if (hexNumber[i] == 'B')
                {
                    decNumber += 11 * multiplicator;
                }
                if (hexNumber[i] == 'C')
                {
                    decNumber += 12 * multiplicator;
                }
                if (hexNumber[i] == 'D')
                {
                    decNumber += 13 * multiplicator;
                }
                if (hexNumber[i] == 'E')
                {
                    decNumber += 14 * multiplicator;
                }
                if (hexNumber[i] == 'F')
                {
                    decNumber += 15 * multiplicator;
                }
                else if (((uint)hexNumber[i] - '0') < 10)
                {
                    decNumber += ((uint)hexNumber[i] - '0') * multiplicator;
                }
                multiplicator *= 16;
            }
            Console.WriteLine(decNumber);

        }
    }
}
