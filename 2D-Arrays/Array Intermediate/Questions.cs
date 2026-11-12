using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Intermediate
{
    internal class Questions
    {
        public void transpose()
        {
            int[,] arr =
            {
                {2, 8, 3, 4},
                {7, 2, 1, 6},
                {5, 5, 4, 1},
                {3, 1, 8, 2}
            };

            int temp;

            for (int i=0; i<arr.GetLength(0); i++)
            {
                for (int j=i; j<arr.GetLength(1); j++)
                {
                    if (i != j)
                    {
                        temp = arr[j, i];
                        arr[j, i] = arr[i, j];
                        arr[i, j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
