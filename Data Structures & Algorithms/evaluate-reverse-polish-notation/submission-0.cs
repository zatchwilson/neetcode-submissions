public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> vals = new();
        int result = 0;

        vals.Push(Int32.Parse(tokens[0]));

        for (int index = 1; index < tokens.Length; index++)
        {
            string curr = tokens[index];
            int ls, rs, newVal;

            switch (curr)
            {
                case "+":
                    rs = vals.Pop();
                    ls = vals.Pop();

                    newVal = ls + rs;
                    vals.Push(newVal);
                    break;

                case "-":
                    rs = vals.Pop();
                    ls = vals.Pop();

                    newVal = ls - rs;
                    vals.Push(newVal);
                    break;

                case "*":
                    rs = vals.Pop();
                    ls = vals.Pop();

                    newVal = ls * rs;
                    vals.Push(newVal);
                    break;

                case "/":
                    rs = vals.Pop();
                    ls = vals.Pop();

                    newVal = ls / rs;
                    vals.Push(newVal);
                    break;

                default:
                    vals.Push(Int32.Parse(tokens[index]));
                    break;
            }
        }

        return vals.Pop();

    }
}
