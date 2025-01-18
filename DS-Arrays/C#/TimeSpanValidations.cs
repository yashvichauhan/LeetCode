// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Text;

public class Request
{
    public string EntryType {get; set;}
    public DateTime Time {get; set;}
    
    public DateTimeOffset Offset {get; set;}
}

public class RequestValidator{
    private static readonly TimeSpan StartTime = new TimeSpan(9, 0, 0);
    private static readonly TimeSpan EndTime = new TimeSpan(17, 30, 0);
    
    private static readonly string [] InputStr = new string[] {
        "IN",
        "Out",
        "Test",
        "Backward"
    };
    
    public static bool Validate(Request rq){
        var requestTime =  rq.Time.TimeOfDay;
        if(requestTime < StartTime || requestTime >EndTime){
            return false;
        }
        
        if(Array.IndexOf(InputStr, rq.EntryType)==-1){
            return false;
        }
        
        return true;
    }
    
    public static void Main(string[] args)
    {
        //string str = "yashvic";
        //StringBuilder stb = new StringBuilder("");
        
        //for(int i=str.Length-1; i>=0; i--){
            //stb.Append(str[i]);
        //}
        //Console.WriteLine(stb);
        
        //validations
        Request r1 = new Request{
            EntryType = "Test12",
            Time =  new DateTime(2024, 10, 11, 10, 0, 0),
            Offset = DateTimeOffset.Now
        };
        
        Console.WriteLine(r1.Offset);
        Console.WriteLine(Validate(r1));
    }
}    