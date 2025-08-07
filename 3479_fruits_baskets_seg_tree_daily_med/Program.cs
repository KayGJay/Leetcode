int[] arr = [2, 5, 7, 9, 6, 8, 1, 3];

int[] max = new int[4 * arr.Length];

buildST(arr, 0, 0, 7);

foreach (int i in arr) Console.Write(i + " ");
Console.WriteLine();
foreach (int i in max) Console.Write(i + " ");

void buildST(int[] source, int sumIdx, int left, int right)
{
    if (left == right)
    {
        max[sumIdx] = source[left];
    }
    else
    {
        int mid = (left + right) / 2;
        buildST(source, sumIdx * 2 + 1, left, mid);
        buildST(source, sumIdx * 2 + 2, mid + 1, right);
        max[sumIdx] = Math.Max(max[sumIdx * 2 + 1], max[sumIdx * 2 + 2]);
    }
}

int Query(int idx, int left, int right, int qLeft, int qRight)
{
    if (qLeft > right || qRight < left)
    {
        return int.MinValue;
    }
}