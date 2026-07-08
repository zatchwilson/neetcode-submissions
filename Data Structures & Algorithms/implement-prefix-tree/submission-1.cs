public class PrefixTree {
    Node head;
    public PrefixTree() {
        head = new Node(' ');
    }
    
    public void Insert(string word) {
        head.AddWord(word);
    }
    
    public bool Search(string word) {
        return head.SearchWholeWord(word);
    }
    
    public bool StartsWith(string prefix) {
        return head.SearchStart(prefix);
    }
}


public class Node {

    private char val;
    private bool endOfWord;
    Dictionary<char, Node> adj;

    public Node(char val){
        this.val = val;
        this.endOfWord = false;
        adj = new();
    }

    public void AddWord(string s)
    {
        if (s.Length == 0)
        {
            endOfWord = true;
            return;
        }

        if (adj.ContainsKey(s[0]))
        {
            adj[s[0]].AddWord(s.Substring(1));
        }
        else
        {
            Node newNode = new Node(s[0]);
            adj[s[0]] = newNode;
            newNode.AddWord(s.Substring(1));
        }
    }

    public bool SearchWholeWord(string s)
    {
        if (s.Length == 0)
            return endOfWord;

        if (adj.ContainsKey(s[0]))
        {
            return adj[s[0]].SearchWholeWord(s.Substring(1));
        }

        return false;
    }

    public bool SearchStart(string s)
    {
        if (s.Length == 0)
            return true;

        if (adj.ContainsKey(s[0]))
        {
            return adj[s[0]].SearchStart(s.Substring(1));
        }

        return false;
        
    }
}