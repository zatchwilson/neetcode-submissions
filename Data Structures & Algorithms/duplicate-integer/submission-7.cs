public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> numSet = new();

        foreach (int i in nums)
        {
            if (numSet.Contains(i))
                return true;
            
            numSet.Add(i);
        }

        return false;
    }
}