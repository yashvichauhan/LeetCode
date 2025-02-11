public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int maxLen = 0;
        int l = 0; 
        int r = 0;
        int zeros = 0;

        while(r< nums.Length){
            if(nums[r] == 0){
                zeros++;
            }
            while(zeros> k){
                if(nums[l] == 0){
                    zeros--;
                }
                l++;
            }
            maxLen = Math.Max(maxLen, (r-l) +1 );
            r++;
        }
        return maxLen;
    }
}