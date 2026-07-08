public class Solution {
    public int ClimbStairs(int n) {     
        Dictionary<int, int> stepMem = new();



        for(int currStep = n; currStep >= 0; currStep--)
        {
            if (currStep == n || currStep == n-1)
            {
                stepMem.Add(currStep, 1);
            }
            else
            {
                stepMem.Add(currStep, (stepMem[currStep+1] + stepMem[currStep+2]));
            }
        }

        return stepMem[0];;
    }
}
