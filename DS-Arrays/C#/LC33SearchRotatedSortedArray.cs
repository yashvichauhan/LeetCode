public class Solution {
    public int Search(int[] nums, int target) {
        //target is > 
        int start = 0;
        int end = nums.Length -1;
        int ansIndx = -1;

        while(start <= end){
            int mid = (start + end) / 2;
            if(nums[mid] == target){
                return mid;
            }
            //if left is sorted
            if(nums[mid] >= nums[start]){
                if(target < nums[mid] && target >= nums[start]){
                    //go left
                    end = mid -1;
                }else{
                    start = mid +1;
                }
            }//right is sorted
            else if(nums[mid] <= nums[end]){
                //go right
                if(target > nums[mid] && target<= nums[end]){
                    start = mid+1;
                }
                else{
                    end = mid-1;
                }
            }
        } 
        return ansIndx;
    }
}