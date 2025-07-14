Console.WriteLine(new Solution().MaxDistance("WEWE", 2));

//Uggggh I'll do it another time
public class Solution
{
    public int MaxDistance(string s, int k)
    {
        int maxDistance = 0;
        Dictionary<char, int> directions = new Dictionary<char, int>()
        {
            {'N', 0},
            {'S', 0},
            {'E', 0},
            {'W', 0}
        };

        foreach (char c in s)
        {
            directions[c]++;
            maxDistance = Math.Max(maxDistance, Math.Min(directions['N'], directions['S']) + Math.Min(directions['E'], directions['W']));
        }

    }
}


//Massive if else, incorrect, there must be something better
//public class Solution
//{
//    public int MaxDistance(string s, int k)
//    {
//        int maxDistance = 0;

//        Dictionary<char, int> directions = new Dictionary<char, int>()
//        {
//            {'N', 0},
//            {'S', 0},
//            {'E', 0},
//            {'W', 0}
//        };

//        foreach (char c in s)
//        {
//            directions[c]++;
//            maxDistance = Math.Max(maxDistance, Math.Abs(directions['N'] - directions['S']) + Math.Abs(directions['E'] - directions['W']));
//        }
//        Console.WriteLine(maxDistance);

//        foreach (var pair in directions) { Console.WriteLine(pair.Key + ": " + pair.Value); }
//        Console.WriteLine();

//        int steps = k;

//        while (steps > 0)
//        {
//            if ((directions['N'] == 0 && directions['E'] == 0) || (directions['S'] == 0 && directions['W'] == 0) ||
//                (directions['N'] == 0 && directions['W'] == 0) || (directions['S'] == 0 && directions['E'] == 0))
//            {
//                break;
//            }
//            bool stepped = false;
//            int north = directions['N'], south = directions['S'], east = directions['E'], west = directions['W'];
//            if (north == south && north + south != 0)
//            {
//                if (east >= west)
//                {
//                    directions['E']++;
//                    if (directions['S'] != 0)
//                        directions['S']--;
//                    else
//                        directions['N']--;
//                }
//                else
//                {
//                    directions['W']++;
//                    if (directions['S'] != 0)
//                        directions['S']--;
//                    else
//                        directions['N']--;
//                }
//                maxDistance++;
//            }
//            else if (east == west && east + west != 0)
//            {
//                if (north >= south)
//                {
//                    directions['N']++;
//                    if (directions['W'] != 0)
//                        directions['W']--;
//                    else
//                        directions['E']--;
//                }
//                else
//                {
//                    directions['S']++;
//                    if (directions['W'] != 0)
//                        directions['W']--;
//                    else
//                        directions['E']--;
//                }
//                maxDistance++;
//            }
//            else if (north >= south && south > 0)
//            {
//                directions['N']++;
//                directions['S']--;
//            }
//            else if (south >= north && north > 0)
//            {
//                directions['S']++;
//                directions['N']--;
//            }
//            else if (east >= west && west > 0 && !stepped)
//            {
//                directions['E']++;
//                directions['W']--;
//            }
//            else if (west >= east && east > 0 && !stepped)
//            {
//                directions['W']++;
//                directions['E']--;
//            }
//            maxDistance++;
//            steps--;
//        }
//        foreach (var pair in directions) { Console.WriteLine(pair.Key + ": " + pair.Value); }
//        //maxDistance += Math.Abs(directions['N'] - directions['S']) + Math.Abs(directions['E'] - directions['W']) + startingDist;
//        return Math.Max(maxDistance, Math.Abs(directions['N'] - directions['S']) + Math.Abs(directions['E'] - directions['W']));
//    }
//}