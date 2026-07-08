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
    public List<List<int>> nodeList = new();

    public List<List<int>> LevelOrder(TreeNode root) {
        AddToTreeList(root, 0);
        return nodeList;
    }

    private void AddToTreeList(TreeNode curr, int level)
    {
        if (curr == null)
            return;
        
        if (nodeList.Count <= level)
            nodeList.Add(new List<int>());
        
        nodeList[level].Add(curr.val);

        AddToTreeList(curr.left, level + 1);
        AddToTreeList(curr.right, level + 1);
    }
}
