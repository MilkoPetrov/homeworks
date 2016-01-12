using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args) {


            Console.WriteLine("enter number");
            int a, first = 0, second = 1, next;

            
            //int x = 4;
            //Console.WriteLine("x++ {0}", ++x);
            //Console.WriteLine("after {0}", x);
            
            a =  Int32.Parse(Console.ReadLine());
            int[] mass = new int[a];
                      
            
            for (int i = 0; i < a; i++)
            {
                if (i <= 1)
                {
                    next = i;
                    
                }
                else
                {
                    next = first + second;
                    first = second;
                    second = next;

                }
                Console.WriteLine(i);
                mass[i] = next;
                

            }
            Console.WriteLine(string.Join(",", mass));

            
            

        }
    }
}
