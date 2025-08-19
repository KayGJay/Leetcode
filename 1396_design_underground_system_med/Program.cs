UndergroundSystem test = new UndergroundSystem();
test.CheckIn(45, "Leyton", 3);
test.CheckIn(27, "Leyton", 10);
test.CheckOut(45, "Waterloo", 15);
test.CheckOut(27, "Waterloo", 20);
test.GetAverageTime("Leyton", "Waterloo");
test.CheckIn(10, "Leyton", 24);
test.GetAverageTime("Leyton", "Waterloo");
foreach (var pair in test.stationTimes) Console.WriteLine(pair.Key + ": " + pair.Value);
test.CheckOut(10, "Waterloo", 38);
test.GetAverageTime("Leyton", "Waterloo");

public class UndergroundSystem
{
    public Dictionary<(string, string), double> stationTimes;
    public Dictionary<(string, string), int> stationUse;
    public Dictionary<int, int> travelers;
    public Dictionary<int, string> travStation;

    public UndergroundSystem()
    {
        stationTimes = new Dictionary<(string, string), double>();
        travelers = new Dictionary<int, int>();
        stationUse = new Dictionary<(string, string), int>();
        travStation = new Dictionary<int, string>();
    }

    public void CheckIn(int id, string stationName, int t)
    {
        travStation[id] = stationName;
        travelers[id] = t;
    }

    public void CheckOut(int id, string stationName, int t)
    {
        if (!stationUse.ContainsKey((travStation[id], stationName)))
        {
            stationUse[(travStation[id], stationName)] = 0;
            stationTimes[(travStation[id], stationName)] = 0;
        }
        stationUse[(travStation[id], stationName)]++;
        stationTimes[(travStation[id], stationName)] += t - travelers[id];
        travelers.Remove(id);
        travStation.Remove(id);
    }

    public double GetAverageTime(string startStation, string endStation)
    {
        return stationTimes[(startStation, endStation)] / stationUse[(startStation, endStation)];
    }
}