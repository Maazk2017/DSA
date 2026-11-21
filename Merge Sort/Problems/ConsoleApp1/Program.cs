namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 9, 3, 7, 5, 6, 4, 8, 2 };

            Console.WriteLine("Original Array:");
            Console.WriteLine(string.Join(", ", A));

            // Call MergeSort passing the array, lower bound (l), and upper bound (h)
            Questions.MergeSort(A, 0, A.Length - 1);

            Console.WriteLine("\nSorted Array:");
            Console.WriteLine(string.Join(", ", A));
        }
    }
}
