using System;
using System.Collections.Generic;
using System.Text;

namespace _2DArray_Baiscs
{
    internal class Questions
    {
        public void Output2DArray() {
            int[,] arr1 = new int[3, 4];
            for(int i=0; i<arr1.GetLength(0); i++)
            {
                for (int j=0; j<arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Input2DArray()
        {
            int[,] arr1 = new int[3, 4];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write("Enter the new element: ");
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void MaxElement()
        {
            int[,] arr = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };

            int max = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
                
            }

            Console.WriteLine("Maximum element is: " + max);
        }

        public void MaxSumRow()
        {
            int[,] arr = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            };

            int maxSum = int.MinValue;
            int sum = 0;
            int row = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    row = i;
                }

            }

            Console.WriteLine("Maximum sum element row is: " + row);
        }

        public void MinElemMaxElemRow()
        {
            int[,] arr = {
                { 2, 8, 3, 4, 7 },
                { 7, 2, 1, 6, 3 },
                { 5, 5, 4, 1, 4 },
                { 3, 1, 8, 2, 6 }
            };

            int minMax = int.MaxValue;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int currentMax = arr[i, 0];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > currentMax)
                    {
                        currentMax = arr[i, j];
                    }
                }      

                if (currentMax < minMax)
                {
                    minMax = currentMax;
                }

            }

            Console.WriteLine("Min element of max element rows is: " + minMax);
        }

        public void PrintColumnWise()
        {
            int[,] arr = {
                { 2, 8, 3, 4, 7 },
                { 7, 2, 1, 6, 3 },
                { 5, 5, 4, 1, 4 },
                { 3, 1, 8, 2, 6 }
            };

            for (int i = 0; i < arr.GetLength(1); i++)
            {
                int currentMax = arr[i, 0];
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[i, j] + "  ");
                }
                Console.WriteLine();
            }

        }

        public void SnakeMatrix()
        {
            int[,] arr = {
                { 2, 8, 3, 4, 7 },
                { 7, 2, 1, 6, 3 },
                { 5, 5, 4, 1, 4 },
                { 3, 1, 8, 2, 6 }
            };

            for (int i=0; i<arr.GetLength(0); i++)
            {
                if (i%2 == 0)
                {
                    for(int j=0; j<arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                } else
                {
                    for (int j = arr.GetLength(1)-1; j >= 0; j--)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                }

                Console.WriteLine(" ");
            }
            

        }

        public void SnakeColumn()
        {
            int[,] arr = {
                { 2, 8, 3, 4, 7 },
                { 7, 2, 1, 6, 3 },
                { 5, 5, 4, 1, 4 },
                { 3, 1, 8, 2, 6 }
            };

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                }
                else
                {
                    for (int i = arr.GetLength(0) - 1; i >= 0; i--)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                }

                Console.WriteLine(" ");
            }


        }

        public void ReverseRows()
        {
            int[,] arr = {
                { 2, 8, 3, 4, 7 },
                { 7, 2, 1, 6, 3 },
                { 5, 5, 4, 1, 4 },
                { 3, 1, 8, 2, 6 }
            };

            int temp;

            int l_j;

            for (int i=0; i<arr.GetLength(0); i++)
            {
                l_j = arr.GetLength(1) - 1;
                for (int j=0; j<arr.GetLength(1)/2; j++)
                {
                    temp = arr[i, l_j];
                    arr[i, l_j] = arr[i, j];
                    arr[i, j] = temp;
                    l_j--;
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
