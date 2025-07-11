//Still incorrect, try a foreach on meetings and use the durations
//Hint, PriorityQueue<(long endTime, int room), (long, int)> minheap by endtime then room number

Solution sol = new Solution();
Console.WriteLine(sol.MostBooked(3, [[39, 49], [28, 39], [9, 29], [10, 36], [22, 47], [2, 3], [4, 49], [46, 50], [45, 50], [17, 33]]));

public class Solution
{
    public int MostBooked(int n, int[][] meetings)
    {
        var freeRooms = new PriorityQueue<int, int>();
        var currMeetings = new PriorityQueue<int, int>();
        var timesUsed = new Dictionary<int, int>();
        meetings = meetings.OrderBy(x => x[0]).ToArray();
        foreach (var meeting in meetings)
        {
            Console.WriteLine(meeting[0] + ", " + meeting[1]);
        }

        for (int i = 0; i < n; i++)
        {
            freeRooms.Enqueue(i, i);
            timesUsed[i] = 0;
        }

        int dequeuedMeetings = 0;
        int delay = 0, time = 0, idx = 0;
        while (dequeuedMeetings != meetings.Length)
        {
            Console.WriteLine(dequeuedMeetings);
            currMeetings.TryPeek(out _, out int endTime);
            while (endTime == time && currMeetings.Count != 0)
            {
                int roomNumber = currMeetings.Dequeue();
                dequeuedMeetings++;
                freeRooms.Enqueue(roomNumber, roomNumber);
                currMeetings.TryPeek(out _, out endTime);
            }
            if (idx < meetings.Length && freeRooms.Count == 0 && meetings[idx][1] == time)
            {
                delay++;
            }
            else
            {
                while (idx < meetings.Length && meetings[idx][0] + delay == time)
                {
                    bool roomFree = freeRooms.TryDequeue(out int roomNumber, out int _);
                    if (roomFree)
                    {
                        currMeetings.Enqueue(roomNumber, meetings[idx][1] + delay);
                        timesUsed[roomNumber]++;
                        idx++;
                    }
                    else
                    {
                        delay++;
                    }
                }
            }
            time++;
        }
        foreach (var pair in timesUsed) { Console.WriteLine(pair.Key +  ": " + pair.Value); }
        return timesUsed.MaxBy(x => x.Value).Key;
    }
}