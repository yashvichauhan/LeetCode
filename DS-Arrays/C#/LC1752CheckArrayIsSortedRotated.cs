public class Solution {
    public bool Check(int[] nums) {
        int numsLength = nums.Length;
        int countC = 0;
        //optimal approach
        for(int i=0; i<numsLength; i++){
            if(nums[i] > nums[(i+1) % numsLength]){
                countC++;
            }
        }

        return countC<=1;
    }
}