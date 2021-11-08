using System;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] massiv = new int[6];

            Console.WriteLine("input value of elements: ");


            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write($"Massiv's elements {i}\t");
                massiv[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nMassiv is  ");
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write($"  {massiv[i]}");

            }
            Array.Sort(massiv);
            Array.Reverse(massiv);
            Console.WriteLine();
            Console.Write($" \nПо убыванию: ");
            for (int i = 0; i < massiv.Length; i++)
            {

                Console.Write(massiv[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nTASK  2 ");   // task2



            int[,] massiv2 = new int[3, 3] { { 699, 1, 3 }, { 4, 25555, 6 }, { 147, 8, 999 } };

                      
            for  (int i=0; i<3; i++)
            {
                int max = massiv2[i, 0];

                for (int j = 0; j < 3; j++)
                {
                  
                    if (massiv2[i,j]>max)
                    {
                        max = massiv2[i, j];                      
                    }
                }
                Console.WriteLine($"\nмаксимальное значение ряда {i + 1}:   {max}");
                Console.WriteLine();


            }
                                  

        }
    }
}
