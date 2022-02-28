using System;
class Program
{
    public static void Main(string[] args)
    {
        int sum=Add(5,4);
        Console.WriteLine(sum);
        Console.WriteLine(IsOdd(4));
        
    }
    public static int Add(int x,int y)
    {
        return x+y;
    }
    public static bool IsOdd(int value)
    {
        return value%2==1;

    }
    
    
}

