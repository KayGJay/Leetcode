Console.WriteLine(new Solution().MaxAverageRatio([[1, 2], [3, 5], [2, 2]], 2));

public class Solution
{
    public double MaxAverageRatio(int[][] classes, int extraStudents)
    {
        PriorityQueue<int, double> queue = new PriorityQueue<int, double>();
        for (int i = 0; i < classes.Length; i++)
        {
            double change = ((double)(classes[i][0] + 1) / (classes[i][1] + 1)) - ((double)(classes[i][0]) / (classes[i][1]));
            Console.WriteLine($"{classes[i][0]}, {classes[i][1]}");
            Console.WriteLine($"{change}");
            queue.Enqueue(i, -change);
        }
        int added = 0;
        while (added < extraStudents)
        {
            int arrIdx = queue.Dequeue();
            classes[arrIdx][0]++;
            classes[arrIdx][1]++;
            double change = ((double)(classes[arrIdx][0] + 1) / (classes[arrIdx][1] + 1)) - ((double)(classes[arrIdx][0]) / (classes[arrIdx][1]));
            queue.Enqueue(arrIdx, -change);
            added++;
        }
        double sumAvg = 0;
        foreach (var arr in classes)
        {
            sumAvg += ((double)arr[0] / arr[1]);
        }
        return sumAvg / classes.Length;
    }
}