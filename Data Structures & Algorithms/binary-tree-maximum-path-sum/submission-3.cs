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
    public int currMax = -1001;
    public int MaxPathSum(TreeNode root) {
        TraverseNodes(root);
        return currMax;
    }

    private int TraverseNodes(TreeNode curr)
    {
        if (curr == null)
            return 0;

        int ls = TraverseNodes(curr.left) + curr.val;
        int rs = TraverseNodes(curr.right) + curr.val;

        int combined = ls + rs - curr.val;

        int max = Math.Max(ls, rs);

        max = Math.Max(max, curr.val);

        int ckMax = Math.Max(max, combined);
        currMax = Math.Max(ckMax, currMax);

        return max;
    }
}
