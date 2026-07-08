/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    Dictionary<int, Node> nodes;
    public Node CloneGraph(Node node) {
        if (node is null)
            return null;
        nodes = new();
        Node retNode = CloneNode(node);

        return retNode;
    }

    private Node CloneNode(Node node)
    {
        Node copy = new Node();
        copy.val = node.val;
        nodes.Add(copy.val, copy);

        foreach(Node orig in node.neighbors)
        {
            if (nodes.ContainsKey(orig.val))
            {
                copy.neighbors.Add(nodes[orig.val]);
            }
            else
            {
                Node nCopy = CloneNode(orig);
                copy.neighbors.Add(nCopy);
            }
        }

        return copy;

    }
}
