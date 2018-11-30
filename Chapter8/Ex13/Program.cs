using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    class ConvertFromStoDBasedSystemDemo
    {
        const int ASCII_CODE_FOR_NUMBERS = 48;
        const int ASCCI_CODE_FOR_LETTERS = 7;

        static void Main(string[] args)
        {
            int sBase = int.Parse(Console.ReadLine());
            int dBase = int.Parse(Console.ReadLine());
            string numberInSbasedSystem = Console.ReadLine();

            long decimalNumber = ConvertFromSbasedSystemToDecimal(numberInSbasedSystem, sBase);
            string numberInDBasedSystem = ConvertFromDecimalToDBasedSystem(decimalNumber, dBase);

            Console.WriteLine(numberInDBasedSystem);
        }

        public static long ConvertFromSbasedSystemToDecimal(string numberInSbasedSystem, int sBase)
        {
            long decimalNumber = 0;
            int currentPossition = numberInSbasedSystem.Length - 1;
            int numberAtPosition;
            int counter = 0;

            while (currentPossition >= 0)
            {
                //Finding the number real value as removing the ASCII extended code
                numberAtPosition = numberInSbasedSystem[currentPossition] - ASCII_CODE_FOR_NUMBERS;

                //Removing the difference between special symbols and letters represented in ASCII table
                if (numberAtPosition > 9)
                {
                    numberAtPosition -= ASCCI_CODE_FOR_LETTERS;
                }

                decimalNumber += numberAtPosition * (int)Math.Pow(sBase, counter++);
                currentPossition--;
            }
            return decimalNumber;
        }

        public static string ConvertFromDecimalToDBasedSystem(long decimalNumber, int dBase)
        {
            StringBuilder reversedNumberInDBasedSystem = new StringBuilder();

            while (decimalNumber != 0)
            {
                if (decimalNumber % dBase <= 9)
                {
                    reversedNumberInDBasedSystem.Append(decimalNumber % dBase);
                }
                else
                {
                    reversedNumberInDBasedSystem.Append((char)(decimalNumber % dBase + ASCII_CODE_FOR_NUMBERS + ASCCI_CODE_FOR_LETTERS));
                }
                decimalNumber /= dBase;
            }

            StringBuilder numberInDBasedSystem = new StringBuilder();

            for (int i = reversedNumberInDBasedSystem.Length - 1; i >= 0; i--)
            {
                numberInDBasedSystem.Append(reversedNumberInDBasedSystem[i]);
            }
            return numberInDBasedSystem.ToString();
        }
    }

}
