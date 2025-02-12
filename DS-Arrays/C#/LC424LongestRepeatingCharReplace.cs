public class Solution {
    public int CharacterReplacement(string s, int k) {
        int maxLen = 0;
        int l = 0 ; 
        int r = 0;
        int[] currFreq = new int [26];
        int maxFreq = 0;
        char[] arr = s.ToCharArray();
        
        while(r < arr.Length){
            currFreq[arr[r] - 'A']++;
            maxFreq = Math.Max(maxFreq, currFreq[arr[r] - 'A']);
            
            while((r-l +1) - maxFreq > k){
                currFreq[arr[l] - 'A']--;
                l++;
                //find current maxFreq O(26)
                foreach(int x in currFreq){
                    maxFreq = Math.Max(maxFreq, x);
                }
            }
            maxLen = Math.Max(maxLen, r-l+1);
            r++;
        }
        return maxLen;
    }
}