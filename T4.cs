using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, t;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                t = a;
                a = b;
                b = t;
            }
            if (b > c)
            {
                t = b;
                b = c;
                c = t;
            }
            Console.WriteLine(a + "" + b + "" + c);
            Console.ReadLine();
        }
    }
}
