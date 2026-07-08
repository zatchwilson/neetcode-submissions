public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> foundNums = new();

        for(int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];

            if (foundNums.ContainsKey(diff))
                return new int[]{foundNums[diff], i};
            foundNums.Add(nums[i], i);
        }

        return new int[]{};
    }
}
