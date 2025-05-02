public class Solution {
    public int recDecode(string s){
        //base case
        if(s.StartsWith("0")){
            return 0;
        }
        if(s == ""){
            return 1;
        }
        //all actions
        //take one
        int single = 0;
        int doubleVal = 0;
        if(s.Length > 0){
            single = recDecode(s.Substring(1));
        }
        if(s.Length > 1){
            doubleVal = recDecode(s.Substring(2));
        }
        return single + doubleVal;
    }

    public int NumDecodings(string s) {
        return recDecode(s);
    }
}