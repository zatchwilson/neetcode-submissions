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

    int preIndex = 0;
    private Dictionary<int, int> inIndex = new Dictionary<int, int>();
    public TreeNode BuildTree(int[] preorder, int[] inorder) {

        for (int i = 0; i < inorder.Length; i++)
            inIndex.Add(inorder[i], i);

        return Dfs(preorder, 0, inorder.Length-1);

        


    }

    private TreeNode Dfs(int[] preorder, int l, int r)
    {
        if (l > r) return null;

         int root_val = preorder[preIndex];
         preIndex++;

         TreeNode root = new TreeNode(root_val);
         int currMid = inIndex[root_val];

         root.left = Dfs(preorder, l, currMid - 1);
         root.right = Dfs(preorder, currMid + 1, r);
         return root;
    }
}
