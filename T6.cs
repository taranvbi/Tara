using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, num;
            a = 0;
            num = int.Parse(Console.ReadLine());
            if (num < 10)
            { a = num; }
            else if (num < 100)
            { a = num / 10; }
            else if (num < 1000)
            { a = num / 100; }
            else if (num < 10000)
            { a = num / 1000; }
            else if (num < 100000)
            { a = num / 10000; }
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
