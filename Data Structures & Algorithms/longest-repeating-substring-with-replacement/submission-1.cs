public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> chars = new();

        int result = 0;

        int l = 0;
        int max = 0;
        
        //Iterate through the string, always increasing the size of the window
        for (int r = 0; r < s.Length; r++)
        {
            // Increment the count of the newest letter
            if (chars.ContainsKey(s[r]))
                chars[s[r]]++;
            else
                chars[s[r]] = 1;
            
            // See if the current letter is now the dominant one in the string
            max = Math.Max(max, chars[s[r]]);

            // Close the window (from the left) until there are only 'k' letters that aren't the dominant one
            while((r - l + 1) - max > k)
            {
                // Decrement those character's counts
                chars[s[l]]--;
                l++;
            }
            // The result is either the same as before, or is the newest window size
            result = Math.Max(result, r - l + 1);
        }

        return result;
        
    }
}
 