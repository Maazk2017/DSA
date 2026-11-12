using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate_Arrays
{
    public class Questions
    {
        public void sortZeroOne()
        {
            int[] arr = { 1, 0, 0, 1, 0, 1, 1, 0 };

            int i = 0;
            int j = arr.Length - 1;
            int temp;

            while (i < j)
            {
                if (arr[i] == 0)
                {
                    i++;
                }

                if (arr[j] == 1)
                {
                    j--;
                }

                if (arr[i] == 1 && arr[j] == 0)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    i++;
                    j--;
                }
            }


            foreach (int x in arr)
            {
                Console.Write(x + "");
            }
        }

        public void evenOdd()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            int i = 0;
            int j = a.Length - 1;
            int temp;

            while (i < j)
            {
                if (a[i] % 2 == 0)
                {
                    i++;
                }

                if (a[j] % 2 != 0)
                {
                    j--;
                }

                if (a[i] % 2 != 0 && a[j] % 2 == 0)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;

                    i++;
                    j--;
                
                }
            }

            foreach (int x in a)
            {
                Console.Write(x + " ");
            }
        }

        public void sortNegativeSquares()
        {
            int[] arr = { -10, -3, -2, 1, 4, 5 };
            int[] sqArr = new int[arr.Length];

            int l = 0;
            int r = arr.Length - 1;

            int k = sqArr.Length - 1;

            while (l <= r)
            {
                if (Math.Abs(arr[l]) > Math.Abs(arr[r])) {
                    sqArr[k] = arr[l] * arr[l];
                    l++;
                } else {
                    sqArr[k] = arr[r] * arr[r];
                    r--;
                }
                k--;
            }
            
 


            foreach (int x in sqArr)
            {
                Console.Write(x + " ");
            }
        }

        public void prefixSum()
        {
            int[] arr = { 2, 1, 3, 4, 5 };
            int[] prefix = new int[arr.Length];

            prefix[0] = arr[0];

            for (int i=1; i<arr.Length; i++)
            {
                prefix[i] = prefix[i - 1] + arr[i];
            }


            foreach (int x in prefix)
            {
                Console.Write(x + " ");
            }
        }

        public void queryPrefixSum()
        {
            int[] arr = { 2, 1, 3, 4, 5 };
            int[] prefix = new int[arr.Length];

            int q;

            prefix[0] = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                prefix[i] = prefix[i - 1] + arr[i];
            }

            Console.WriteLine("Enter number of queries");
            q = Convert.ToInt32(Console.ReadLine());
            while (q-- > 0)
            {
                Console.WriteLine("Enter the range: ");
                int l = Convert.ToInt32(Console.ReadLine());
                int r = Convert.ToInt32(Console.ReadLine());

                int ans = prefix[r] - prefix[l - 1];

                Console.WriteLine("Sum " + ans);
            }
        }


    }
}
