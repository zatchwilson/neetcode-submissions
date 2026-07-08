public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        int[] countS = new int[26];
        int[] countT = new int[26];

        foreach(char c in s)
        {
            countS[c - 'a']++;
        }

        foreach(char c in t)
        {
            countT[c - 'a']++;
        }

        for(int i = 0; i < countS.Length; i++)
        {
            if (countS[i] != countT[i])
                return false;
        }

        return true;
    }
}
