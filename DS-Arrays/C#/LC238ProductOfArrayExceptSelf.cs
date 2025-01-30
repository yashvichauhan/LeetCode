public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //prefix and suffix method
        int[] res = new int[nums.Length];
        int prefix = 1;
        int len = nums.Length;
        for(int i = 0; i< len; i++){
            res[i] = prefix;
            prefix *= nums[i];
        }
        //result : take the prefix and multiply it with current suffix
        int suffix = 1;
        for(int j = len-1; j>=0; j--){
            res[j] *= suffix;
            suffix *= nums[j]; 
        }
        return res;
    }
}