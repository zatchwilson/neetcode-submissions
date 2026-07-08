public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> appeared = new();

        foreach (int num in nums)
        {
            if (appeared.Contains(num))
                return true;
            appeared.Add(num);
        }

        return false;
    }
}