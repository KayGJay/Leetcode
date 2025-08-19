//Solved, good complexity but more extra memory than many solutions
//Another way is to sort n's digits, then compare powers of 2 and their sorted digits

public class Solution
{
    public bool ReorderedPowerOf2(int n)
    {
        Dictionary<char, int> nDigits = new Dictionary<char, int>();
        int pow = 1;
        string powStr = "1";
        int nLen = n.ToString().Length;
        foreach (char c in n.ToString())
        {
            if (!nDigits.ContainsKey(c))
            {
                nDigits[c] = 0;
            }
            nDigits[c]++;
        }
        while (nLen >= powStr.Length)
        {
            if (nLen == powStr.Length)
            {
                Dictionary<char, int> tempDict = new Dictionary<char, int>();
                foreach (char c in powStr)
                {
                    if (!tempDict.ContainsKey(c))
                    {
                        tempDict[c] = 0;
                    }
                    tempDict[c]++;
                }
                if (tempDict.Count() == nDigits.Count())
                {
                    bool same = true;
                    foreach (var key in tempDict.Keys)
                    {
                        if (!nDigits.ContainsKey(key) || tempDict[key] != nDigits[key])
                        {
                            same = false;
                            break;
                        }
                    }
                    if (same)
                    {
                        return true;
                    }
                }
            }
            pow *= 2;
            powStr = pow.ToString();
        }
        return false;
    }
}