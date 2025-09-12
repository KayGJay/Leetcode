public class Solution
{
    public bool DoesAliceWin(string s)
    {
        foreach (char c in s)
        {
            if ("AEIOUaeiou".Contains(c))
            {
                return true;
            }
        }
        return false;
    }
}