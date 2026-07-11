public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> foundNums = new();

        if (nums.Length < 2)
            return nums.Length;

        for (int i = 0; i < nums.Length; i++) 
        {
            foundNums.Add(nums[i]);
        }

        int longest = 1;

        foreach (int num in nums)
        {
            if (foundNums.Contains(num-1))
            {
                continue;
            }
            int seq = 1;
            int curr = num;
            while (foundNums.Contains(curr+1))
            {
                seq += 1;
                curr++;
            }

            longest = Math.Max(seq, longest);
        }

        return longest;
    }
}
