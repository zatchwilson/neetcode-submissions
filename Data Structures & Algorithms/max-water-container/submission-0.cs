public class Solution {
    public int MaxArea(int[] heights) {
        int p1 = 0;
        int p2 = heights.Length - 1;

        int maxVol = 0;

        while (p1 < p2)
        {
            int lH = heights[p1];
            int rH = heights[p2];

            int area = Math.Min(lH, rH) * (p2 - p1);

            if (area > maxVol)
                maxVol = area;

            if (lH < rH)
                p1++;
            else
                p2--;
        }

        return maxVol;
    }
}
