public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<List<int>> freqs = new List<List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            freqs.Add(new List<int>());
        }

        Dictionary<int, int> counts = new();

        foreach(int num in nums)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts.Add(num, 1);
            }
        }

        foreach(var count in counts)
        {
            freqs[count.Value-1].Add(count.Key);
        }

        int[] result = new int[k];
        int index = 0;
        for (int i = freqs.Count()-1; i >= 0; i--)
        {
            foreach(int num in freqs[i])
            {
                result[index] = num;
                index++;

                if (index == k)
                    return result;
            }

            
        }

        return result;
    }
}
