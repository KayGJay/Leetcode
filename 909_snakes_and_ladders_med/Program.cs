Solution sol = new Solution();

for(int i = 1; i <= 49; i++)
{
    int[] coord = sol.IdxFromNum(7, i);
    Console.WriteLine(i + ": " + coord[0] + ", " + coord[1]);
}

public class Solution
{
    public int SnakesAndLadders(int[][] board)
    {
        return -1;
    }
    public int[] IdxFromNum(int nBoard, int num)
    {
        int i = nBoard - ((num - 1) / nBoard) - 1;
        int j = i % 2 == 0 ? (num - 1) % (nBoard) : (nBoard - 1) - (num - 1) % nBoard;
        return [i, j];
    }
}