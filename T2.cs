﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int y1, m1, d1, y2, m2, d2, r, r1, r2, r3;
            y1 = int.Parse(Console.ReadLine());
            m1 = int.Parse(Console.ReadLine());
            d1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());
            d2 = int.Parse(Console.ReadLine());
            if (m1 <= 6)
            { r1 = 365 - (m1 - 1) * 31 + d1; }
            else
            { r1 = 365 - (186 + (m1 - 7) * 30 + d1); }
            if (m2 <= 6)
            { r2 = ((m2 - 1) * 31 + d2); }
            else
            { r2 = 186 + (m2 - 7) * 31 + d2; }
            r3 = (y2 - y1 - 1) * 365;
            r = r1 + r2 + r3;
            Console.WriteLine(r);
            Console.ReadLine();
      

        }
    }
}
