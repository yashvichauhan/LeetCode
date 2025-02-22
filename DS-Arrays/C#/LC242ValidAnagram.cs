public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        char[] sChar = s.ToCharArray();
        char[] tChar = t.ToCharArray();

        int[] freq = new int[26];

        for(int i=0; i< s.Length; i++){
            freq[sChar[i] - 'a']++;
            freq[tChar[i] - 'a']--;
        }
        for(int j=0; j< 26; j++){
            if(freq[j] != 0) return false;
        }
        return true;
    }
}