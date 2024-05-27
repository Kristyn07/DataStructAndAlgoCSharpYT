using System;
using System.Collections;
public class Program
{
	static void Main(string[] args)
	{
		int[] anArray = new int[8];
		int length = 0;
		//Create An Array pushing at the end of the array

		for (int i = 0; i <= 5; i++) {
			anArray[length] = i;
			length++;
		}

		//Create pushing at the end of the array
		for (int i = 5; i>= 0; i--)
		{
			//moving the values
			/*anArray[length] = i;
			length--;*/
			anArray[i + 1] = anArray[i];
		}
		anArray[0] = 6;

		//create pushing at specific index of the array
		for (int i = 3; i >= 1; i--)
		{
			anArray[i + 1] = anArray[i];
		}
		anArray[1] = 10;
	}
}

public class LearnArray
{
	
}