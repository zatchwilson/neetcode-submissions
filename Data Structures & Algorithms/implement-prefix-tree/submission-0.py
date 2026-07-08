class PrefixTree:

    def __init__(self):
        self.head = Node("")

    def insert(self, word: str) -> None:
        self.head.addWord(word)

    def search(self, word: str) -> bool:
        return self.head.getWord(word)

    def startsWith(self, prefix: str) -> bool:
        return self.head.getPrefix(prefix)
        
        

class Node:

    def __init__ (self, val: str, endOW = False):
        self.val = val
        self.endOW = endOW
        self.nextChars = {}
    
    def addWord(self, word: str):
        if word is None:
            return
        char = word[0]

        if char in self.nextChars:
            if len(word) == 1:
                self.nextChars[char].endOW = True
            else:
                self.nextChars[char].addWord(word[1:])
        else:
            new = Node(char)
            self.nextChars[char] = new
            if len(word) == 1:
                self.nextChars[char].endOW = True
            else:
                new.addWord(word[1:])

    def getWord(self, word: str) -> bool:
        if len(word) < 1:
            return self.endOW
        
        char = word[0]

        if char in self.nextChars:
            return self.nextChars[char].getWord(word[1:])
        return False

    def getPrefix(self, word: str) -> bool:
        if len(word) < 1:
            return True
        char = word[0]
        if char in self.nextChars:
            return self.nextChars[char].getPrefix(word[1:])
        return False

