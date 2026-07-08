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

public class Codec {

    public string Serialize(TreeNode root)
    {
        List<string> dfs = DFSSerialize(root);
        return String.Join(',', dfs.ToArray());
    }

    private List<string> DFSSerialize(TreeNode root)
    {
        List<string> ret = new();


        Queue<TreeNode> valQueue = new();

        valQueue.Enqueue(root);

        while (valQueue.Count > 0)
        {
            TreeNode curr = valQueue.Dequeue();

            if (curr == null)
            {
                ret.Add("N");
            }
            else
            {
                ret.Add(curr.val.ToString());
                valQueue.Enqueue(curr.left);
                valQueue.Enqueue(curr.right);
            }
        }


        return ret;
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data)
    {
        List<string> vals = data.Split(',').ToList();

        int index = 1;

        if (vals[0] == "N")
            return null;

        TreeNode root = new TreeNode(Int32.Parse(vals[0]));

        Queue<TreeNode> nodeQueue = new Queue<TreeNode>();

        nodeQueue.Enqueue(root);

        while (nodeQueue.Count > 0)
        {
            TreeNode curr = nodeQueue.Dequeue();

            string lV = vals[index];

            if (lV == "N")
                curr.left = null;
            else
            {
                TreeNode left = new TreeNode(Int32.Parse(lV));
                curr.left = left;
                nodeQueue.Enqueue(left);
            }
            index++;
            string rV = vals[index];


            if (rV == "N")
                curr.right = null;
            else
            {
                TreeNode right = new TreeNode(Int32.Parse(rV));
                curr.right = right;
                nodeQueue.Enqueue(right);
            }

            index++;
        }

        return root;
    }

       

    private TreeNode DFSDeserialize(ref Queue<string> vals)
    {
        string val = vals.Dequeue();

        if (val == "N")
            return null;
        TreeNode curr = new TreeNode(Int32.Parse(val));

        curr.left = DFSDeserialize(ref vals);
        curr.right = DFSDeserialize(ref vals);
        return curr;
    }
}
