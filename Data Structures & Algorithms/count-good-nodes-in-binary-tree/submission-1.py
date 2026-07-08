# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    count = 0
    def goodNodes(self, root: TreeNode) -> int:
        count = 0
        self.checkNode(root, root.val)

        return self.count

    def checkNode(self, node: Optional[TreeNode], pathMax: int):
        if node is None:
            return

        if node.val >= pathMax:
            self.count += 1
            pathMax = max(node.val, pathMax)
        
        self.checkNode(node.left, pathMax)
        self.checkNode(node.right, pathMax)
        