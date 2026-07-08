# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def lowestCommonAncestor(self, root: TreeNode, p: TreeNode, q: TreeNode) -> TreeNode:
        lVal = min(p.val, q.val)
        rVal = max(p.val, q.val)
        return self.findAncestor(root, lVal, rVal)

    def findAncestor(self, node: TreeNode, l: int, r: int) -> TreeNode:
        currV = node.val

        if currV == l or currV == r:
            return node
        
        if l < currV and currV < r:
            return node

        if currV > r:
            return self.findAncestor(node.left, l, r)
        
        return self.findAncestor(node.right, l, r)