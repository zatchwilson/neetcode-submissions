public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int len = nums.Length;
        int[] pre = new int[len];
        int[] post = new int[len];
        // Need to watch out for array initializing values to 0

        for (int i = 0; i < len; i++)
        {
            pre[i] = 1;
            post[i] = 1;
        }

        int[] output = new int[len];

        int currProd = 1;

        for (int i = 1; i < len; i++)
        {
            currProd = currProd * nums[i-1];
            pre[i] = currProd;
        }

        currProd = 1;
        for (int i = len-2; i >= 0; i--)
        {
            currProd = currProd * nums[i+1];
            post[i] = currProd;
        }

        for (int i = 0; i < len; i++)
        {
            output[i] = pre[i] * post[i];
        }

        return output;

        
    }
}
