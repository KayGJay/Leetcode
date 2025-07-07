public class Solution
{
    public int MaxEvents(int[][] events)
    {
        events = events.OrderBy(x => x[0]).ThenBy(x => x[1]).ToArray();
        var minHeap = new PriorityQueue<int[], int>();
        //foreach (var arr in events) foreach (var item in arr) Console.WriteLine(item);
        int latestEvent = events[0][1];
        int earliestEvent = events[0][0];
        int maxEvents = 0;
        foreach (var arr in events)
        {
            if (arr[0] < earliestEvent)
            {
                earliestEvent = arr[0];
            }
            if (arr[1] > latestEvent)
            {
                latestEvent = arr[1];
            }
        }
        int i = 0;
        while (earliestEvent <= latestEvent)
        {
            while (i < events.Length)
            {
                if (events[i][0] == earliestEvent)
                {
                    Console.WriteLine($"Enqueuing [{events[i][0]}, {events[i][1]}]");
                    minHeap.Enqueue(events[i], events[i][1]);
                    i++;
                }
                else
                {
                    break;
                }
            }
            while (minHeap.Count != 0 && minHeap.Peek()[1] < earliestEvent)
            {
                Console.WriteLine($"Cannot visit, dequeueing [{minHeap.Peek()[0]}, {minHeap.Peek()[1]}]");
                minHeap.Dequeue();
            }
            if (minHeap.Count != 0 && minHeap.Peek()[1] >= earliestEvent)
            {
                minHeap.Dequeue();
                maxEvents++;
            }
            earliestEvent++;
        }
        //Console.WriteLine(earliestEvent + " " + latestEvent);
        return maxEvents;
    }
}