public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 0)
            return 0;

        if (nums.Length == 1)
            return nums[0];

        int[] stolen = new int[nums.Length];
        stolen[0] = nums[0];
        stolen[1] = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < nums.Length; i++)
        {
            stolen[i] = Math.Max(stolen[i-1], nums[i] + stolen[i-2]);
        }

        return stolen[nums.Length-1];
    }
}
