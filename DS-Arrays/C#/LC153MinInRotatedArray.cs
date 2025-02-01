public class Solution {
    public int FindMin(int[] nums) {
        int start = 0;
        int end = nums.Length -1;
        int minValue = int.MaxValue;

        while(start <= end ){
            int mid = (start+end)/2;
            //check if left is sorted
            if(nums[start] <= nums[mid]){
                minValue = Math.Min(nums[start], minValue);
                //go right
                start = mid+1;
            }
            //check if right is sorted
            else if(nums[end] >= nums[mid]){
                minValue = Math.Min(nums[mid], minValue);
                //go left
                end = mid-1;
            }
        }
        return minValue;
    }
}