class Solution {
    //time complexity is : Big O(n^2)
    public int[] twoSum(int[] nums, int target) {
        int resArr[] = new int[2];
        //iterate through all the array and find the target- val
        int arrLen = nums.length;
        for(int i=0; i<arrLen; i++){
            int sum=0;
            sum = target - nums[i];
            for(int j= 0; j<arrLen; j++){
                if(j!=i && nums[j] == sum){
                    resArr[0] =i;
                    resArr[1] =j;
                }
            }
        }
        return resArr;
    }
    //Todo: implement the solution using hashmap for O(n) linear complexity
    
}