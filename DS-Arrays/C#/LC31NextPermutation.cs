public class Solution {
    public void NextPermutation(int[] nums) {
        int n = nums.Length;
        int breakpoint = -1;
        for(int i=n-2; i>=0; i-- ){
            if(nums[i] < nums[i+1]){
                breakpoint = i;
                break;
            }
        }
        if(breakpoint > -1 && breakpoint < n){
            //find the next element and swap
            for(int i= n-1; i>0; i--){
                if(nums[i]> nums[breakpoint]){
                    //swap logic
                    int tmp = nums[breakpoint];
                    nums[breakpoint] = nums[i];
                    nums[i] = tmp;
                    break;
                }
            }
        }
        //reverse left array to sort
        for(int j = breakpoint+1; j<= (n+breakpoint - 1)/2; j++){
            int tmp = nums[j];
            nums[j] = nums[n - j + breakpoint];
            nums[n - j + breakpoint] = tmp;
        }
    }
}