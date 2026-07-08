public class MinStack {

    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack() {
        stack = new();
        minStack = new();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if (minStack.Count != 0)
        {
            if (val > minStack.Peek())
            {
                val = minStack.Peek();
            }
        }

        minStack.Push(val);
            
    }
    
    public void Pop() {
        
        stack.Pop();
        minStack.Pop();

    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
