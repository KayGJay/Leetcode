Console.WriteLine(new Solution().CompareVersion("1.01", "1.001"));

public class Solution
{
    public int CompareVersion(string version1, string version2)
    {
        string[] ver1 = version1.Split('.');
        string[] ver2 = version2.Split('.');
        int n = Math.Min(ver1.Length, ver2.Length);
        for (int i = 0; i < n; i++)
        {
            if (int.Parse(ver1[i]) < int.Parse(ver2[i]))
                return -1;
            else if (int.Parse(ver1[i]) > int.Parse(ver2[i]))
                return 1;
        }
        return ver1.Length == ver2.Length || ver1.Sum(x => int.Parse(x)) == ver2.Sum(x => int.Parse(x)) ? 0 : ver1.Length < ver2.Length ? -1 : 1;
    }
}