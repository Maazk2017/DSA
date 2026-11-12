using System;
using System.Collections.Generic;
using System.Text;

namespace Array_List_Questions
{
    internal class Questions
    {
        public void PascalTriangle()
        {
            int rowsNum = 5;
            int[][] result = new int[rowsNum][];

            for (int i = 0; i < rowsNum; i++)
            {
                // 1. Initialize the inner array for the current row
                result[i] = new int[i + 1];

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        result[i][j] = 1;
                    }
                    else
                    {
                        result[i][j] = result[i - 1][j - 1] + result[i - 1][j];
                    }
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[i].Length; j++)
                {
                    Console.Write(result[i][j]);
                }
                Console.WriteLine();
            }
        }

        public void spiralTraverse()
        {
            int[,] arr =
            {
                { 1,  2,  3,  4,  5,  6 },
                { 7,  8,  9, 10, 11, 12 },
                {13, 14, 15, 16, 17, 18 },
                {19, 20, 21, 22, 23, 24 },
                {25, 26, 27, 28, 29, 30 }
            };

            int fr = 0;                          // First Row
            int lr = arr.GetLength(0) - 1;       // Last Row (dimension 0 = 5)
            int fc = 0;                          // First Column
            int lc = arr.GetLength(1) - 1;       // Last Column (dimension 1 = 6)

            while (fr <= lr && fc <= lc)
            {
                // 1. Traverse top row (left to right)
                for (int col = fc; col <= lc; col++)
                {
                    Console.Write(arr[fr, col] + " ");
                }
                fr++;

                // 2. Traverse right column (top to bottom)
                for (int row = fr; row <= lr; row++)
                {
                    Console.Write(arr[row, lc] + " ");
                }
                lc--;

                // 3. Traverse bottom row (right to left), if rows remain
                if (fr <= lr)
                {
                    for (int col = lc; col >= fc; col--)
                    {
                        Console.Write(arr[lr, col] + " ");
                    }
                    lr--;
                }

                // 4. Traverse left column (bottom to top), if columns remain
                if (fc <= lc)
                {
                    for (int row = lr; row >= fr; row--)
                    {
                        Console.Write(arr[row, fc] + " ");
                    }
                    fc++;
                }
            }
        }

        public void multiplyMatrix()
        {
            int[,] arr1 = { { 1, 2 }, { 2, 1 } };
            int[,] arr2 = { { 2, 0 }, { -1, 3 } };

            int rows1 = arr1.GetLength(0);
            int cols1 = arr1.GetLength(1);
            int rows2 = arr2.GetLength(0);
            int cols2 = arr2.GetLength(1);

            // Ensure multiplication is valid (columns of arr1 must equal rows of arr2)
            if (cols1 != rows2)
            {
                Console.WriteLine("Matrix multiplication is not possible with these dimensions.");
                return;
            }

            // arr3 will have dimensions: rows of arr1 x columns of arr2
            int[,] arr3 = new int[rows1, cols2];

            // Standard Matrix Multiplication Algorithm (3 Loops: i, j, k)
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    arr3[i, j] = 0; // Initialize the cell
                    for (int k = 0; k < cols1; k++)
                    {
                        arr3[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }

            // Optional: Print the result to verify
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(arr3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
