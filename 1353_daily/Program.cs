using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections.Generic;
using System.Collections;

int[][] test = [[2, 3], [3, 4], [1, 3], [7, 8], [1, 2], [1, 2]];

Array.Sort(test, (x, y) => x[0].CompareTo(y[0]));

foreach (var arr in test) foreach (var item in arr) Console.WriteLine(item);

Solution sol = new Solution();

sol.GetRow(3);

public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        if (rowIndex == 0)
        {
            return [1];
        }
        IList<int> prevRow = GetRow(rowIndex - 1);
        IList<int> thisRow = new List<int>();
        for (int i = 0; i <= rowIndex; i++)
        {
            if (i == 0)
            {
                thisRow.Add(1);
            }
            else if (i == rowIndex)
            {
                thisRow.Add(1);
            }
            else
            {
                Console.WriteLine($"i = {i}, prevRow.Count = {prevRow.Count}");
                thisRow.Add(prevRow[i - 1] + prevRow[i]);
            }
        }
        return thisRow;
    }
}