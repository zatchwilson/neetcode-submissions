public class Solution {
    public int FindMin(int[] nums) {
        
        int l = 0;
        int r = nums.Length - 1;
        int result = nums[0];

        while (l <= r)
        {
            if (nums[l] <= nums[r])
            {
                result = Math.Min(result, nums[l]);
                break;
            }
            else
            {
                int mid = (l + r) / 2;

                if (nums[mid] >= nums[l])
                {
                    result = Math.Min(nums[l], result);
                    l = mid + 1;
                }
                else
                {
                    result = Math.Min(nums[mid], result);
                    r = mid - 1;
                }
            }
        }

        return result;
    }
}
