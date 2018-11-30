using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            string romanNumber = Console.ReadLine();
            int decimalNumber = 0;
            char[] romans = { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
            int[] arabics = { 1000, 500, 100, 50, 10, 5, 1 };
            for (int i = 0; i < romanNumber.Length - 1; i++)
            {
                int positionInRomans = 0;
                int positionInRomansNext = 0;
                for (int j = 0; j < romans.Length; j++)
                {
                    if (romanNumber[i] == romans[j])
                    {
                        positionInRomans = j;
                    }
                }
                for (int j = 0; j < romans.Length; j++)
                {
                    if (romanNumber[i + 1] == romans[j])
                    {
                        positionInRomansNext = j;
                    }
                }
                if (positionInRomans <= positionInRomansNext)
                {
                    decimalNumber += arabics[positionInRomans];
                }
                else
                {
                    decimalNumber -= arabics[positionInRomans];
                }
            }
            char lastChar = romanNumber[romanNumber.Length - 1];
            for (int i = 0; i < romans.Length; i++)
            {
                int posLastChar = 0;
                if (lastChar == romans[i])
                {
                    posLastChar = i;
                    decimalNumber += arabics[posLastChar];
                }

            }
            Console.WriteLine(decimalNumber);

        }
    }
}
