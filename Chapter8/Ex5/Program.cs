using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin = Console.ReadLine();  // Read the input like a string
            long dec = 0;
            long mult = 1;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (bin[i] == '0')
                {
                    dec += 0 * mult;
                }
                if (bin[i] == '1')
                {
                    dec += 1 * mult;
                }
                mult *= 2;
            }
            Console.WriteLine(dec);

        }
    }

}

