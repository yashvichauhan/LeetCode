public class Solution {
    public int RecFn(int i, int j , int[,] dp,string s1, string s2){
        //base case
        if(i<0 || j<0) return 0;
        if(dp[i, j] != -1) return dp[i,j];

        //match
        if(s1[i] == s2[j]){
            return dp[i,j] = 1 + RecFn(i-1, j-1, dp, s1, s2);
        }

        return dp[i, j] = Math.Max(RecFn(i-1, j, dp, s1, s2), RecFn(i, j-1, dp, s1, s2));
    }

    public int LongestCommonSubsequence(string text1, string text2) {
        int n = text1.Length;
        int m = text2.Length;

        int[,] dp = new int[n,m];

        for(int i=0; i<n; i++)
            for(int j=0; j<m; j++)
                dp[i, j] = -1;

        return RecFn(n-1, m-1, dp, text1, text2);
    }
}