public class Solution {
    public int Search(int[] nums, int target) {
        int rp = nums.Length - 1;
        int lp = 0;

        while (lp <= rp)
        {
            int mid = (lp + rp) / 2;

            int curr = nums[mid];

            if (curr < target)
                lp = mid + 1;
            else if (curr > target)
                rp = mid - 1;
            else
                return mid;
        }

        return -1;
    }
}
