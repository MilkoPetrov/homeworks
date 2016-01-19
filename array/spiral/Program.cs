using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number for a ");
            int a = int.Parse(Console.ReadLine());
            int[,] b = new int[a, a];
            int c = 0;
            int d = 1;

            int len = b.GetLength(1);
            //0 left - right
            //1 top - down
            //2 right - left
            //3 down - top
            while (c<4)
            {
                if(c == 0)
                {

                    for (int j = 0; j < len; j++)
                    {
                        b[c, j] = d;
                        d++;
                    }

                }
                else if(c == 1) {
                    d--;
                    for (int j = 0; j < len; j++)
                    {
                        b[j, len-1] = d;
                        d++;
                    }
                }
                else if(c == 3) {
                    d--;
                    for (int j = len-1; j >= 0; j--)
                    {
                        b[c, j] = d;
                        d++;
                    }
                }
                else if (c == 2) {
                    //d--;
                    //for (int j = len - 1; j >= 0; j--)
                    //{
                    //    b[j, len - 1] = d;
                    //    d++;
                    //}
                }

                c++;
            }

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
