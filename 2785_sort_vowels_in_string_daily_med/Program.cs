Console.WriteLine(new Solution().SortVowels("lEetcOde"));

Console.WriteLine(Int32.MaxValue);

public class Solution
{
    public string SortVowels(string s)
    {
        int[] vowelCount = new int[10];
        char[] vowels = ['A','E','I','O','U','a','e','i','o','u'];
        char[] sArr = s.ToCharArray();
        Dictionary<char, int> vowelIdx= new Dictionary<char, int>();
        for (int i = 0; i < vowels.Length; i++)
        {
            vowelIdx[vowels[i]] = i;
        }
        foreach (char c in sArr)
        {
            if (vowels.Contains(c))
            {
                vowelCount[Array.IndexOf(vowels, c)]++;
            }
        }
        int countIdx = 0;
        for (int i = 0; i < sArr.Length; i++)
        {
            while (countIdx < 10 && vowelCount[countIdx] == 0)
            {
                countIdx++;
            }
            if (countIdx == 10)
                break;
            if (vowelIdx.ContainsKey(sArr[i]))
            {
                sArr[i] = vowels[countIdx];
                vowelCount[countIdx]--;
            }
        }
        return String.Join("", sArr);
    }
}
//public class Solution
//{
//    public string SortVowels(string s)
//    {
//        List<char> sVowels = new List<char>();
//        string vowels = "AEIOUaeiou";
//        char[] sArr = s.ToCharArray();
//        foreach (char c in sArr)
//        {
//            if (vowels.Contains(c))
//            {
//                sVowels.Add(c);
//            }
//        }
//        sVowels = sVowels.OrderBy(c => c).ToList();
//        foreach (char v in sVowels) Console.WriteLine(v);
//        int i = 0, j = 0;
//        while (i < sArr.Length && j < sVowels.Count())
//        {
//            if (vowels.Contains(sArr[i]))
//            {
//                sArr[i] = sVowels[j++];
//            }
//            i++;
//        }
//        return String.Join("", sArr);
//    }
//}