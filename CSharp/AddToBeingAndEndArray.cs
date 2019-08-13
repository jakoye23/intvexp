using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main(string[] args)
    {
    	//Your code goes here
        Console.WriteLine("Hello, world!");
            
        string[] myArray = new string[] {"a", "b", "c", "d", "e"};
        Console.WriteLine("Array values before operation:");
        myArray.ToList().ForEach(Console.WriteLine);
            
        myArray = AddToBeginningOfArray(myArray, "aa");
        Console.WriteLine("Array values after AddToBegginingOfArray operation:");
        myArray.ToList().ForEach(Console.WriteLine);
            
        myArray = AddToEndOfArray(myArray, "zz");
        Console.WriteLine("Array values after AddToEndOfArray operation:");
        myArray.ToList().ForEach(Console.WriteLine);
    }
        
    public static string[] AddToBeginningOfArray(string[] targetArray, string stringToAdd)
    {
        List<string> arrayList = targetArray.ToList();
        arrayList.Insert(0, stringToAdd);
        return arrayList.ToArray();
    }
        
    public static string[] AddToEndOfArray(string[] targetArray, string stringToAdd)
    {
        List<string> arrayList = targetArray.ToList();
        arrayList.Add(stringToAdd);
        return arrayList.ToArray();
    }
}
