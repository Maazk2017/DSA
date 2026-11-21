namespace Recursion_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Questions q = new Questions();
            //q.printNTOOne(5);
            //q.printOneToN(5);
            //q.DecInc(5);
            //q.factorial(5); 
            //Console.WriteLine(q.MyPow(2, 3));
            //Console.WriteLine(q.Fib(6));
            Console.WriteLine(q.countWays(5));
        }
    }
}
