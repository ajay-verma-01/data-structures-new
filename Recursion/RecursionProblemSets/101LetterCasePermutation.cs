using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblemSets
{
    /*
     784. Letter Case Permutation
Medium

1610

115

Add to List

Share
Given a string S, we can transform every letter individually to be lowercase or uppercase to create another string.

Return a list of all possible strings we could create. You can return the output in any order.

 

Example 1:

Input: S = "a1b2"
Output: ["a1b2","a1B2","A1b2","A1B2"]
Example 2:

Input: S = "3z4"
Output: ["3z4","3Z4"]
     */
    public class LetterCasePermutation
    {
        public static IList<string> letterCasePermutation(string S)
        {
            var result = new List<string>();
            Helper(S, 0, "", result);

            //HelperChar(S, 0, new char[S.Length], result);
            return result;

        }

        public static IList<string> letterCasePermutationChar(string S)
        {
            var result = new List<string>();
            HelperChar(S, 0, new char[S.Length], result);
            return result;
        }

        public static void Helper(string S, int i, string slate, List<string> result)
        {
            if (i == S.Length)
            {
                result.Add(slate);
                return;
            }

            if (char.IsDigit(S[i]))
            {
                Helper(S, i + 1, slate + S[i], result);
            }
            else
            {
                Helper(S, i + 1, slate + char.ToLower(S[i]), result);
                Helper(S, i + 1, slate + char.ToUpper(S[i]), result);
            }
        }

        public static void HelperChar(string S, int i, char[] slate, List<string> result)
        {
            if (i == S.Length)
            {
                result.Add(new string(slate));
                return;
            }

            if (char.IsDigit(S[i]))
            {
                slate[i] = S[i];
                HelperChar(S, i + 1, slate, result);
                slate[i] = '\0';
            }
            else
            {
                slate[i] = char.ToLower(S[i]);
                HelperChar(S, i + 1, slate , result);
                slate[i] = '\0';

                slate[i] = char.ToUpper(S[i]);
                HelperChar(S, i + 1, slate, result);
                slate[i] = '\0';
            }
        }

    }
}
