Console.WriteLine(new Solution().CheckValidString("(**(*()**()**((**(*)"));

public class Solution
{
    public bool CheckValidString(string s)
    {
        Stack<char> open = new Stack<char>();
        Stack<char> close = new Stack<char>();
        int stars = 0;
        foreach (char c in s)
        {
            if (c == '(')
            {
                open.Push(c);
            }
            if (c == ')')
            {
                if (open.Count == 0)
                {
                    if (stars != 0)
                    {
                        stars--;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    open.Pop();
                }
            }
            if (c == '*')
            {
                stars++;
            }
        }
        Console.WriteLine(s.Length + " " + stars);

        while (stars > 0 && open.Count != 0)
        {
            open.Pop();
        }
        return open.Count == 0 ? true : false;
    }
}