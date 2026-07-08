public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> charSet = new();

        int p1 = 0;
        int p2 = 1;

        

        if (s.Length < 1)
            return 0;

        int longest = 1;
        charSet.Add(s[0]);

        while (p2 < s.Length)
        {
            if (charSet.Contains(s[p2]))
            {
                bool removed = false;
                while (!removed)
                {
                    charSet.Remove(s[p1]);
                    p1++;

                    if (!charSet.Contains(s[p2]))
                    {
                        removed = true; 
                    }
                }
                
                charSet.Add(s[p2]);
            }
            else
            {
                int currLength = p2 - p1 + 1;

                longest = Math.Max(currLength, longest);

                charSet.Add(s[p2]);
            }
            p2++;
        }

        return longest;
    }
}
