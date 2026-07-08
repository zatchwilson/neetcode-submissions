public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] charCount1 = new int[26];
        int[] charCount2 = new int[26];

        if (s.Length != t.Length)
            return false;

        for(int i = 0; i < s.Length; i++)
        {
            charCount1[s[i] - 'a']++;
            charCount2[t[i] - 'a']++;
        }

        for (int i = 0; i < charCount1.Length; i++)
        {
            if (charCount1[i] != charCount2[i])
                return false;
        }

        return true;
    }
}
