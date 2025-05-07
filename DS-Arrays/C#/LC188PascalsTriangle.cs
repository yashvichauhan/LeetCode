public class Solution {

    public long calculateNcR(int n, int r){
        long prd = 1;
        for(int i=0; i< r; i++){
            prd = prd * (n-i); 
            prd = prd / (i+1);
        }
        return prd;
    }

    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> res = new List<IList<int>> ();
        for(int i=0; i< numRows; i++){
            List<int> tmp = new List<int>();
            for(int j=0; j<=i; j++){
                int x = (int)calculateNcR(i,j);
                tmp.Add(x);
            }
            res.Add(tmp);
        }
        return res;
    }
}