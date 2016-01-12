using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int a = Int32.Parse(Console.ReadLine());
            int[] Array = new int[] { 10, 20, 30, 10, 20 };

            for (int i = 0; i < Array.Length; i++)

            {
                if (Array[i] == a)
                {
                    Console.WriteLine("ok {0}", i);
                    return;


                }





            }
            Console.WriteLine("not ok");
        }
    }
}
