using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{

    using System;
    using System.Linq;
    using System.Text;

    class FromArabicToRomanNumberDemo
    {
        static string ConvertArabicToRomanNumber(int arabicNumber)
        {
            StringBuilder romanNumber = new StringBuilder();

            for (int i = 0; i < arabicNumber; i++)
            {
                while (arabicNumber >= 1000)
                {
                    romanNumber.Append("M");
                    arabicNumber = arabicNumber - 1000;
                }
                while (arabicNumber >= 900)
                {
                    romanNumber.Append("CM");
                    arabicNumber = arabicNumber - 900;
                }
                while (arabicNumber >= 500)
                {
                    romanNumber.Append("D");
                    arabicNumber = arabicNumber - 500;
                }
                while (arabicNumber >= 400)
                {
                    romanNumber.Append("CD");
                    arabicNumber = arabicNumber - 400;
                }
                while (arabicNumber >= 100)
                {
                    romanNumber.Append("C");
                    arabicNumber = arabicNumber - 100;
                }
                while (arabicNumber >= 90)
                {
                    romanNumber.Append("XC");
                    arabicNumber = arabicNumber - 90;
                }
                while (arabicNumber >= 50)
                {
                    romanNumber.Append("L");
                    arabicNumber = arabicNumber - 50;
                }
                while (arabicNumber >= 40)
                {
                    romanNumber.Append("XL");
                    arabicNumber = arabicNumber - 40;
                }

                while (arabicNumber >= 10)
                {
                    romanNumber.Append("X");
                    arabicNumber = arabicNumber - 10;
                }
                while (arabicNumber >= 9)
                {
                    romanNumber.Append("IX");
                    arabicNumber = arabicNumber - 9;
                }
                while (arabicNumber >= 5)
                {
                    romanNumber.Append("V");
                    arabicNumber = arabicNumber - 5;
                }
                while (arabicNumber >= 4)
                {
                    romanNumber.Append("IV");
                    arabicNumber = arabicNumber - 4;
                }
                while (arabicNumber >= 1)
                {
                    romanNumber.Append("I");
                    arabicNumber = arabicNumber - 1;
                }
            }
            return romanNumber.ToString();
        }

        static void Main(string[] args)
        {
            int arabicNumber = int.Parse(Console.ReadLine());

            if (arabicNumber < 4000 && arabicNumber > 0)
            {
                string romanNumber = ConvertArabicToRomanNumber(arabicNumber);
                Console.WriteLine(romanNumber);
            }
            else
            {
                Console.WriteLine("Arabic number must be in range[1-3999]!");
            }
        }
    }

}
