using System;

namespace DPProblemSets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Those who cannot remember the past are condemned to repeat it.   -Dynamic Programing");
            Console.WriteLine("Dynamic Programing..Working Defination..Recursion without Repeatation..");

            Console.WriteLine("\n--------Fib Memoization----------");
            FibMemoization fibM = new FibMemoization();
            Console.WriteLine(fibM.Fib(5));

            Console.WriteLine("\n--------Fib Bottom Up----------");
            FibTabulation fibB = new FibTabulation();
            Console.WriteLine(fibB.Fib(25));
            Console.WriteLine("\n--------Fib Bottom Up Optimization----------");
            Console.WriteLine(fibB.FibOptimization(25));

            Console.WriteLine("\n--------Climb Stairs Rec----------");
            var cs = new ClimbingStairs();
            Console.WriteLine(cs.ClimbStairsRec(10));
            Console.WriteLine("\n--------Climb Stairs Dynamic Programing----------");
            var cs1 = new ClimbingStairs();
            Console.WriteLine(cs.ClimbStairs(10));

            Console.WriteLine("\n--------Subsets  Dynamic Programing----------");
            var s = new Subsets();
            Console.WriteLine(s.nCkDP(4, 2));


            Console.WriteLine("\n--------Find Unique Path----------");
            var up = new UniquePaths();
            Console.WriteLine(up.FindUniquePaths(3, 7));

            Console.WriteLine("\n--------Min Cost Stairs----------");
            var minst = new MinCostClimbingStairs();
            Console.WriteLine(minst.FindMinCostClimbingStairs(new int[] { 10, 15, 20}));


            Console.WriteLine("\n--------Min Coins----------");
            var minCoins = new CoinChange();    
            Console.WriteLine(minCoins.FindCoinChange(new int[] { 1, 2, 5 }, 11));

            Console.WriteLine("\n--------Min Coins----------");
            Console.WriteLine(minCoins.MinCoinChange(11, new int[] { 1, 2, 5 }));

            Console.ReadLine();
        }
    }
}
