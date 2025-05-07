public class Solution {

    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> res = new List<IList<int>> ();
        
        for(int i=1; i<= numRows; i++){
            List<int> tmp = new List<int>();
            int ans = 1;
            tmp.Add(ans);
            for(int j=1; j<i; j++){
                ans = ans * (i-j);
                ans = ans / j;
                tmp.Add(ans);
            }
            res.Add(tmp);
        }
        return res;
    }
}