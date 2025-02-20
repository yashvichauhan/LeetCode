public class Solution {
    public int Rob2(int[] nums) {
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

    public int Rob(int[] nums) {
        int n = nums.Length;
        if(n==1) return nums[0];
        
        int[] tmp1 = new int[n];
        int[] tmp2 = new int[n];
        
        for(int i=0; i< n; i++){
            if(i!=n-1) tmp1[i] = nums[i];
            if(i!=0) tmp2[i-1] = nums[i];
        }

        return Math.Max(Rob2(tmp1), Rob2(tmp2));
    }
}