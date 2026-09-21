using System.Reflection.Emit;

Console.WriteLine("-----Calculadora basica-----");
Console.WriteLine("Ingresa un numero");

int num_1;
int num_2;

num_1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresa un numero 2");
num_2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-----Menu de operaciones-----");
Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Multiplicacion");
Console.WriteLine("4. Division");
Console.WriteLine("5. Residuo");
Console.WriteLine("6. Binomio cuadrado perfecto");

int opc;

opc=Convert.ToInt32(Console.ReadLine());
switch(opc)
{
    case 1:
    Console.WriteLine($"El resultado de la suma es:,{num_1+num_2}");
    break;

    case 2:
    Console.WriteLine($"El resultado de la resta es:,{num_1-num_2}");
    break;

    case 3:
    Console.WriteLine($"El resultado de la multiplicacion es:,{num_1*num_2}");
    break;

    case 4:
    Console.WriteLine($"El resultado de la division es:,{num_1 / num_2}");
    break;

    case 5:
    Console.WriteLine($"El resultado de la modulo es:,{num_1 % num_2}");
    break;

    case 6:
    int resultado=((num_1*num_1)+ (2*num_1*num_2)+(num_2*num_2))^2;
    Console.WriteLine($"El resultado de la division es:,resultado");
    break;

    default:
    Console.WriteLine("Opcion no valida");
    break;

}