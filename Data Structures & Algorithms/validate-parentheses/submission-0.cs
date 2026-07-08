public class Solution {
    public bool IsValid(string s) {
        Stack<char> checker = new();

        for (int i = 0; i < s.Length; i++)
        {
            char curr = s[i];

            switch (curr)
            {
                case '[':
                case '(':
                case '{':
                    checker.Push(curr);
                    break;

                case ']':
                    if (checker.Count() == 0)
                        return false;
                    if (checker.Pop() != '[')
                        return false;
                    break;

                case ')':
                    if (checker.Count() == 0)
                        return false;
                    if (checker.Pop() != '(')
                        return false;
                    break;

                case '}':
                    if (checker.Count() == 0)
                        return false;
                    if (checker.Pop() != '{')
                        return false;
                    break;   
            }
        }

        if (checker.Count() != 0)
            return false;

        return true;
    }
}
