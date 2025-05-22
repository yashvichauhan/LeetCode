// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Text;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string str = "my test run";
        StringBuilder output = new StringBuilder();  
        List<char> charlist = new List<char>();  
  
        for (int i = 0; i < str.Length; i++)  
        {  
            if (str[i] == ' ' || i == str.Length - 1)  
            {  
                if (i == str.Length - 1)  
                    charlist.Add(str[i]);  
                for (int j = charlist.Count - 1; j >= 0; j--)  
                    output.Append(charlist[j]);  
  
                output.Append(' ');  
                charlist = new List<char>();  
            }  
            else  
                charlist.Add(str[i]);  
        }  
        Console.WriteLine(output.ToString());  
    }
}