namespace LeetCode.Easy._0020_ValidParentheses;

public class ValidParenthesis
{
    public static bool IsValid(string s)
    { 
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
                continue;
            }

            if (stack.Count == 0) return false;
            
            if ((stack.Peek() == '(' && c == ')') 
                || (stack.Peek() == '[' && c == ']')
                || (stack.Peek() == '{' && c == '}'))
            {
                stack.Pop();
            }

            else
            {
                return false;
            }
        }
        if (stack.Count == 0) return true;
        return false;
    }
}