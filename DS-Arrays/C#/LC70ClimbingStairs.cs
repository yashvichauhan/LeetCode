public class Solution {
    public int UpOperations(int n, int[] mp){
        if(n == 1) return 1;
        if(n == 0) return 1;
        
        int l = (mp[n-1]!= 0) ? mp[n-1] : UpOperations(n-1, mp);
        int r = (mp[n-2]!= 0) ? mp[n-2] : UpOperations(n-2, mp);
        
        mp[n] = l+r;
        return l+r;
    }

    public int ClimbStairs(int n) {
        int[] mp = new int[46];
        mp[0] = 1;
        mp[1] = 1;
        return UpOperations(n, mp);
    }
}