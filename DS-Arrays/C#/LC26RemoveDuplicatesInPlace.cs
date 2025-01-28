public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int j = 0; 
        int N = nums.Length;

        for(int i=1; i< N; i++){
            if(nums[i] != nums[j]){
                nums[++j] = nums[i];
            }
        }
        
        return j+1;
    }
}