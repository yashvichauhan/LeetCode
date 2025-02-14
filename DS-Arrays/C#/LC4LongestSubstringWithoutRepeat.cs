public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLen = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();
        int l = 0;
        int r = 0;
        char[] arr = s.ToCharArray();

        while(r < arr.Length){
            if(!map.ContainsKey(arr[r])){
                map.Add(arr[r], 1);
            }else{
                while(arr[l] != arr[r]){
                    map.Remove(arr[l]);
                    l++;
                }
                l++;
            }
            maxLen = Math.Max(maxLen, r-l+1);
            r++;
        }
        return maxLen;
    }
}