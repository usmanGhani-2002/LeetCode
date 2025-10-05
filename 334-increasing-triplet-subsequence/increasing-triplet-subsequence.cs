public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int first = int.MaxValue;
        int second = int.MaxValue;

        foreach (int num in nums) {
            if (num <= first) {
                first = num;         // update the smallest so far
            } else if (num <= second) {
                second = num;        // update the second smallest
            } else {
                // If we get here, it means: first < second < num
                return true;
            }
        }

        return false;
    }
}
