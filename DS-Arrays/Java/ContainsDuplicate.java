import java.util.HashSet;

public class ContainsDuplicate {
    //solution for a linear complexity O(n)
    public boolean containsDuplicate(int[] nums) {
        HashSet<Integer> hs = new HashSet<>();
        for(int num: nums){
            hs.add(num);
        }
        return !(hs.size() == nums.length);
    }

    //better solution
    
}
