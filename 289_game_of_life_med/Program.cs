//Can do in O(1) memory without list if during first pass, I add 2 to the value of 
//Cells that will live in the next generation and cheching % 2 = 1 for status of other
//cells, then updating to cell[i][j] / 2 on next pass

public class Solution
{
    public void GameOfLife(int[][] board)
    {
        List<int[]> cellsToFlip = new List<int[]>();
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                int numNeighbors = NumLivingNeighbors(board, i, j);
                if (board[i][j] == 1)
                {
                    if (numNeighbors < 2 || numNeighbors > 3)
                    {
                        cellsToFlip.Add([i, j]);
                    }
                }
                else
                {
                    if (numNeighbors == 3)
                    {
                        cellsToFlip.Add([i, j]);
                    }
                }
            }
        }
        foreach (var arr in cellsToFlip)
        {
            board[arr[0]][arr[1]] = (board[arr[0]][arr[1]] + 1) % 2;
        }
    }
    public int NumLivingNeighbors(int[][] board, int i, int j)
    {
        int result = 0;
        bool addI = i + 1 < board.Length;
        bool subI = i - 1 >= 0;
        bool addJ = j + 1 < board[i].Length;
        bool subJ = j - 1 >= 0;
        if (subI)
        {
            result += board[i - 1][j];
            if (subJ)
            {
                result += board[i - 1][j - 1];
            }
            if (addJ)
            {
                result += board[i - 1][j + 1];
            }
        }
        if (addI)
        {
            result += board[i + 1][j];
            if (subJ)
            {
                result += board[i + 1][j - 1];
            }
            if (addJ)
            {
                result += board[i + 1][j + 1];
            }
        }
        if (subJ)
        {
            result += board[i][j - 1];
        }
        if (addJ)
        {
            result += board[i][j + 1];
        }
        return result;
    }
}