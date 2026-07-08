public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] stringArr1 = new int[26];
        int[] stringArr2 = new int[26];

        foreach (char letter in s)
        {
            stringArr1[letter - 'a']++;
        }

        foreach (char letter in t)
        {
            stringArr2[letter - 'a']++;
        }

        return Enumerable.SequenceEqual(stringArr1, stringArr2);
    }
}
