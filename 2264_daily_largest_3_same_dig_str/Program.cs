Console.WriteLine(new Solution().LargestGoodInteger("6777133339"));

public class Solution
{
    public string LargestGoodInteger(string num)
    {
        string result = "";
        for (int i = 2; i < num.Length; i++)
        {
            if (num[i] == num[i - 1] && num[i] == num[i - 2])
            {
                if (result == "" || num[i] > result[0])
                    result = $"{num[i]}{num[i]}{num[i]}";
            }
        }
        return result;
    }
}