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
    private int nodeCount;
    public int GoodNodes(TreeNode root) {
        nodeCount = 0;

        if (root != null)
        {
            CountNodes(root, root.val);
        }

        return nodeCount;
    }

    private void CountNodes(TreeNode curr, int currLargest)
    {
        if (curr == null)
            return;
        
        if (currLargest <= curr.val)
        {
            nodeCount++;
            currLargest = curr.val;
        }
        
        CountNodes(curr.left, currLargest);
        CountNodes(curr.right, currLargest);
    }
}
