class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:

        if len(s) < 2:
            return len(s)
        
        letterSet = set()
        maxLength = 1

        l = 0
        r = 1

        letterSet.add(s[l])

        while r < len(s):
            if s[r] in letterSet:
                while s[l] != s[r]:
                    letterSet.remove(s[l])  
                    l+=1
                l += 1
                r += 1
            else:
                letterSet.add(s[r])
                maxLength = max(maxLength, r - l + 1)
                r += 1

        return maxLength

                





        