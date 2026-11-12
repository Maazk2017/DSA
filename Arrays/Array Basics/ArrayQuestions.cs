using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Array_Basics
{
    internal class ArrayQuestions
    {
        public void rotateArray()
        {
            int[] arr = {4, 6, 1, 9};
            int k = 4;

            int temp;
            int l_idx = arr.Length - 1;
            for (int i=0; i<k; i++)
            {
                temp = arr[0];
                for (int j=1; j<arr.Length; j++)
                {
                    arr[j-1] = arr[j];
                }
                arr[l_idx] = temp;
            }

            for (int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]);
            }

            Console.WriteLine();

        }

        // frequency array question

        public void presentElements()
        {
            int[] arr = { 5, 6, 5, 400, 560, 1000, 400 };
            int[] myArr = new int[10005];

            for (int i=0; i<arr.Length; i++)
            {
                myArr[arr[i]]++;
            }

            Console.WriteLine("Enter number of quries: ");
            int q = Convert.ToInt32(Console.ReadLine());

            while (q != 0)
            {
                q--;
                Console.WriteLine("Enter number to be searched: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (myArr[num] > 0)
                {
                    Console.WriteLine("Yes");
                } else
                {
                    Console.WriteLine("No");
                }
            }

        }

        public int isRepeated()
        {
            int[] arr = {1, 5, 3, 4, 6, 3, 4};
            int count = 0;

            for (int i=0; i<arr.Length; i++)
            {
                for (int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        return arr[i];
                    }
                }
            }

            return -1;
        }


    }
}
