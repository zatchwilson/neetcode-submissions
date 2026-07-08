# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def isValidBST(self, root: Optional[TreeNode]) -> bool:
        return self.checkValid(root, -1001, 1001)

    def checkValid(self, curr: Optional[TreeNode], minV: int, maxV: int) -> bool:
        if curr is None:
            return True
        
        if curr.val <= minV or curr.val >= maxV:
            return False

        return self.checkValid(curr.left, minV, curr.val) and self.checkValid(curr.right, curr.val, maxV)