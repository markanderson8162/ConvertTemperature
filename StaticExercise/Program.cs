using System;

namespace StaticExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Convert F to C");
			var celsius = double.Parse(Console.ReadLine());
			Console.WriteLine($"{TempConverter.FahrenheitToCelsius(celsius)}");

			Console.WriteLine("");

			Console.WriteLine("Convert C to F");
			var fahrenheit = double.Parse(Console.ReadLine());
			Console.WriteLine($"{TempConverter.CelsiusToFahrenheit(fahrenheit)}");
		}
	}
}
