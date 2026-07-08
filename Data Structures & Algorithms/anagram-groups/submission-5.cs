public class Solution {
    private Dictionary<string, List<string>> pairs = new();

    public List<List<string>> GroupAnagrams(string[] strs) {
        foreach (string s in strs)
        {
            CheckAnagram(s);
        }

        List<List<string>> solution = new();
        foreach(KeyValuePair<string, List<string>> pair in pairs)
        {
            solution.Add(pair.Value);
        }

        return solution;
    }

    private void CheckAnagram(string word)
    {
        int[] charCount = new int[26];

        foreach (char c in word)
        {
            charCount[c - 'a'] += 1;
        }

        string freq = string.Join(",", charCount);

        if (pairs.ContainsKey(freq))
        {
            pairs[freq].Add(word);
        }
        else 
        {
            pairs.Add(freq, new List<string>(){word});
        }
    }
}
