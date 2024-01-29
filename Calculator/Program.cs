using System;

class Calculator
{
	static void Main()
	{
		double num1, num2, result;
		string operation;

		Console.WriteLine("Simple Calculator in C#");
		Console.WriteLine("------------------------");

		Console.Write("Enter the first number: ");
		if (!double.TryParse(Console.ReadLine(), out num1))
		{
			Console.WriteLine("Invalid input. Please enter a valid number.");
			return;
		}
		Console.Write("Enter the operation (+, -, *, /): ");

		operation = Console.ReadLine();
		Console.Write("Enter the second number: ");

		if (!double.TryParse(Console.ReadLine(), out num2))
		{
			Console.WriteLine("Invalid input. Please enter a valid number.");
			return;
		}
		switch (operation)
		{
			case "+":
				result = num1 + num2;
				break;
			case "-":
				result = num1 - num2;
				break;
			case "*":
				result = num1 * num2;
				break;
			case "/":
				if (num2 == 0)
				{
					Console.WriteLine("Division by zero is not allowed.");
					return;
				}
				result = num1 / num2;
				break;
			default:
				Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
				return;
		}
		Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
	}
}
