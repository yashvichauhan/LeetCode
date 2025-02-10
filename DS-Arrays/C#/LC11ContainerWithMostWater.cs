public class Solution {
    public int MaxArea(int[] height) {
        int n = height.Length;
        int start = 0; 
        int end = n -1;
        int maxWater = 0;

        while(start< end){
            int waterCap = (end - start) * Math.Min(height[start], height[end]);
            maxWater = Math.Max(waterCap, maxWater);

            if(height[start]<= height[end]){
                start++;
            }else{
                end--;
            }
        } 
        return maxWater;
    }
}