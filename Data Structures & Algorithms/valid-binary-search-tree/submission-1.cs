/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsValidBST(TreeNode root) {

        return ValidNode(root, -1001, 1001);
    }

    private bool ValidNode(TreeNode curr, int lB, int rB)
    {
        if (curr == null)
            return true;

        if (curr.val <= lB || curr.val >= rB)
            return false;
        
        return ValidNode(curr.left, lB, curr.val) && ValidNode(curr.right, curr.val, rB);
    }
}
