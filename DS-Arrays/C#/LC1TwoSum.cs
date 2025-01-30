public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int,int>();
        int[] res = new int[2];

        for(int i= 0; i< nums.Length; i++){
            //target can be a negative or a positive number
            int tmp = target - nums[i];
            if(map.ContainsKey(tmp)){
                res[0] = map[tmp];
                res[1] = i;
                break;
            }else if(!map.ContainsKey(nums[i])){
                map.Add(nums[i], i);
            }
        }
        return res;
    }
}