public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> dupes = new();

        foreach (int num in nums)
        {
            if (dupes.Contains(num))
                return true;

            dupes.Add(num);
        }

        return false;
    }
}