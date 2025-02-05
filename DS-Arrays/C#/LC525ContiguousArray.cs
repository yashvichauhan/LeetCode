public class Solution {
    public int FindMaxLength(int[] nums) {
        Dictionary<int, int> map = new();
        int max = 0;
        int n = nums.Length;
        int sum = 0;
        map[0] = -1;
        for(int i = 0; i < n; i++) {
            sum += (nums[i] == 1 ? 1 : -1);
            if(map.ContainsKey(sum))
                max = Math.Max(max, i - map[sum]);
            else
                map[sum] = i;
        }
        return max;
    }
}