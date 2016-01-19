using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = new int[,]
            {
                {33,12,14 },
                {10,16,3 },
                {13,22,25 }
            };
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (mass[i,j] %2 ==0)
                    {
                        Console.WriteLine(mass[i,j]);
                    }
                }
            }


                

        }
    }
}
