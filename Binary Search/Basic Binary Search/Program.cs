namespace Basic_Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Questions q = new Questions();
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 9;
            //q.binarySearch(nums, target);
            int[] nums1 = { 12, 9, 5, 3, 0, -1 };
            int target1 = 9;
            Console.WriteLine(q.binarySearchDesc(nums1, target1));
        }
    }
}
