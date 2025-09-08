foreach (int[] arr in new Solution().FindFarmland([[1, 1], [0,0]]))
{
    foreach (int num in arr)
        Console.Write(num + " ");
    Console.WriteLine();
}

public class Solution
{
    public int[][] FindFarmland(int[][] land)
    {
        List<int[]> result = new List<int[]>();
        for (int i = 0; i < land.Length; i++)
        {
            for (int j = 0; j < land[i].Length; j++)
            {
                if (land[i][j] == 1)
                {
                    if ((i == 0 && j == 0) || ((i == 0 || land[i - 1][j] == 0) && (j == 0 || land[i][j - 1] == 0)))
                    {
                        int[] newRect = [i, j, i, j];
                        int down = i;
                        int right = j;
                        while (down < land.Length && land[down][right] == 1)
                        {
                            newRect[2] = down;
                            down++;
                        }
                        down--;
                        while (right < land[down].Length && land[down][right] == 1)
                        {
                            newRect[3] = right;
                            right++;
                        }
                        result.Add(newRect);
                    }
                }
            }
        }
        return result.ToArray();
    }
}