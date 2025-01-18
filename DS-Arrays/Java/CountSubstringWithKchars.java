public class CountSubstringWithKchars {
    //returns total number of substrings of S having exactly k distinct characters
    long substrCount (String S, int K) {
        // your code here
        int n = S.length();
        long count = 0;
        
        for(int i=0; i<n; i++ ){
            //get the freq check
            int[] freq = new int[26];
            int j=i;
            int limit =0;
            
            while(limit<=K && j<n){
                int jCurr = S.charAt(j);
                if(freq[jCurr%26] == 0){
                    limit++;
                }
                freq[jCurr%26]++;
                //append the substring in array 
                if(limit == K){
                   count++;
                }
                j++;
            }
        }
        return count;
    }
}
