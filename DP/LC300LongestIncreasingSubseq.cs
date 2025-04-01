public class Solution {
    public int RecFn(int i, int[] arr, int lastTake, int[,] dp){
        //base case
        if(i == arr.Length){
            return 0;
        }
        //perform all actions
        int take  = 0;
        if(dp[i, lastTake+1] != -1) return dp[i, lastTake+1];
        if(lastTake == -1 || arr[i] > arr[lastTake]){
            take = RecFn(i+1, arr, i, dp) + 1;
        }
        
        int notTake = RecFn(i+1, arr, lastTake, dp);

        //return max
        return dp[i, lastTake+1] = Math.Max(take, notTake);
    }

    public int LengthOfLIS(int[] nums) {
        int n = nums.Length;
        if(n==1) return 1;

        int[,] dp = new int[n,n+1];
        for(int i=0; i< n; i++){
            for(int j=0; j< n+1; j++){
                dp[i, j] = -1;
            }
        }

        return RecFn(0, nums, -1, dp);
    }
}