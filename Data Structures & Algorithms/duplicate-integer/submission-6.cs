public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hSet = new();

        foreach(int i in nums)
        {
            if (hSet.Contains(i))
                return true;

            hSet.Add(i);
        }

        return false;
    }
}