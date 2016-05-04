using System;

namespace DefaultNamespace
{
	public class Class1
	{
		void main(){
			string text1 = "Hello ";//This is the first string, note the space in the back
			string text2 = "Fred";//This is the second string.
			Console.WriteLine(text1); //Output text1
			Console.WriteLine(text1);  //Output text2
			Console.WriteLine(text1 + text2);//Outputs both of them

			string text3 = text1 + text2;//They can be combined
			Console.WriteLine(text3);//This have the same effect as the third output
		}
	}
}

