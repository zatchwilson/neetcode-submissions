public class Solution {
    public int FindMin(int[] nums) {
        int length = nums.Length;

        if (length == 1)
            return nums[0];

        if (length == 2)
            return Math.Min(nums[0], nums[1]);

        int lP = 0;
        int rP = length - 1;

        int minVal = nums[0];

        while (lP <= rP)
        {
            int mP = (lP + rP) / 2;

            if (nums[lP] < nums[rP])
            {
                return Math.Min(minVal, nums[lP]);
            }

            minVal = Math.Min(nums[mP], minVal);

            if (nums[mP] >= nums[lP])
            {
                lP = mP + 1;
            }
            else
            {
                rP = mP - 1;
            }
        }

        return minVal;
    }
}
