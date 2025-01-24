class Solution {
    // Function to count the frequency of all elements from 1 to N in the array.
    public List<int> frequencyCount(int[] arr) {
        // code here
        int[] result = new int[arr.Length];
        for (int i = 0; i< arr.Length; i++){
            result[arr[i] - 1] += 1;
        }
        
        return result.ToList();
    }
}