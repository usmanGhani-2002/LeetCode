public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
       int mostCandies = candies.Max();
    return candies.Select(
        candyAmount => candyAmount + extraCandies >= mostCandies
    ).ToList();
    }
}