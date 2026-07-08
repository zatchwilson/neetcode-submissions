public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // List<List<string>> anagrams = new();

        Dictionary<string, List<string>> anagrams = new();

        for (int i = 0; i < strs.Length; i++)
        {
            int[] charFreq = new int[26];

            string curr = strs[i];

            for (int strPos = 0; strPos < curr.Length; strPos++)
            {
                charFreq[char.ToUpper(curr[strPos]) - 64]++;
            }

            string key = string.Join(",", charFreq);

            if (anagrams.ContainsKey(key))
            {
                anagrams[key].Add(strs[i]);
            }
            else
            {
                anagrams.Add(key, new List<string> {strs[i]});
            }
        }

        return anagrams.Values.ToList();
    }
}
