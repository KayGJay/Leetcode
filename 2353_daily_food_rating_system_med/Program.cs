public class FoodRatings
{
    private Dictionary<string, (string, int)> Foods = new Dictionary<string, (string, int)>();
    private Dictionary<string, PriorityQueue<string, (int, string)>> Cuisines = new Dictionary<string, PriorityQueue<string, (int, string)>>();

    public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
    {
        for (int i = 0; i < foods.Length; i++)
        {
            Foods[foods[i]] = (cuisines[i], ratings[i]);
            if (!Cuisines.ContainsKey(cuisines[i]))
            {
                Cuisines[cuisines[i]] = new PriorityQueue<string, (int, string)>();
            }
            Cuisines[cuisines[i]].Enqueue(foods[i], (-ratings[i], foods[i]));
        }
    }

    public void ChangeRating(string food, int newRating)
    {
        Cuisines[Foods[food].Item1].Remove(food, out _, out _);
        Foods[food] = (Foods[food].Item1, newRating);
        Cuisines[Foods[food].Item1].Enqueue(food, (-newRating, food));
    }

    public string HighestRated(string cuisine)
    {
        return Cuisines[cuisine].Peek();
    }
}

/**
 * Your FoodRatings object will be instantiated and called as such:
 * FoodRatings obj = new FoodRatings(foods, cuisines, ratings);
 * obj.ChangeRating(food,newRating);
 * string param_2 = obj.HighestRated(cuisine);
 */