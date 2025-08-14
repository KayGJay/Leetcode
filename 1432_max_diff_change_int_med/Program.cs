//Not done yet, have to handle most sig dig being 9

Console.WriteLine(new Solution().MaxDiff(123456));

public class Solution
{
    public int MaxDiff(int num)
    {
        string numStr = num.ToString();
        char num1 = numStr[0];
        char num2;
        int i = 1;
        if (numStr[0] == '1')
        {
            while (numStr[i] == '1')
            {
                i++;
            }
            num2 = numStr[i];
        }
        else
            num2 = num1;
        Console.WriteLine(num1 + " " + num2);
        int max = int.Parse(numStr.Replace(num1, '9'));
        int min = num2 == num1 ? int.Parse(numStr.Replace(num2, '1')) : int.Parse(numStr.Replace(num2, '0'));
        return max - min;
    }
}