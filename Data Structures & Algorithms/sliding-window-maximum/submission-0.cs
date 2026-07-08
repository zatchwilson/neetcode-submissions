public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        List<int> retList = new();

        LinkedList<int> window = new();
        int leftIndex = 0;

        for (int i = 0; i < k; i++)
        {
            int val = nums[i];
            while (window.Count > 0 && val > nums[window.Last.Value])
            {
                window.RemoveLast();
            }
            window.AddLast(i);
        }

        retList.Add(nums[window.First.Value]);

        for (int i = k; i < nums.Length; i++)
        {
            leftIndex++;

            if (window.First.Value < leftIndex)
                window.RemoveFirst();

            int val = nums[i];

            while (window.Count > 0 && val > nums[window.Last.Value])
            {
                window.RemoveLast();
            }
            window.AddLast(i);

            retList.Add(nums[window.First.Value]);
        }

        return retList.ToArray();
    }
}
