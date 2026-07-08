public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);

        if (nums.Length == 0)
            return 0;
        
        if (nums.Length == 1)
            return 1;

        int longestSeq = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            int currSeq = 1;

            int curr = nums[i];

            if (set.Contains(curr - 1))
                continue;
            
            while (set.Contains(curr + 1))
            {
                currSeq++;
                curr++;
            }

            if (currSeq > longestSeq)
                longestSeq = currSeq;
            
        }

        return longestSeq;

    }
}
