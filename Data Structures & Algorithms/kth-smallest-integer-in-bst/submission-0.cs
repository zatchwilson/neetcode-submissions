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
    List<int> valList;
    public int KthSmallest(TreeNode root, int k) {
        valList = new();
        FindVals(root);
        return valList[k-1];
    }

    private void FindVals(TreeNode curr)
    {
        if (curr == null)
            return;
        
        FindVals(curr.left);
        valList.Add(curr.val);
        FindVals(curr.right);
    }
}
