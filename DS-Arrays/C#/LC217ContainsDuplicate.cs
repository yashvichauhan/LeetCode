public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        //sort the array
        Array.Sort(nums);
        //get the repeated values
        for(int i = 0; i< nums.Length-1; i++){
            if(nums[i]==nums[i+1]){
                return true;
            }
        }
        return false;
    }
}