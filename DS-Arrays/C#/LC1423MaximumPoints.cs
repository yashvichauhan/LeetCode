public class Solution {
    //LC 1423 : Maximum points you can obtain from cards
    public int MaxScore(int[] cardPoints, int k) {
        int n = cardPoints.Length;
        int lsum = 0;
        int rsum = 0;

        for(int j=0; j<k; j++){
            lsum+= cardPoints[j];
        }  

        int maxPoint = lsum+rsum;
        for(int i=0; i<k; i++){
            lsum-= cardPoints[k-1-i]; 
            rsum+= cardPoints[n-1-i];

            maxPoint = Math.Max(maxPoint, lsum+rsum);
        }

        return maxPoint;
    }
}