public class Solution {
    public int MaxProduct(int[] nums) {
        int maxMul = int.MinValue;
        int prefixM = 1;
        int suffixM = 1;
        int N = nums.Length;
        
        for(int i=0; i< N; i++){
            prefixM *= nums[i];
            suffixM *= nums[N-i-1];
            //setting max
            maxMul = Math.Max(maxMul, Math.Max(prefixM, suffixM));
            //reset if 0            
            if(prefixM == 0){
                prefixM = 1;
            }
            if(suffixM == 0){
                suffixM = 1;
            }
        }
        return maxMul;
    }
}