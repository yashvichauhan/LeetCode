public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);

        int j=0;
        int i=0;
        int count=0;

        while(i< g.Length && j<s.Length){
            if(g[i] <= s[j]){
                count++;
                i++;
            }
            j++;
        }

        return count;
    }
}