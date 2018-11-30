using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            string binaryNumber = Console.ReadLine();
            int decimalNumber = 1;
            for (int i = binaryNumber.Length - 2; i >= 0; i--)
            {
                decimalNumber = 2 * decimalNumber + int.Parse(binaryNumber[i].ToString());
            }
            if (binaryNumber[binaryNumber.Length - 1] == '0')
            {
                decimalNumber -= 1;
            }
            Console.WriteLine(decimalNumber);

        }
    }
}
