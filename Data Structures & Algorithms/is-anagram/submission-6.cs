public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
            return false;

        int[] sCt = new int[26];
        int[] tCt = new int[26];

        foreach(char c in s)
        {
            sCt[c - 'a'] += 1;
        }

        foreach(char c in t)
        {
            tCt[c - 'a'] += 1;
        }

        for(int i = 0; i < sCt.Length; i++)
        {
            if (sCt[i] != tCt[i])
                return false;
        }

        return true;
    }
}
