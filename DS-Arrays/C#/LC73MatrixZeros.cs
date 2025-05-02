
public class Solution {
    public void SetZeroes(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;

        int [] zeroRows = new int[m];
        
        int [] zeroCols = new int[n];

        for (int i = 0; i < m; i++) {
            zeroRows[i] = 1;
        }

        for (int j = 0; j < n; j++) {
            zeroCols[j] = 1;
        }

        for(int i=0; i<m; i++ ){
            for(int j=0; j<n; j++){
                if(matrix[i][j] == 0){
                    zeroRows[i] = 0;
                    zeroCols[j] = 0;
                }
            }
        }
        //update zeros
        for(int i=0; i<m; i++ ){
            for(int j=0; j<n; j++){
                if(zeroRows[i] == 0 || zeroCols[j] == 0)
                    matrix[i][j] = 0;
            }
        }
        
    }
}