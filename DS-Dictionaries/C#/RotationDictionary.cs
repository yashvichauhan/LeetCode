// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
//delegate test
public delegate void MyPrintDel(string message);

public class ProgramTest
{
    public static void ActualMethod(string msg){
        Console.WriteLine($"test: {msg}");
    }
    
    public static void countFreq(string str){
        Dictionary <char, int> map = new Dictionary<char, int>();
        for(int i=0; i<str.Length; i++){
            if(!map.ContainsKey(str[i])){
                map.Add(str[i], 1);
            }else{
                map[str[i]] += 1;
            }
        }
        
        foreach(KeyValuePair<char, int> p in map){
            Console.WriteLine($"Key: {p.Key} Value: {p.Value}");
        }
    }
    
    public static int [] reverseArr(int[] arr, int start, int end){
        //revrese by replace
        int n = arr.Length;
        while(end>=start){
            int tmp = arr[start];
            arr[start]= arr[end];
            arr[end] = tmp;
            start++;
            end--;
        }
        return arr;
    }
    
    public static int[] LeftRotation(int[] arr, int k){
        //rotate left by k positions
        int n = arr.Length;
        k = k%n;
        //reverse 0 to k-1
        reverseArr(arr, 0, k-1);
        Console.WriteLine("[{0}]", string.Join(", ", arr));
        //reverse k to n-1
        reverseArr(arr, k, n-1);
        Console.WriteLine("[{0}]", string.Join(", ", arr));
        //reverse all
        reverseArr(arr, 0, n-1);
        Console.WriteLine("[{0}]", string.Join(", ", arr));
        return arr;
    }
    
    public static void Main(string[] args)
    {
        Helper h1 = new Helper {
            testStr = "Yashvich",
            testArr = new int[4] {1,2,3,4}
        };
        //MyPrintDel MyMethodCall = new MyPrintDel(ActualMethod);
        //MyMethodCall("Yashvi Chauhan!");
        //countFreq(h1.testStr);
        int start= 0;
        int end = 1;
        int midPoint = ((end-start)/2)+start;
        Console.WriteLine(midPoint);
        
        int[] res = LeftRotation(h1.testArr, 4);
        
    }
}

public class Helper{
    public string testStr {get; set;}
    public int[] testArr {get; set;}
}