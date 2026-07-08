class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        dictOne = {}
        dictTwo = {}

        for char in s:
            if char in dictOne:
                dictOne[char]+= 1
            else:
                dictOne[char] = 1

        for char in t:
            if char in dictTwo:
                dictTwo[char]+=1
            else:
                dictTwo[char] = 1
        
        return dictTwo == dictOne