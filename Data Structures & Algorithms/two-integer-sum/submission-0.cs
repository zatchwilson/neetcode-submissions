public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> vals = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int curr = nums[i];

            int diff = target - curr;

            if (vals.ContainsKey(diff))
                return new int[]{vals[diff], i};
            else
                vals.Add(curr, i);
        }

        return new int[]{};
    }
}
