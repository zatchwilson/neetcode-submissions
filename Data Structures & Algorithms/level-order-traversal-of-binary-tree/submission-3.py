# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    levels = []
    def levelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        
        self.levels = []
        self.addToLevels(root, 0)

        
        return self.levels

    def addToLevels(self, curr: Optional[TreeNode], level: int):

        if curr is None:
            return
        
        if len(self.levels) <= level:
            self.levels.append([])

        self.levels[level].append(curr.val)

        level += 1

        self.addToLevels(curr.left, level)
        self.addToLevels(curr.right, level)