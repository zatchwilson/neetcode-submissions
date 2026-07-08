public class Solution {
    public int Search(int[] nums, int target) {
        int minIndex = 0;
        int min = nums[0];

        // if (nums.Length == 1)
        // {
        //     if (target == nums[0])
        //         return 0;
        //     return -1;
        // }

        if (min == target)
            return 0;

        int l = 0;
        int r = nums.Length - 1;

        //Find the minimum value of the array, finding where the two sections of the array are
        while (l <= r)
        {
            if (nums[l] <= nums[r])
            {
                if (min > nums[l])
                {
                    min = nums[l];
                    minIndex = l;
                }
                break;

            }
            else
            {
                int mid = (l + r) / 2;

                if (nums[mid] >= nums[l])
                {
                    if (min > nums[l])
                    {
                        min = nums[l];
                        minIndex = l;
                    }
                    l = mid + 1;
                }
                else
                {
                    if (min > nums[mid])
                    {
                        min = nums[mid];
                        minIndex = mid;
                    }
                    r = mid - 1;
                }
            }
            
        }

        if (target == min)
            return minIndex;

        l = minIndex;
        r = nums.Length - 1;

        while (l <= r)
        {
            int mid = (l + r) / 2;

            if (nums[mid] == target)
                return mid;
            
            if (nums[mid] > target)
            {
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
            }
        }

        l = 0;
        r = minIndex - 1;

        while (l <= r)
        {
            int mid = (l + r) / 2;

            if (nums[mid] == target)
                return mid;
            
            if (nums[mid] > target)
            {
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
            }
        }

        return -1;    
        }
}
