using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Sorting
{
    internal class Questions
    {
        public bool sort()
        {
            int[] arr = { 1, 0, 2, 3, 4, 5, 6 };
            for (int i = 0; i<arr.Length-1; i++)
            {
                if (arr[i] > arr[i+1])
                {
                    return false;
                }
            }
            return true;
        }

        public void bubbleSort()
        {
            int[] arr = { 3, 5, 1, 4, 2, 0 };
            int n = arr.Length;
            int temp;
            bool flag = true;

            for (int i = 0; i < n; i++)
            {
                flag = true;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flag = false;
                    }
                }

                if (flag)
                {
                    break;
                }
            }

            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
        }

        public void selectionSort()
        {
            int[] arr = { 8, 4, 1, 9, -3, 6, 5 };
            int s = int.MinValue;
            int sIdx = 0;
            int temp;

            for (int i=0; i<arr.Length; i++)
            {
                s = arr[i];
                sIdx = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < s)
                    {
                        s = arr[j];
                        sIdx = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[sIdx];
                arr[sIdx] = temp;
            }

            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
        }

        public void insertionSort()
        {
            int[] arr = { 4, 1, 7, 3, 9, 2, 0, 8 };
            int temp;
            for(int i=1; i<arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j] < arr[j-1])
                {
                    temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                }
            }

            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
        }
    }
}
