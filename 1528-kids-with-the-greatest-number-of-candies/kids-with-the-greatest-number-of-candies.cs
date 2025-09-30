public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
       int maxcandies = candies.Max();
    return candies.Select(
        candyAmount => candyAmount + extraCandies >= maxcandies
    ).ToList();
    }
}