// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Text;

public class Programming
{
    public static bool IsPalindrome(string str){
        int n = str.Length; 
        
        for(int i=0; i<(n/2); i++){
            if(str[i]!=str[n-i-1]){
                return false;
            }
        }
        return true;
    }
    
    public static string reverseStringOrder(string str){
        StringBuilder sb = new StringBuilder("");
        int n = str.Length;
        int i=n-1;
        while(i> 0){
            int j=i;
            while(j>0 && str[j]!=' '){
                j--;
            }
            int tmp = j;
            while(tmp<n && tmp<=i){
                sb.Append(str[tmp]);
                tmp++;
            }
            
            sb.Append(" ");
            
            i=j-1;
        }
        return sb.ToString();
    }
    
    public static string reverse(string str, int start, int end){
        StringBuilder revStr = new StringBuilder();
        for(int i=end; i>=start ; i--){
            revStr.Append(str[i]);
        }
        return revStr.ToString();
    }
    
    public static string reverseWords(string str){
        int n = str.Length;
        int i= 0;
        StringBuilder sb = new StringBuilder();
        
        while(i<n){
            int j = i;
            //move j pointer till " " is found
            while(j<n && str[j]!=' '){
                j++;
            }
            
            string subEnd = reverse(str, i, j-1);
            sb.Append(subEnd);
            sb.Append(" ");
            i=j+1;
        }
        return sb.ToString();
    }
    
    public static void Main(string[] args)
    {
        Helper h1 = new Helper {
            //testStr = "yashvi"
            testStr = "This is"
        };
        //Console.WriteLine(IsPalindrome(h1.testStr));
        //Console.WriteLine(reverseStringOrder(h1.testStr));
        Console.WriteLine(reverseWords(h1.testStr));
    }
}
public class Helper{
    public string testStr {get; set;}
    
}