using System;

namespace DefaultNamespace
{
	public class Class1
	{
		void main(){
			Console.WriteLine ("Please input your name: ");//First ask for user input
			string input = Console.ReadLine();//Reads input from user then puts it in a string

			Console.WriteLine("Hello " + input);//Outputs user input
			Console.WriteLine("Please input a number: ");//Ask user to input number
			int number = Convert.ToInt32(Console.ReadLine);//Reads input from user then puts it into an Int, but needs explicit conversion first.
			Console.WriteLine("You have entered: " + number)//Output second user input.

			//Unlike C++, you can just assign Console.ReadLine() as if it was a variable.
			//But Console.ReadLine() returns as a String, so it needs conversion before being put into other types.
		}
	}
}
	
