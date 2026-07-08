public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        
        if (cost.Length <= 2)
        {
            return Math.Min(cost[0], cost[1]);
        }

        int len = cost.Length;
        
        int[] mem = new int[len+1];


        mem[len] = 0;
        mem[len-1] = cost[len-1];
        mem[len-2] = cost[len-2];

        for(int i = len-3; i >= 0; i--)
        {
            mem[i] = cost[i] + Math.Min(mem[i+1], mem[i+2]);
        }

        return Math.Min(mem[0], mem[1]);
    }
}
