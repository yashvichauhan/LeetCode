// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    //swap function
    public static void swap(int[] arr, int i, int j){
        int tmp = arr[i];
        arr[i]= arr[j];
        arr[j] = tmp;
    }
    
    //partition function
    public static int partitionFn(int[] arr, int low, int high){
        int pivot = low;
        int i = low;
        int j = high;
        
        while(i<j){
            while(arr[i]<=arr[pivot] && i<high){
                i++;
            }
            while(arr[j] > arr[pivot] && j>low){
                j--;
            }
            if(i<j){
                swap(arr, i, j);
            }
        }
        swap(arr, pivot, j);
        Console.WriteLine("[{0}]", string.Join(", ", arr));
        return j;
    }
    
    //recursive function
    public static void quickSort(int[] arr, int low, int high){
        if(low<high){
            int partitionIndex = partitionFn(arr, low, high);
            Console.WriteLine($"Partition Indx: {partitionIndex}");
            quickSort(arr, low, partitionIndex-1);
            quickSort(arr, partitionIndex+1, high);
        }
    }
    
    public static void Main(string[] args)
    {
        int[] myArr = new int[6] {4,6,2,5,7,1};
        quickSort(myArr, 0, myArr.Length-1);
        //print
        Console.WriteLine("[{0}]", string.Join(", ", myArr));
    }
}