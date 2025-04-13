public class Solution {
    public void Combinations(int i, IList<IList<int>>  ansArr, List<int> sumArr, int[] candidates, int target ){
        //base case
        if(i == candidates.Length) {
            return;
        } 
        if(target == 0){
            ansArr.Add(new List<int>(sumArr));
            return;
        }
        //pick
        if(target- candidates[i] >=0 ){
            sumArr.Add(candidates[i]);
            Combinations(i, ansArr, sumArr, candidates, target- candidates[i]);
            sumArr.Remove(candidates[i]);
        }
        Combinations(i+1, ansArr, sumArr, candidates, target);
    }

    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> ansArr = new List<IList<int>>();

        Combinations(0, ansArr, new List<int>(), candidates, target);
        return ansArr;
    }
}