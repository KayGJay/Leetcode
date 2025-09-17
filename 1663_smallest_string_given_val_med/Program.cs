Console.WriteLine(new Solution().GetSmallestString(5, 73));

Console.WriteLine((int)'f' - (int)'a');

public class Solution
{
    public Dictionary<int, char> charVals = new Dictionary<int, char>
    {
        { 1, 'a' },
        { 2, 'b' },
        { 3, 'c' },
        { 4, 'd' },
        { 5, 'e' },
        { 6, 'f' },
        { 7, 'g' },
        { 8, 'h' },
        { 9, 'i' },
        { 10, 'j' },
        { 11, 'k' },
        { 12, 'l' },
        { 13, 'm' },
        { 14, 'n' },
        { 15, 'o' },
        { 16, 'p' },
        { 17, 'q' },
        { 18, 'r' },
        { 19, 's' },
        { 20, 't' },
        { 21, 'u' },
        { 22, 'v' },
        { 23, 'w' },
        { 24, 'x' },
        { 25, 'y' },
        { 26, 'z' }
    };
    //public string GetSmallestString(int n, int k)
    //{
    //    string result = "";
    //    int value = 0;
    //    char toAdd = 'a';
    //    int valToAdd = 0;
    //    while (result.Length < n)
    //    {
    //        Console.WriteLine((k - (value + 1)) + ": " + ((n - (result.Length + 1)) * 26));
    //        if (k - (value + 1) <= (n - (result.Length + 1)) * 26)
    //        {
    //            toAdd = 'a';
    //            valToAdd = 1;
    //        }
    //        else if (k - value <= 26)
    //        {
    //            toAdd = charVals[k - value];
    //            valToAdd = k - value;
    //        }
    //        else if ((k - value) % 26 == 0)
    //        {
    //            toAdd = 'z';
    //            valToAdd = 26;
    //        }
    //        else
    //        {
    //            valToAdd = 2;
    //            while ((k - value - valToAdd) % 26 != 0)
    //            {
    //                valToAdd++;
    //            }
    //            toAdd = charVals[valToAdd];
    //        }
    //        result += toAdd;
    //        value += valToAdd;
    //    }
    //    return result;
    //}
    public string GetSmallestString(int n, int k)
    {
        string result = "";
        if (k - n < 26)
        {
            result += new string('a', n - 1);
            result += charVals[k - result.Length];
        }
        else
        {
            int value = 0;
            result += new string('a', k / 26);
            value += result.Length;
            result += charVals[(k - value) % 26];
            value += (k - value) % 26;
            result += new string('z', (k - value) / 26);
        }
        return result;
    }
}