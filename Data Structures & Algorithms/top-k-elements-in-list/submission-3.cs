public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<List<int>> freqs = new List<List<int>>();

        for(int i = 0; i < nums.Length+1; i++)
        {
            freqs.Add(new List<int>());
        }
        
        Dictionary<int, int> valCounts = new();
        foreach (int i in nums)
        {
            if (valCounts.ContainsKey(i))
                valCounts[i]+=1;
            else
                valCounts.Add(i, 1);
        }

        foreach (KeyValuePair<int,int> pair in valCounts)
        {
            freqs[pair.Value].Add(pair.Key);
        }

        List<int> sol = new();
        int j = nums.Length;
        while (k > 0)
        {
            if (freqs[j].Count() > 0)
            {
                sol.AddRange(freqs[j]);
                k -= freqs[j].Count();
            }
            j--;
        }

        return sol.ToArray();

    }
}
