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
    private List<int> valList;
    public List<int> RightSideView(TreeNode root) {
        valList = new();

        AddRightSideView(root, 0);

        return valList;

    }

    private void AddRightSideView(TreeNode curr, int depth){
        if (curr == null)
            return;
        
        if (valList.Count <= depth)
        {
            valList.Add(curr.val);
        }

        depth++;
        AddRightSideView(curr.right, depth);
        AddRightSideView(curr.left, depth);
    }
}
