int[] arr = [2, 5, 7, 9, 6, 8, 1, 3];

int[] sum = new int[4 * arr.Length];

buildST(arr, 0, 0, 7);

foreach (int i in arr) Console.Write(i + " ");
Console.WriteLine();
foreach (int i in sum) Console.Write(i + " ");

void buildST(int[] source, int sumIdx, int left, int right)
{
    if (left == right)
    {
        sum[sumIdx] = source[left];
    }
    else
    {
        int mid = (left + right) / 2;
        buildST(source, sumIdx * 2 + 1, left, mid);
        buildST(source, sumIdx * 2 + 2, mid + 1, right);
        sum[sumIdx] = Math.Max(sum[sumIdx * 2 + 1], sum[sumIdx * 2 + 2]);
    }
}