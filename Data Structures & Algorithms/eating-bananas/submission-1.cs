public class Solution {
public int MinEatingSpeed(int[] piles, int h) {
                int max = 0;
        int min = 1;
        for (int i = 0; i < piles.Length; i++)
        {
            if (piles[i] > max)
                max = piles[i];
        }

        int val = max;

        while (min <= max)
        {
            int mid = (max + min) / 2;

            long time = 0;

            foreach (int pile in piles)
            {
                time += (int)Math.Ceiling((double)pile / mid);
            }

            if (time <= h)
            {
                val = mid;
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }

        return val;
    }
}