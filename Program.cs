using System;
 
namespace UserInput
{
	class MyClass
	{
		public static void Main(string[] args)
		{
			string userInput;
            string userInput2;
			int width;
            int height;

			Console.WriteLine("Enter Width in Inches: ");
			userInput = Console.ReadLine();
            Console.WriteLine("Enter Height in Inches: ");
            userInput2 = Console.ReadLine();
			
            // Converts to integer type
            width = Convert.ToInt32(userInput);
            height = Convert.ToInt32(userInput2);
			
            int area = width * height;
            Console.WriteLine("The area of your rectangle is " + area + "in²");
		}
	}
}