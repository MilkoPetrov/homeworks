using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mass4x4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = new int[4,4];
            //Console.WriteLine(mass.GetLength(0));
            //Console.WriteLine(mass.GetLength(1));
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.WriteLine("Enter number for {0} {1}" , i,j );
                    mass[i, j] = int.Parse(Console.ReadLine());

                    if (mass[i,j] % 2 !=0)
                    {
                        mass[i, j] *= 2;
                    }
                }
            }
            for (int a = 0; a < mass.GetLength(0); a++)

            {
                for (int b = 0; b < mass.GetLength(1); b++)
                {
                    Console.Write(mass[a, b] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
