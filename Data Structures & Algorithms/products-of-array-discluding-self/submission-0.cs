public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];

        int product = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            prefix[i] = product;

            product = product * nums[i];
        }
        
        product = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            suffix[i] = product;
            product = product * nums[i];
        }

        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = suffix[i] * prefix[i];
        }

        return result;
    }
}
