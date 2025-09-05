Console.WriteLine(new Solution().MakeTheIntegerZero(3, -2));

//Notsolved, something to do with BitCount()?
public class Solution
{
    public int MakeTheIntegerZero(int num1, int num2)
    {
        int zeroToNum = 0;
        int result = 0;
        while (zeroToNum < num1)
        {
            int i = 1;
            while (zeroToNum + i + num2 < num1)
            {
                Console.WriteLine($"i: {i}");
                i <<= 1;
            }
            zeroToNum += (i >> 1) + num2;
            result++;
        }
        Console.WriteLine(zeroToNum);
        return zeroToNum == num1 ? result : -1; 
    }
}