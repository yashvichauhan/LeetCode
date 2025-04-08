public class Solution {
    public int MaxFrequency(int[] nums, int k) {
        Array.Sort(nums);
        int left = 0;
        int right= 0;
        int maxFreq = 0;
        long total = nums[left];
        int n = nums.Length;

        //time complexity is nLongN
        
        while(left<=right && right< n) {
            long calc = Math.BigMul(nums[right], (right-left + 1));
            if(calc <= (k+ total)){
                maxFreq = Math.Max(maxFreq, right-left +1);
                right++;
                if(right<n){
                    total += nums[right];
                }
            }
            else{
                total -= nums[left];
                left++;
            }
        }

        return maxFreq;
    }
}