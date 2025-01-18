public class MaxProfit {
    public int maxProfit(int[] prices) {
        //find the min value in the array to buy stocks
        int profit = 0;
        int pricesLen = prices.length; 
        //greedy solution to find the maximum op
        for (int i=0; i<pricesLen-1; i++){
            for(int j=i+1; j<pricesLen; j++){
                int tempProfit = prices[j]- prices[i];
                if(tempProfit > profit){
                    profit = tempProfit;
                }
            }
        }
        return profit;
    }
}
