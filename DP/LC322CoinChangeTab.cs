public class Solution {

    public int CoinChange(int[] coins, int amount) {
        //memoization
        int n = coins.Length;
        int[,] dp= new int[n, amount+1];
        for(int t=0; t< amount+1; t++){
            if(t % coins[0] == 0) {
                dp[0,t] = t/coins[0];
            }else{
                dp[0, t] = int.MaxValue;
            }
        }
        //tabularization
        for(int i=1; i< n; i++){
            for(int t=0; t< amount+1; t++){
                int pick = int.MaxValue;
                if(coins[i] <= t) {
                    int subRes = dp[i, t - coins[i]];  
                    if (subRes != int.MaxValue) {  
                        pick = subRes + 1;  
                    }
                }
                int notPick = dp[i-1,t];
                dp[i, t] = Math.Min(pick, notPick); 
            }
        }
        int ans = dp[n-1, amount];
        //int ans = recF(n-1, coins, amount, dp);
        if(ans >= int.MaxValue) return -1;
        else return ans;
    }

}