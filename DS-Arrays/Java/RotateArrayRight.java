public class RotateArrayRight {
    public static void reverse(int[] arr, int start, int end){
        while(end>=start){
            int tmp = arr[start];
            arr[start] = arr[end];
            arr[end] = tmp;
            start++;
            end--;
        }
    }

    public void rotate(int[] nums, int k) {
        //in-place rotation
        int n = nums.length;
        k = k%n;
        //reverse k+1 to n-1 position
        reverse(nums, n-k, n-1);
        //reverse 0 to k positions
        reverse(nums, 0, n-k-1);
        //reverse the whole array  
        reverse(nums, 0, n-1);
    }
}
