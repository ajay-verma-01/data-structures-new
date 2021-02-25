using System;
using System.Collections.Generic;
using System.Text;

namespace SortingsProblemSets
{
    public class DutchNationalFlag
    {
        //G,B, G, G ,R, G , R B
        public static void Sort(char[] chars)
        {
            int rPtr = 0; int bPtr = chars.Length - 1;
            int i = 0;
            while (i <= bPtr)
            {
                if (chars[i] == 'G')
                    i++;
                else if (chars[i] == 'R')
                {
                    Swap(chars, i, rPtr);
                    rPtr++;
                    i++;
                }
                else if(chars[i] == 'B')
                {
                    Swap(chars, i, bPtr);
                    bPtr--;
                }
            }
        }

        private static void Swap(char[] chars, int i, int j)
        {
            var temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }
    }
}
