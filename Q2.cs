using System;
public class Exercise1
{
    public static void Main( )
    {
        int n1;
        Console.WriteLine("Input any Number :");
        n1=int.Parse(Console.ReadLine());
        Console.WriteLine("Table of {0} is:", n1);
        for(int i=1; i<=10;i++){
            Console.WriteLine( "{0} * {1} = {2}" , n1, i, n1*i);
        }
    }
}
