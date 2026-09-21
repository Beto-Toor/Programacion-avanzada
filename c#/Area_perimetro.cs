using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("-----Figuras geometricas-----");
        Console.WriteLine("1. Cuadrado");
        Console.WriteLine("2. Círculo");
        Console.WriteLine("3. Rombo");
        Console.WriteLine("4. Trapecio");
        Console.WriteLine("5. Triángulo");

        Console.Write("\nSelecciona una figura: ");
        int figura = int.Parse(Console.ReadLine());

        Console.WriteLine("\n¿Qué deseas calcular?");
        Console.WriteLine("1. Área");
        Console.WriteLine("2. Perímetro");
        Console.WriteLine("3. Área y perímetro");

        Console.Write("Selecciona una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        double area = 0;
        double perimetro = 0;

        switch (figura)
        {
            case 1:
                Console.Write("\nIngresa el lado: ");
                double lado = double.Parse(Console.ReadLine());

                area = lado * lado;
                perimetro = 4 * lado;
                break;

            case 2:
                Console.Write("\nIngresa el radio: ");
                double radio = double.Parse(Console.ReadLine());

                area = Math.PI * radio * radio;
                perimetro = 2 * Math.PI * radio;
                break;

            case 3:
                Console.Write("\nIngresa la diagonal mayor: ");
                double diagonalMayor = double.Parse(Console.ReadLine());

                Console.Write("Ingresa la diagonal menor: ");
                double diagonalMenor = double.Parse(Console.ReadLine());

                Console.Write("Ingresa el lado: ");
                double ladoRombo = double.Parse(Console.ReadLine());

                area = (diagonalMayor * diagonalMenor) / 2;
                perimetro = 4 * ladoRombo;
                break;

            case 4:
                Console.Write("\nIngresa la base mayor: ");
                double baseMayor = double.Parse(Console.ReadLine());

                Console.Write("Ingresa la base menor: ");
                double baseMenor = double.Parse(Console.ReadLine());

                Console.Write("Ingresa la altura: ");
                double altura = double.Parse(Console.ReadLine());

                Console.Write("Ingresa el lado izquierdo: ");
                double ladoIzquierdo = double.Parse(Console.ReadLine());

                Console.Write("Ingresa el lado derecho: ");
                double ladoDerecho = double.Parse(Console.ReadLine());

                area = ((baseMayor + baseMenor) * altura) / 2;
                perimetro = baseMayor + baseMenor +
                            ladoIzquierdo + ladoDerecho;
                break;

            case 5:
                Console.Write("\nIngresa el lado 1: ");
                double lado1 = double.Parse(Console.ReadLine());

                Console.Write("Ingresa el lado 2: ");
                double lado2 = double.Parse(Console.ReadLine());

                Console.Write("Ingresa el lado 3: ");
                double lado3 = double.Parse(Console.ReadLine());

                Console.Write("Ingresa la altura: ");
                double alturaTriangulo = double.Parse(Console.ReadLine());

                area = (lado1 * alturaTriangulo) / 2;
                perimetro = lado1 + lado2 + lado3;
                break;

            default:
                Console.WriteLine("Figura no válida.");
                return;
        }

        Console.WriteLine("\n-----Resultado-----");

        if (opcion == 1)
        {
            Console.WriteLine("Área: " + area.ToString("F2"));
        }
        else if (opcion == 2)
        {
            Console.WriteLine("Perímetro: " + perimetro.ToString("F2"));
        }
        else if (opcion == 3)
        {
            Console.WriteLine("Área: " + area.ToString("F2"));
            Console.WriteLine("Perímetro: " + perimetro.ToString("F2"));
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }
}