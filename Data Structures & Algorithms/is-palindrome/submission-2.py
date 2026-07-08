class Solution:
    def isPalindrome(self, s: str) -> bool:

        end = len(s) - 1
        start = 0

        while start < end:
            while not s[start].isalnum() and start < end:
                start += 1

            while not s[end].isalnum() and start < end:
                end -= 1

            c1 = s[start].lower()
            c2 = s[end].lower()
            if c1 != c2:
                return False
            start += 1
            end -= 1
        
        return True
        