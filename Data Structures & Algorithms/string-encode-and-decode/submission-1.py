class Solution:

    def encode(self, strs: List[str]) -> str:
        if len(strs) == 0:
            return ""
        lengths = []
        res = ""

        for curString in strs:
            lengths.append(len(curString))
            res += (str(len(curString))) + "#" + curString
        return res 

    def decode(self, s: str) -> List[str]:
        if len(s) == 0:
            return []

        res = []

        i = 0

        while i < len(s):
            k = i

            while s[k] != "#":
                k += 1

            length = int(s[i:k])

            k += 1
            
            nextWord = s[k:k+length]
            res.append(nextWord)

            i = k+length

        return res

