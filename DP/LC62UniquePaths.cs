public class Solution {
    public int RecPaths(int i, int j, int[,] dp){
        //base case
        if(i==0 && j==0){
            return 1;
        }
        
        if(i< 0 || j< 0){
            return 0;
        }
        
        if(dp[i,j]!= -1){
            return dp[i,j];
        }
        int up =  RecPaths(i-1, j, dp);
        int left = RecPaths(i, j-1, dp);
        
        return dp[i,j] = up + left;
    }

    public int UniquePaths(int m, int n) {
        //implementing memoization
        int[,] dp = new int[m, n]; 
        for(int i=0; i< m; i++){
            for (int j=0; j< n; j++){
                dp[i, j]= -1;
            }
        }
        
        return RecPaths(m-1, n-1, dp);
    }
}