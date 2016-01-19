using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_3x4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = new int[3, 4];
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.WriteLine("Enter number {0} {1}", j, i);
                    mass[i, j] = int.Parse(Console.ReadLine());

                }
            }
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++) 
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            } 
            

        }
    }
}
