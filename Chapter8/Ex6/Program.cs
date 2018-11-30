using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            List<string> hexCode = new List<string>();

            do
            {
                uint remind = number % 16;
                number = number / 16;
                switch (remind)
                {
                    case 10:
                        hexCode.Add("A");
                        break;
                    case 11:
                        hexCode.Add("B");
                        break;
                    case 12:
                        hexCode.Add("C");
                        break;
                    case 13:
                        hexCode.Add("D");
                        break;
                    case 14:
                        hexCode.Add("E");
                        break;
                    case 15:
                        hexCode.Add("F");
                        break;
                    default:
                        hexCode.Add(remind.ToString());
                        break;
                }

            } while (number != 0);
            hexCode.Reverse();

            foreach (string digit in hexCode)
            {
                Console.Write(digit);
            }
            Console.WriteLine();

        }
    }
}
