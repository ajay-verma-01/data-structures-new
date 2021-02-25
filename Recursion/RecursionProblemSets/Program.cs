using System;

namespace RecursionProblemSets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursion");

            Console.WriteLine("\n------------------Letter Case Permutation-----------------");
            var list = LetterCasePermutation.letterCasePermutation("a1b2");
            foreach (var item in list)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine("\n------------------Letter Case Permutation Char Array-----------------");
            var list1 = LetterCasePermutation.letterCasePermutation("a1b2");
            foreach (var item in list1)
            {
                Console.Write(item + ", ");
            }


            Console.WriteLine("\n------------------Subsets-----------------");
            var list2 = Subsets.FindSubsets(new int[] { 1,2,3});
            foreach (var item in list2)
            {
                Console.WriteLine("\nNewList");
                foreach (var i in item)
                {
                    Console.Write(i + ",");
                }
            }

            Console.WriteLine("\n------------------Permutations-----------------");
            var list3 = Permutations.Permute(new int[] { 1, 2, 3 });
            foreach (var item in list3)
            {
                Console.WriteLine("\nNewList");
                foreach (var i in item)
                {
                    Console.Write(i + ",");
                }
            }

            Console.WriteLine("\n------------------PermutationsII-----------------");
            var list4 = PermutationsII.Permute(new int[] { 1, 1, 2 });
            foreach (var item in list4)
            {
                Console.WriteLine("\nNewList");
                foreach (var i in item)
                {
                    Console.Write(i + ",");
                }
            }

            Console.WriteLine("\n------------------Subsets II-----------------");
            var sub2 = SubsetsII.FindSubsets(new int[] { 1, 2, 2 });
            foreach (var item in sub2)
            {
                Console.WriteLine("\nNewList");
                foreach (var i in item)
                {
                    Console.Write(i + ",");
                }
            }

            Console.WriteLine("\n------------------Combinations-----------------");
            var com = Combinations.Combine(4, 2);
            foreach (var item in com)
            {
                Console.WriteLine("\nNewList");
                foreach (var i in item)
                {
                    Console.Write(i + ",");
                }
            }


            Console.WriteLine("\n------------------Combinations Sum-----------------");
            var com2 = CombinationsSum.CombinationSum(new int[] { 2, 3, 4, 7 }, 7);
            foreach (var item in com2)
            {
                Console.WriteLine("\nNewList");
                foreach (var i in item)
                {
                    Console.Write(i + ",");
                }
            }

            Console.WriteLine("\n------------------Combinations Sum II-----------------");
            var com22 = CombinationsSumII.CombinationSum2(new int[] { 2, 3, 4, 7 }, 8);
            foreach (var item in com22)
            {
                Console.WriteLine("\nNewList");
                foreach (var i in item)
                {
                    Console.Write(i + ",");
                }
            }

            Console.ReadKey();
        }
    }
}
