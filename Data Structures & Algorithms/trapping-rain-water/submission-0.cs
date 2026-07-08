public class Solution {
    public int Trap(int[] height) {
       int[] prefix = new int[height.Length];
       int[] suffix = new int[height.Length];

       int maxH = 0;

       for (int i = 0; i < height.Length; i++)
       {
            prefix[i] = maxH;

            if (height[i] > maxH)
                maxH = height[i];
       } 

       maxH = 0;

       for (int i = height.Length - 1; i >= 0; i--)
       {
            suffix[i] = maxH;

            if(height[i] > maxH)
                maxH = height[i];
       }

        int volume = 0;

        for (int i = 0; i < height.Length; i++)
        {
            int currHeight = Math.Min(prefix[i], suffix[i]) - height[i];

            if (currHeight > 0)
                volume += currHeight;
        }

        return volume;

    }
}
