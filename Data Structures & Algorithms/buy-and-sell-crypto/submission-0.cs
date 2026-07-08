public class Solution {
    public int MaxProfit(int[] prices) {
        int lowIndex = 0;
        int highIndex = 1;

        int profit = 0;

        while(highIndex < prices.Length)
        {
            int currProfit = prices[highIndex] - prices[lowIndex];
            if (currProfit < 0)
            {
                lowIndex = highIndex;
                highIndex++;
            }
            else
            {
                profit = Math.Max(currProfit, profit);
                highIndex++;
            }
        }

        return profit;
    }
}
