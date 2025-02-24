public class Solution {
    public bool IsPalindrome(int x) {
        string inp = x.ToString();
        char[] str = inp.ToCharArray();
        string rev = "";
        for(int i = str.Length-1; i>=0; i-- ){
            rev += str[i];
        }
        return String.Equals(inp, rev);
    }
}