public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int profit = 0;

        foreach(int cp in prices){
            if(cp < minPrice){
                minPrice = cp;
            }else if(cp - minPrice > profit){
                profit = cp - minPrice;
            }
        }
        return profit;
    }
}