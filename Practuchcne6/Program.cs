using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practuchne6
{
    class Program
    {
        static void Main()
        {

            int[,] mas = new int[4, 5];            
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(0, 5);
                }
            }                    
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }       
            int n = 0;
            bool indikator;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                indikator = true;
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] == 0)
                    {
                        indikator = false;
                    }
                }
                if (indikator) { n++; }
            }


            Console.WriteLine("к-сть нульових стр1чок = " + n);

        }
        private static Random rnd = new Random();
    }
}