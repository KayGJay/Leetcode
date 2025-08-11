foreach (var arr in new Solution().Generate(5)) 
{ 
    foreach (int i in arr) 
        Console.Write(i + ", "); 
    Console.WriteLine();
}

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        var triangle = new List<IList<int>>();
        triangle.Add([1]);
        for (int i = 1; i < numRows; i++)
        {
            var prevRow = triangle[i - 1];
            var nextRow = new List<int>();
            nextRow.Add(1);
            for (int j = 1; j < i; j++)
            {
                nextRow.Add(prevRow[j] + prevRow[j - 1]);
            }
            nextRow.Add(1);
            triangle.Add(nextRow);
        }
        return triangle;
    }
}