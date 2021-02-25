using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblemSets
{
    public class GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();

            Helper(n, 0, 0, "", result);

            return result;
        }

        static void Helper(int n, int left, int right, string slate, List<string> result)
        {
            if (right > left || left > n || right > n)
                return;

            if (left == n && right == n)
            {
                result.Add(slate);
                return;
            }

            Helper(n, left + 1, right, slate + "(", result);
            Helper(n, left, right + 1, slate + ")", result);

        }

    }
}
