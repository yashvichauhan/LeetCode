public class Solution {
    public int HammingWeight(int n) {
        int count = 0;
        while(n!=0){
            int rem = n%2;
            if(rem != 0){
                count++;
            }
            n /= 2;
        }
        return count;
    }
}