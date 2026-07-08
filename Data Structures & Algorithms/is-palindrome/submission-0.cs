public class Solution {
    public bool IsPalindrome(string s) {

        
        // s = string.ToLower(s);

        // s = new string(s.Where(char.IsLetterOrDigit).ToArray());

        int end = s.Length - 1;
        int start = 0;

        while (end > start)
        {
            while (start < end && !char.IsLetterOrDigit(s[start]))
                start++;
            
            while (start < end && !char.IsLetterOrDigit(s[end]))
                end--;

            
            if (char.ToLower(s[start]) != char.ToLower(s[end]))
                return false;
            
            start++;
            end--;
        }

        return true;
    }
}
