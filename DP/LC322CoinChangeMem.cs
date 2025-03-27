public class Solution {
    public int recF(int i, int[] coins, int target, int[,] dp){
        //base case
        if(i == 0){
            if(target % coins[i] ==0){
                return (target / coins[i]);
            }else{
                return int.MaxValue;
            }
        }

        if(dp[i, target] != -1) return dp[i, target];

        int pick = int.MaxValue;
        if(coins[i] <= target) {
            int subRes = recF(i, coins, target - coins[i], dp);  
                if (subRes != int.MaxValue) {  
                    pick = subRes + 1;  
                }
        }
        int notPick = recF(i-1, coins, target, dp);
 
        return dp[i, target] = Math.Min(notPick , pick); 
    }

    public int CoinChange(int[] coins, int amount) {
        //memoization
        int n = coins.Length;
        int[,] dp= new int[n, amount+1];
        for(int i=0; i< n; i++){
            for(int j = 0; j< amount+1; j++){
                dp[i,j] = -1;
            }
        }
        int ans = recF(n-1, coins, amount, dp);
        if(ans >= int.MaxValue) return -1;
        else return ans;
    }

}