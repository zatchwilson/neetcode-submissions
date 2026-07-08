public class LRUCache {

    private int cap;
    private Dictionary<int, Node> dict;
    private Node head;
    private Node tail;

    public LRUCache(int capacity) {
        head = new Node(0,0);
        tail = new Node(0,0);
        cap = capacity;
        dict = new();
        head.next = tail;
        tail.prev = head;
    }
    
    public int Get(int key) {
        if (dict.ContainsKey(key))
        {
            Node curr = dict[key];
            Put(key, curr.Value);
            return dict[key].Value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {

        if (dict.ContainsKey(key))
        {
            Node curr = dict[key];
            Remove(curr);
            dict.Remove(key);
        }

        Node temp = head.next;

        Node newN = new Node(key, value);
        head.next = newN;
        newN.prev = head;
        newN.next = temp;
        temp.prev = newN;

        dict[key] = newN;

        if (dict.Count > cap)
        {
            Remove(tail.prev);
        }
        
    }

    private void Remove(Node node)
    {
        dict.Remove(node.Key);
        Node next = node.next;
        Node prev = node.prev;

        prev.next = next;
        next.prev = prev;
    }
}

public class Node {
    public int Key { get; set; }
    public int Value { get; set; }
    public Node prev { get; set; }
    public Node next { get; set; }

    public Node(int key, int val)
    {
        Key = key;
        Value = val;
        prev = null;
        next = null;
    }
}