# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    view = []
    def rightSideView(self, root: Optional[TreeNode]) -> List[int]:
        self.view = []
        self.addToView(root, 0)
        return self.view

    def addToView(self, node: Optional[TreeNode], depth: int):
        if node is None:
            return
        if len(self.view) <= depth:
            self.view.append(node.val)

        depth += 1
        self.addToView(node.right, depth)
        self.addToView(node.left, depth)
        