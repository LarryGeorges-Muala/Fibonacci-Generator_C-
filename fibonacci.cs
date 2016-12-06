//App Name: Fibonacci Generator - C#
//Developper: Larry Georges Muala
using System;

public class Fibonacci{
	
	public static void Main(){
		
		Console.WriteLine("Fibonacci Generator \n");
		Console.Write("\nPlease Enter the size of your Fibonacci sequence: ");
		
		int size = int.Parse(Console.ReadLine());

		int [] fibonacciArray = new int[size];
		
		//case statement for index 0, 1, 2
		if (size > 0){
			
			switch (size){
				case 1:
				//Fibonacci size of 1 number
					Console.WriteLine("0");
					break;
			
				case 2:
				//Fibonacci size of 2 numbers
					Console.WriteLine("0");
					Console.WriteLine("1");
					break;
			
				default:
				//Fibonacci for size over 3 numbers
					fibonacciArray[0] = 0;
					fibonacciArray[1] = 1;
					fibonacciArray[2] = 1;
					
					for (int i = 3; i < fibonacciArray.Length; i++){
						fibonacciArray[i] = fibonacciArray[i - 2] + fibonacciArray[i - 1];
					}

					foreach (var item in fibonacciArray){
						Console.WriteLine(item.ToString());
					}
					break;
			}
		}
		else{
			Console.WriteLine("\nError - Invalid value entered. \nPlease enter a positive not null number.");
		}
	}
}

//Fibonacci.Main();