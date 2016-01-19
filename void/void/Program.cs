using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @void
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            PrintNumbersSums(a , b);
        }

        private static void PrintNumbersSums(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        private static void PrintNumbersSums(int v)
        {
            throw new NotImplementedException();
        }
    }
}
