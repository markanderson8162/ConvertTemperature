using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
	public static class TempConverter
	{
		public static double FahrenheitToCelsius(double temp)
		{
			double celsius = (temp - 32) * 0.555;
			return celsius;
		}

		public static double CelsiusToFahrenheit(double temp)
		{
			double fahrenheit = (temp * 1.8) + 32;
			return fahrenheit;
		}


	}
}
