using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin = Console.ReadLine();
            List<char> binList = new List<char>();
            for (int i = 0; i < bin.Length; i++)
            {
                binList.Add(bin[i]);
            }
            int len = bin.Length;
            int diff = 4 - (len % 4); ;
            if (len % 4 != 0)
            {
                binList.Reverse();
                for (int i = 0; i < diff; i++)
                {
                    binList.Add('0');
                }
                binList.Reverse();
            }
            string[] binByFours = new string[binList.Count / 4];
            int p = 0;
            for (int i = 0; i < binByFours.Length; i++)
            {
                int count = 0;
                while (count < 4)
                {
                    binByFours[i] += binList[p];
                    p++;
                    count++;
                }
            }
            StringBuilder result = new StringBuilder();
            foreach (string s in binByFours)
            {
                switch (s)
                {
                    case ("0000"):
                        result.Append('0');
                        break;
                    case ("0001"):
                        result.Append('1');
                        break;
                    case ("0010"):
                        result.Append('2');
                        break;
                    case ("0011"):
                        result.Append('3');
                        break;
                    case ("0100"):
                        result.Append('4');
                        break;
                    case ("0101"):
                        result.Append('5');
                        break;
                    case ("0110"):
                        result.Append('6');
                        break;
                    case ("0111"):
                        result.Append('7');
                        break;
                    case ("1000"):
                        result.Append('8');
                        break;
                    case ("1001"):
                        result.Append('9');
                        break;
                    case ("1010"):
                        result.Append('A');
                        break;
                    case ("1011"):
                        result.Append('B');
                        break;
                    case ("1100"):
                        result.Append('C');
                        break;
                    case ("1101"):
                        result.Append('D');
                        break;
                    case ("1110"):
                        result.Append('E');
                        break;
                    case ("1111"):
                        result.Append('F');
                        break;
                    default:
                        result.Append("Error!");
                        break;
                }
            }
            Console.WriteLine(result.ToString());

        }
    }
}
