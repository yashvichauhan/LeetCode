public class Solution {
    public int MaxSubArray(int[] nums) {
        int MaxSum = int.MinValue;
        int tmpSum = 0;
        //kedane's algorithm
        for(int i=0; i< nums.Length; i++){
            int curr = tmpSum + nums[i];

            if(curr > 0){
                tmpSum = curr;
            }else{
                tmpSum = 0;
            }
            MaxSum = Math.Max(curr, MaxSum);
        }
        return MaxSum;
    }
