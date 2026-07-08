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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        //Binary search tree: Decendants of two nodes will always be between two values or equal to two values

        // If current node's value is between each value, it is an ancestor
        // If current node's value is EQUAL to one value, it is the answer
        // Traverse based on current value, and check each child

        int l = Math.Min(p.val, q.val);
        int r = Math.Max(p.val, q.val);

        return SearchAncestors(root, l, r);

    }

    private TreeNode SearchAncestors(TreeNode curr, int l, int r)
    {
        if ((l < curr.val && curr.val < r) || l == curr.val || r == curr.val)
            return curr;

        if (r < curr.val)
            return (SearchAncestors(curr.left, l, r));
        else
            return (SearchAncestors(curr.right, l, r));
    }

}
