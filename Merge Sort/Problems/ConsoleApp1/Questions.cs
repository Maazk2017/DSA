using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Questions
    {

        // The Merge procedure (combines two sorted sub-lists into a temporary array and copies back)
        private static void Merge(int[] A, int l, int mid, int h)
        {
            int i = l;        // Pointer for the first sub-array (left to mid)
            int j = mid + 1;  // Pointer for the second sub-array (mid+1 to high)
            int k = l;        // Pointer for the auxiliary/temporary tracking array

            // Temporary array to hold merged elements (sized to fit the current segment)
            int[] B = new int[A.Length];

            // Compare and copy elements in sorted order into B
            while (i <= mid && j <= h)
            {
                if (A[i] < A[j])
                {
                    B[k++] = A[i++];
                }
                else
                {
                    B[k++] = A[j++];
                }
            }

            // Copy any remaining elements from the first sub-array, if any
            while (i <= mid)
            {
                B[k++] = A[i++];
            }

            // Copy any remaining elements from the second sub-array, if any
            while (j <= h)
            {
                B[k++] = A[j++];
            }

            // Copy the sorted elements back from temporary array B to original array A
            for (i = l; i <= h; i++)
            {
                A[i] = B[i];
            }
        }

        // The Recursive MergeSort procedure
        public static void MergeSort(int[] A, int l, int h)
        {
            if (l < h)
            {
                // Find the midpoint to divide the array into two halves
                int mid = l + (h - l) / 2;

                // Recursively sort the left half
                MergeSort(A, l, mid);

                // Recursively sort the right half
                MergeSort(A, mid + 1, h);

                // Merge the two sorted halves together
                Merge(A, l, mid, h);
            }

        }
    }
}
