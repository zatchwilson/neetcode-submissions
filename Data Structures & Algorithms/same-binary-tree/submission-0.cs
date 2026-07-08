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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        return CheckTree(p, q);
    }
    private bool CheckTree(TreeNode pCurr, TreeNode qCurr)
    {
        if (pCurr == null && qCurr == null)
            return true;

        if (pCurr == null || qCurr == null)
            return false;

        if (pCurr.val != qCurr.val)
            return false;

        return CheckTree(pCurr.left, qCurr.left) && CheckTree(pCurr.right, qCurr.right);
        
    }
}
