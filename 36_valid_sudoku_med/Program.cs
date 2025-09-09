string[][] vertTestStr = [["7","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]];

char[][] vertTest = new char[9][];

for (int i = 0; i < vertTestStr.Length; i++)
{
    var arr = vertTestStr[i];
    char[] toAdd = new char[arr.Length];
    for (int j = 0; j < arr.Length; j++)
    {
        toAdd[j] = arr[j][0];
        vertTest[i] = toAdd;
    }
    
}

foreach (var arr in vertTest) 
{ 
    foreach (char c in arr) 
    { 
        Console.Write(c); 
    } 
    Console.WriteLine(); 
}

Console.WriteLine(new Solution().CheckHoriz(vertTest));

public class Solution
{
    public bool CheckSquare(char[][] board, int i, int j)
    {
        HashSet<char> present = new HashSet<char>();
        int iStop = i + 3, jStop = j + 3;
        while (i < iStop)
        {
            int j2 = j;
            while (j2 < jStop)
            {
                if (board[i][j2] != '.')
                {
                    if (!present.Add(board[i][j2]))
                    {
                        return false;
                    }
                }
                j2++;
            }
            i++;
        }
        return true;
    }

    public bool CheckHoriz(char[][] board)
    {
        int i = 0;
        while (i < 9)
        {
            HashSet<char> present = new HashSet<char>();
            int j = 0;
            while (j < 9)
            {
                if (board[i][j] != '.')
                {
                    if (!present.Add(board[i][j]))
                        return false;
                }
                j++;
            }
            i++;
        }
        return true;
    }

    public bool CheckVert(char[][] board)
    {
        for (int j = 0; j < 9; j++)
        {
            HashSet<char> present = new HashSet<char>();
            for (int i = 0; i < 9; i++)
            {
                if (board[i][j] != '.' && !present.Add(board[i][j]))
                    return false;
            }
        }
        return true;
    }

    public bool IsValidSudoku(char[][] board)
    {
        for (int i = 0; i <= 54; i += 3)
        {
            for (int j = 0; j < 9; j += 3)
            {
                if (!CheckSquare(board, i % 9, j))
                    return false;
            }
        }
        return CheckHoriz(board) && CheckVert(board);
    }
}