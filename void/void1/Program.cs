﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace void1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = PrintNumbersSums(a, b);
            Console.WriteLine(c);
        }

        private static int PrintNumbersSums(int a, int b)
        {
            int sum = a + b;
            return sum;
        }


    }
}



