using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for (i = a + 1; i <= b - 1; i++)
            {
                if (i % 5 == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
