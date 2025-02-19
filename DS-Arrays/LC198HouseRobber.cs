public class Solution {
    // recursive solution 
    // public int RobSmart(int[] nums, int indx, int[] dp){
    //     if(indx == 0) return nums[0];
    //     if(indx < 0) return 0;
        
    //     if(dp[indx] != 0) return dp[indx];

    //     int left = RobSmart(nums, indx-2, dp) + nums[indx];
        
    //     int right = RobSmart(nums, indx-1, dp);

    //     return dp[indx] = Math.Max(left, right);
    // }

    public int Rob(int[] nums) {
        //return RobSmart(nums, nums.Length-1, dp);
        int prev2 = 0;
        int prev = nums[0];
        //Tabularization
        for(int i= 1; i< nums.Length; i++){
            int take = nums[i];
            if(i>1){
                take = prev2 + nums[i]; 
            }
            int nontake = prev;
            int curr = Math.Max(take, nontake);

            //assign
            prev2 = prev;
            prev = curr;
        }
        return prev;
    }
}