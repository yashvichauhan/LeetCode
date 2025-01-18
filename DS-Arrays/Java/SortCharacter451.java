import java.util.*;

public class SortCharacter451 {
    public String frequencySort(String s) {
        HashMap<Character, Integer> freqMap= new HashMap<>();
        StringBuilder sb = new StringBuilder();

        //get the frequency in hashmap
        for(int i=0; i<s.length(); i++){
            //count the freq
            Character curr = s.charAt(i);
            freqMap.put(curr, freqMap.getOrDefault(curr, 0)+1);
        }
        //freqMap: {t:1, r:1, e:2 }
        //get the arraylist and sort it
        ArrayList<Character> keyList = new ArrayList<Character>(freqMap.keySet());
        keyList.sort((a,b) ->  freqMap.get(b) - freqMap.get(a));
        for(Character c: keyList){
            for(int j=0; j<freqMap.get(c); j++){
                sb.append(c);
            }
        }
        return sb.toString();
    }
}
