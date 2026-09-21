using System;

class Program
{
    static void Main()
    {

        int numero1 = 15;
        int numero2 = 30;
        int numero3 = 22;

        int suma = numero1 + numero2 + numero3;

        Console.WriteLine("La suma es: " + suma);

        Console.Write("Escribe tu nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Escribe una ciudad: ");
        string ciudad = Console.ReadLine();

        Console.WriteLine("Hola " + nombre + ", bienvenido a " + ciudad);

        Console.Write("Escribe tu nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Escribe tu edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Te llamas " + nombre + " y tienes " + edad + " años");
        
    }
}