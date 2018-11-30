using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 151;
            int number2 = 35;
            int number3 = 43;
            int number4 = 251;
            float number5 = -0.41f; //It doesn’t work with the method Convert below          
            float printNumber5 = number5;
            Console.WriteLine(Convert.ToString(number1, 2));
            Console.WriteLine(Convert.ToString(number2, 2));
            Console.WriteLine(Convert.ToString(number3, 2));
            Console.WriteLine(Convert.ToString(number4, 2));

            int i = 0;
            char[] numbs = new char[32];
            bool isPositive = true;
            while (i < 32)
            {
                number5 *= 2;

                if (number5 < 0)
                {
                    isPositive = false;
                    number5 *= -1;
                }

                if (number5 - 1 > 0)
                {
                    number5 -= 1;
                    numbs[i] = (char)1;
                }
                else
                {
                    numbs[i] = (char)0;
                }
                i++;
            }
            if (isPositive == false)
            {
                Console.Write("-");
            }
            Console.Write("0.");

            foreach (var digit in numbs)
            {
                Console.Write((int)digit);
            }
            Console.WriteLine();

        }
    }
}
