using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace симв_массив_обратный_порядок
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbs = new char[] { 'A', 'Z', 'B', 'Y', 'D', 'S', 'O' };
            Console.WriteLine("Массив symbs:");
            for(int k = 0; k < symbs.Length; k++)
            {
                Console.Write("| "+symbs[k] + " ");
            }
            Console.WriteLine("|");

        Console.WriteLine("Массив symbs в обратном порядке:");
            for (int k = symbs.Length-1;k>=0; k--)
            {
                Console.Write("| "+symbs[k] + " ");
            }
            Console.WriteLine("|");
            Console.ReadLine();
        }
    }
}
