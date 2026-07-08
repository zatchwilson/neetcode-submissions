public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> newSet = new();

        for(int i = 0; i < nums.Length; i++)
        {
            if (newSet.Contains(nums[i]))
                return true;
            
            newSet.Add(nums[i]);
        }

        return false;
    }
}