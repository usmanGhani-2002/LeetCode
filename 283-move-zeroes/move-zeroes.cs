public class Solution {
    public void MoveZeroes(int[] nums) {
        int i = 0;
        int nonZero = 0;
        while(i < nums.Length){
            if(nums[i] != 0){
                nums[nonZero] = nums[i];
                nonZero++;
            }
            i++;
        }
        while(nonZero < nums.Length){
            nums[nonZero] = 0;
            nonZero++;
        }
    }
}