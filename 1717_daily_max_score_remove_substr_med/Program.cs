Console.WriteLine(new Solution().MaximumGain("aabbaaxybbaabb", 5, 4));

//I give up I'll try again later
public class Solution
{
    public int MaximumGain(string s, int x, int y)
    {
        char firstChar, secondChar;
        int result = 0, addVal;
        if (x > y)
        {
            firstChar = 'a';
            secondChar = 'b';
            addVal = x;
        }
        else
        {
            firstChar = 'b';
            secondChar = 'a';
            addVal = y;
        }
        int left = 0, right = 0;
        char[] sArr = s.ToCharArray();
        while (right < sArr.Length)
        {
            sArr[left++] = sArr[right];
            if (left > 1 && sArr[left - 2] == firstChar && sArr[left - 1] == secondChar)
            {
                result += addVal;
                left -= 2;
            }
            foreach (char c in sArr) { Console.Write(c + " "); }
            Console.WriteLine("right = " + right);
            right++;
        }
        sArr = s.Substring(0, left - 1).ToCharArray();
        //Console.WriteLine(String.Join("", sArr));
        firstChar = firstChar == 'a' ? 'b' : 'a';
        secondChar = secondChar == 'a' ? 'b' : 'a';
        addVal = addVal == x ? y : x;
        left = 0;
        right = 0;
        while (right < sArr.Length)
        {
            sArr[left++] = sArr[right];
            if (left > 1 && sArr[left - 2] == firstChar && sArr[left - 1] == secondChar)
            {
                result += addVal;
                left -= 2;
            }
            right++;
        }
        return result;
    }
}

//Works but TLE
//public class Solution
//{
//    public int MaximumGain(string s, int x, int y)
//    {
//        char firstChar, secondChar;
//        int result = 0, addVal;
//        if (x > y)
//        {
//            firstChar = 'a';
//            secondChar = 'b';
//            addVal = x;
//        }
//        else
//        {
//            firstChar = 'b';
//            secondChar = 'a';
//            addVal = y;
//        }
//        Stack<char> abs = new Stack<char>();
//        foreach (char c in s)
//        {
//            if (abs.Count != 0)
//            {
//                if (abs.Peek() == firstChar)
//                {
//                    if (c == secondChar)
//                    {
//                        result += addVal;
//                        abs.Pop();
//                    }
//                    else
//                    {
//                        abs.Push(c);
//                    }
//                }
//                else
//                {
//                    abs.Push(c);
//                }
//            }
//            else
//            {
//                abs.Push(c);
//            }
//        }
//        s = "";
//        while (abs.Count != 0)
//        {
//            s = abs.Pop() + s;
//        }
//        addVal = addVal == y ? x : y;
//        firstChar = firstChar == 'a' ? 'b' : 'a';
//        secondChar = secondChar == 'b' ? 'a' : 'b';
//        foreach (char c in s)
//        {
//            if (abs.Count != 0)
//            {
//                if (abs.Peek() == firstChar)
//                {
//                    if (c == secondChar)
//                    {
//                        result += addVal;
//                        abs.Pop();
//                    }
//                    else
//                    {
//                        abs.Push(c);
//                    }
//                }
//                else
//                {
//                    abs.Push(c);
//                }
//            }
//            else
//            {
//                abs.Push(c);
//            }
//        }
//        return result;
//    }
//}