# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def maxDepth(self, root: Optional[TreeNode]) -> int:
        return self.trackDepth(root, 0)

    def trackDepth(self, node: Optional[TreeNode], depth) -> int:
        if node is None:
            return depth
        
        depth += 1
        return max(self.trackDepth(node.left, depth), self.trackDepth(node.right, depth))
        