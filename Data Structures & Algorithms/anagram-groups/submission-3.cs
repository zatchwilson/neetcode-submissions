public class Solution {
    
    private Dictionary<string, List<string>> anagrams;

    public List<List<string>> GroupAnagrams(string[] strs) {
        anagrams = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            CheckAnagram(str);
        }

        List<List<string>> result = new();

        foreach(var pair in anagrams)
        {
            result.Add(pair.Value);
        }

        return result;

    }

    private void CheckAnagram(string word)
    {
        int[] counts = new int[26];

        for (int i = 0; i < word.Length; i++)
        {
            counts[word[i] - 'a']++;
        }

        string joined = string.Join(',', counts);

        if (anagrams.ContainsKey(joined))
        {
            anagrams[joined].Add(word);
        }
        else
        {
            anagrams.Add(joined, new List<string>(){word});
        }
    }


}
