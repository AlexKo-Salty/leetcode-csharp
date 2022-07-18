    public class Solution
    {
        //Solution 1 - Brute Force, Failed in Time exceeded.
        //public int MaxProfit(int[] prices)
        //{
        //    int profit = 0;
        //    for (int i = 0; i < prices.Length; i ++)
        //    {
        //        for (int j = i + 1; j < prices.Length; j ++)
        //        {
        //          int tempProfit = prices[j] - prices[i];
        //          profit = tempProfit > profit ? tempProfit : profit;
        //        }
        //    }

        //    return profit;
        //}

        public int MaxProfit(int[] prices)
        {
            int lowestPrice = int.MaxValue;
            int profit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (lowestPrice > prices[i])
                {
                    lowestPrice = prices[i];
                }

                else if ((prices[i] - lowestPrice) > profit)
                {
                    profit = prices[i] - lowestPrice;
                }
            }

            return profit;
        }
    }