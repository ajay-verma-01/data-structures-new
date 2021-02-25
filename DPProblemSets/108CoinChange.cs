using System;
using System.Collections.Generic;
using System.Text;

namespace DPProblemSets
{
    /*
     322. Coin Change
Medium

5679

172

Add to List

Share
You are given coins of different denominations and a total amount of money amount. Write a function to compute the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.

You may assume that you have an infinite number of each kind of coin.

 

Example 1:

Input: coins = [1,2,5], amount = 11
Output: 3
Explanation: 11 = 5 + 5 + 1
Example 2:

Input: coins = [2], amount = 3
Output: -1
     */
    public class CoinChange
    {
        public int FindCoinChange(int[] coins, int amount)
        {
            int[] table = new int[amount + 1];
            int max = amount + 1;
            for (int i = 0; i < amount+1; i++)
            {
                table[i] = amount +1;
            }

            table[0] = 0;

            for (int i = 1; i <= amount; i++)
            {
                int minCoins = max;

                for (int c = 0; c < coins.Length; c++)
                {
                    if (i - coins[c] >= 0)
                    {
                        minCoins = Math.Min(minCoins, table[i - coins[c]] + 1);
                    }
                }

                table[i] = minCoins;

            }

            if (table[amount] == max)
                return -1;
            else
                return table[amount];
        }

        public int MinCoinChange(int amount, int[] coins)
        {
            int[] table = new int[amount + 1];
            int maxDefault = amount + 1;
            for (int i = 1; i <= amount; i++)
            {
                table[i] = maxDefault;
            }

            for (int i = 1; i <= amount; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    if (i - coins[j] >= 0)
                    {
                        table[i] = Math.Min(table[i], table[i - coins[j]]);
                    }
                }

                table[i]++;
            }

            if (table[amount] == maxDefault)
                return -1;
            else
                return table[amount];
        }
    }
}
