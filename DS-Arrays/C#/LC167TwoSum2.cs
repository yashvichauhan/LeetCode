public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        //time complexity O(n)
        int[] ans = new int[2];
        int n = numbers.Length;
        int start = 0; 
        int end = n-1;
        
        while(start< end){
            int sum = numbers[start] + numbers[end];
            if(sum == target){
                return new int [2] {start+1, end+1};
            }else if(sum > target){
                end--;
            }else{
                start++;
            }
        }
        return ans;
    }
}