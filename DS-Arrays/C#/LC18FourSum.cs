public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        int n = nums.Length;
        int i = 0;
        
        //sort array
        Array.Sort(nums);

        for(i = 0; i<n; i++){
            if(i>0 && nums[i]== nums[i-1]) continue;
            for(int j = i+1; j<n; j++){
                
                if(j>i+1 && nums[j] == nums[j-1]) continue;
                int k = j+1;
                int l = n-1;

                while(k<l){
                    long tmpsum = nums[i];
                    tmpsum+= nums[j];
                    tmpsum+= nums[k];
                    tmpsum+= nums[l];

                    if(tmpsum < target){
                        k++;
                        while(k<n-1 && nums[k-1]==nums[k]) k++;
                    }
                    else if(tmpsum > target){
                        l--;
                        while(l> 0 && nums[l] == nums[l+1]) l--;
                    }
                    else{
                        IList<int> placeArr = new List<int>() {nums[i], nums[j], nums[k], nums[l]};
                        result.Add(placeArr);
                        //skip repeat
                        k++; l--;
                        while((l>k && k<n-1) && (nums[k] == nums[k-1])) k++;
                        while((l>k && l>0) && (nums[l] == nums[l+1])) l--;
                    }
                } 
            }
        }
        return result;
    }
}