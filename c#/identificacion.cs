using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("-----Datos del alumno-----\n");

        Console.Write("Nombre completo: ");
        string nombre = Console.ReadLine();

        Console.Write("Matrícula: ");
        string matricula = Console.ReadLine();

        Console.Write("Plantel: ");
        string plantel = Console.ReadLine();

        Console.Write("Semestre: ");
        string semestre = Console.ReadLine();

        double[] calificaciones = new double[5];

        double suma = 0;

        Console.WriteLine("\n-----Calificaciones-----");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingresa la calificación " + (i + 1) + ": ");
            calificaciones[i] = double.Parse(Console.ReadLine());

            suma = suma + calificaciones[i];
        }

        double promedio = suma / 5;

        Console.WriteLine("\n-----Informacion del alumno-----");

        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Matrícula: " + matricula);
        Console.WriteLine("Plantel: " + plantel);
        Console.WriteLine("Semestre: " + semestre);

        Console.WriteLine("\n-----Calificaciones-----");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(
                "Calificación " + (i + 1) + ": " +
                calificaciones[i].ToString("F2")
            );
        }

        Console.WriteLine("\nPromedio: " + promedio.ToString("F2"));
    }
}