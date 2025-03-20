public class Solution {
    public int RecMove(int i, int j, int[][] obsGrid){
        //base case
        if(i<0 || j<0 || obsGrid[i][j]==-2){
            return 0;
        }
        if(i==0 && j==0){
            return 1;
        }
        
        if(obsGrid[i][j]!= -1) {
            return obsGrid[i][j];
        }

        int up = RecMove(i-1, j, obsGrid);
        int left = RecMove(i, j-1, obsGrid);

        return obsGrid[i][j] = up+left;
    }

    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int m = obstacleGrid.Length;      
        int n = obstacleGrid[0].Length;    

        for(int i= 0; i< obstacleGrid.Length; i++){
            for(int j=0; j< obstacleGrid[0].Length; j++){
                if(obstacleGrid[i][j] == 1){
                    obstacleGrid[i][j] = -2;
                }else{
                    obstacleGrid[i][j] = -1;
                }
            }
        }

        return RecMove(m-1, n-1, obstacleGrid);
    }
}