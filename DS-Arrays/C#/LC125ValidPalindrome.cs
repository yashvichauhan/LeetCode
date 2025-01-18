public class Solution {
    public bool IsPalindrome(string s) {
        char[] str = s.Trim().ToCharArray();
        //corner case - removing all the inital non alphanumeric/digit from the char arr
        int k = 0;
        while(k<str.Length && !Char.IsLetterOrDigit(str[k])){
            k++;
        }
        int j = (str.Length)-1;
        //two pointer approach 
        for(int i=k; i<=(str.Length + k)/2 -1; i++){
            if(j<i){
                break;
            }
            if(Char.IsLetterOrDigit(str[i])){
                while(!Char.IsLetterOrDigit(str[j])){
                    j--;
                } 
                if(Char.ToLower(str[i])!= Char.ToLower(str[j])){
                    return false;
                }
                j--;
            }
        }
        return true;
    }
}