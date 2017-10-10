using System;

namespace VeryHard
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Please give a number.");
			int userInput = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Choose what you want to convert " + userInput + " into");
			Console.WriteLine("Press I->convert from inches to centimeters.");
			Console.WriteLine("Press G->convert from gallons to liters.");
			Console.WriteLine("Press M->convert from miles to kilometers.");
			Console.WriteLine("Press P->convert from pounds to kilograms.");

			var conversion = Console.ReadLine();

			switch (conversion)
			{

				case "I":

					int centimeters = (int)(userInput * 2.54);
					Console.WriteLine(centimeters + " cm");
					break;

				case "G":

					int liters = (int)(userInput * 3.78541);
					Console.WriteLine(liters + " L");
					break;

				case "M":

					int kilometers = (int)(userInput * 1.60934);
					Console.WriteLine(kilometers + " km");
					break;

				case "P":

					int kilograms = (int)(userInput * 0.453592);
					Console.WriteLine(kilograms + " kg");
					break;

				default:
					break;
			}
		}
	}
}
