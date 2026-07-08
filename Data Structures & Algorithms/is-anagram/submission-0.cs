public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> letters = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (letters.ContainsKey(s[i]))
                letters[s[i]]++;
            else
                letters.Add(s[i], 1);
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (!letters.ContainsKey(t[i]))
                return false;
            
            letters[t[i]]--;
        }

        foreach (KeyValuePair<char,int> kvp in letters)
        {
            if (kvp.Value != 0)
                return false;
        }

        return true;
    }
}
