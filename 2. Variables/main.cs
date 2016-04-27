using System;

namespace DefaultNamespace
{
	public class Class1
	{
		public static void main(){
			string s = "This is a C++ string."; //This is a C# string.
			int i = 25; //This is a C# integer.
			float f = 22.5; //This is a C# float.
			char c = 'A'; //This is a C# character.
			var a = "aks" //This type automatically determines the variable type
	
			Console.WriteLine((i + 25).ToString()); //Returns an integer.
			Console.WriteLine((i + f).ToString()); //Returns a float.
	
			//All variables must have a declared type.
			//Floats are actually decimals.
			//Strings are made of chars, so they are fully compatible with each other.
			//Chars are single characters.
			//Console.WriteLine can only output strings, so any other types must be converted.
			
		}
	}
}
