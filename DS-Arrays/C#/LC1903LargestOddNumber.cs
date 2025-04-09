public class Solution {
    public string LargestOddNumber(string num) {
        string ans = "";
        int j = num.Length -1;

        while(j>= 0){
            string sb = num[j].ToString();
            int last = Int32.Parse(sb);
            if(last%2 != 0){
                ans+= num.Substring(0, j+1);
                break;
            }
            j--;
        }
        
        return ans;
    }
}