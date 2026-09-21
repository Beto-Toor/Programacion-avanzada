using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("-----Operaciones-----");

        Console.Write("Ingresa el primer número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nResultados:");
        Console.WriteLine("Suma: " + (num1 + num2));
        Console.WriteLine("Resta: " + (num1 - num2));
        Console.WriteLine("Multiplicación: " + (num1 * num2));
        Console.WriteLine("División: " + (num1 / num2));
        
    }
}