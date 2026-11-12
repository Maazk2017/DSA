using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Numerics;

namespace ArrayLists
{
    internal class Intro
    {
        public void listInArray()
        {
            // Declaration and initialization
            ArrayList arr = new ArrayList();
            ArrayList arr2 = new ArrayList() { 10, 20, 30};

            // Adding elements
            arr.Add(10);
            arr.Add(20);
            arr.Add("Hello");

            arr.AddRange(new int[] { 40, 50, 60 });

            // Accessing elements
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr);

            // D.Updating elements
`           arr[0] = 100;

            // E.Removing Elements
            arr.Remove(20); // Removes the first matching value
            arr.RemoveAt(0); // Removes element at index 0
            arr.Clear(); // Remove everything

            // F.Searching
            arr.Contains(10);
            arr.IndexOf(10);
            arr.LastIndexOf(10); // returns the last matching index or -1.

            // G.Properties
            arr.Count;       // Number of elements
            arr.Capacity;    // Allocated capacity
            arr.IsReadOnly;  // Whether modification is allowed
            

            // H.Iteration
            foreach (Object i in arr)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        public void lists()
        {
            // A List<T> is a dynamic array that can grow or shrink in size.
            List<int> number = new List<int>();
            number.Add(10);
            number.Add(20);
            number.Add(30);
            number.Add(40);

            List<int> numbers = new List<int>();

            // Add elements
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            // Access elements
            Console.WriteLine(numbers[0]); // 10

            // Change an element
            numbers[0] = 100;

            // Remove an element
            numbers.Remove(20);

            // Remove using index
            numbers.RemoveAt(0);

            // Insert at a specific index
            numbers.Insert(0, 50);

            // Add multiple elements
            numbers.AddRange(new int[] { 60, 70, 80 });

            // Check if element exists
            Console.WriteLine(numbers.Contains(70)); // True

            // Number of elements
            Console.WriteLine(numbers.Count);

            // Clear everything
            numbers.Clear();
        }
    }
}
