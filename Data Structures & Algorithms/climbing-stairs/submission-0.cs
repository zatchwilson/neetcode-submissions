public class Solution {
    public int ClimbStairs(int n) {     
       int curr = n;

       if (n <= 2)
        return n;

        int[] mem = new int[n+1];
        mem[1] = 1;
        mem[2] = 2;

        for(int i = 3; i <= n; i++)
        {
            mem[i] = mem[i-1] + mem[i-2];
        }
        return mem[n];
    }
}
