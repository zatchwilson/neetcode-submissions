public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        //Need to keep track of each letter of the alphabet, can then compare the two strings and see if their letter makup is identical
        // Use sliding window on the second string to keep track of the current character array, and if they're equal return true

        if (s1.Length > s2.Length)
            return false;

        int[] charArrayOne = new int[26];
        int[] charArrayTwo = new int[26];


        int wSize = s1.Length;

        for (int i = 0; i < wSize; i++)
        {
            int currIndex = s1[i] - 'a';
            charArrayOne[currIndex]++;

            currIndex = s2[i] - 'a';
            charArrayTwo[currIndex]++;
        }

        int matches = 0;

        for (int i = 0; i < 26; i++)
        {
            if (charArrayOne[i] == charArrayTwo[i])
                matches++;
        }



        int l = 0;

        for(int r = wSize; r < s2.Length; r++)
        {
            if (matches == 26)
                return true;

            int currIndex = s2[r] - 'a';
            charArrayTwo[currIndex]++;

            if (charArrayOne[currIndex] == charArrayTwo[currIndex])
                matches++;
            else if (charArrayOne[currIndex] + 1 == charArrayTwo[currIndex] )
                matches--;

            currIndex = s2[l] - 'a';

            charArrayTwo[currIndex]--;

            if (charArrayOne[currIndex] == charArrayTwo[currIndex])
                matches++;
            else if (charArrayOne[currIndex] -1 == charArrayTwo[currIndex])
                matches--;

            l++;
        }

        return matches == 26;

        
    }
}
