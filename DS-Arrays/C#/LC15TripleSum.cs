public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> ans = new List<IList<int>>();
        int n = nums.Length;
        Array.Sort(nums);
        
        //one turn
        for(int i=0; i< n-1; i++){
            //skip repeat
            while((i!=0 && i< n-1) && nums[i] == nums[i-1]){ i++; }
            int j = i+1;
            int k = n-1;

            while(j< k && i< n-1){
                int tsum = nums[i]+ nums[j]+ nums[k];
                if( tsum < 0){
                    j++;
                }
                else if(tsum > 0){
                    k--;
                }
                else {
                    IList<int> placeArr = new List<int>() {nums[i], nums[j], nums[k]};
                    ans.Add(placeArr);
                    j++; k--;
                    while(j<k && nums[j]== nums[j-1]){ j++;}
                    while((j<k && k!= n-1) && nums[k]== nums[k+1]){ k--;}
                }
            }
        }
        return ans;
    }
}