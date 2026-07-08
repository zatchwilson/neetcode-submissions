class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:
        strOneCounts = [0] * 26
        strTwoCounts = [0] * 26

        for c in s1:
            strOneCounts[ord(c) - ord('a')] += 1

        windowSize = len(s1)

        l = 0
        r = 0
        strTwoCounts[ord(s2[0]) - ord('a')] = 1

        while r < len(s2):
            while r - l + 1 < windowSize:
                r += 1
                if r == len(s2):
                    return False
                strTwoCounts[ord(s2[r]) - ord('a')] += 1

            if strOneCounts == strTwoCounts:
                return True
            
            strTwoCounts[ord(s2[l])-ord('a')] -= 1
            l += 1

        return False
        