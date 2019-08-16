using System;
					
/*
Leet stats:
Runtime: 40 ms, faster than 87.11% of C# online submissions for Reverse Integer.
Memory Usage: 13 MB, less than 62.50% of C# online submissions for Reverse Integer. */
public class Program
{
	public static void Main()
	{
		int[] arrayOfInts = new int[3] {-123, 320, 321};
		foreach(int number in arrayOfInts)
		{
			Console.WriteLine("Int going in: number = " + number.ToString());
			Console.WriteLine("Int coming out: number = " + ReverseInt(number).ToString());
			Console.WriteLine();
		}
	}
	
	public static int ReverseInt(int x)
	{
		var xString = x.ToString();
		var xChars = xString.ToCharArray(0, xString.Length);
		var yCharsLength = xChars.Length;
		var isNegativeInput = false;
		
		if (xChars[0] == '-')
		{
			yCharsLength--;
			isNegativeInput = true;
		}
		
		char[] yChars = new char[xChars.Length];
		int yCharTrack = 0;
        int stopIndex = isNegativeInput ? 1 : 0;
		
		for(int i = xChars.Length - 1; i >= stopIndex; i--)
        {
        	yChars[yCharTrack] = xChars[i];
			yCharTrack++;
        }
			
		var reversedString = new String(yChars);
		var returnValue = 0;
		// Overflow will produce 0
		Int32.TryParse(reversedString, out returnValue);
		if (isNegativeInput)
		{
			returnValue = returnValue * -1;
		}
		
		return returnValue;
	}
}
