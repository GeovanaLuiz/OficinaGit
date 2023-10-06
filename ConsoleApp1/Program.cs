using System;
class program
{
    static void Main()
    {

        Console.Write("\nDigite um número: ");
        double num = Convert.ToInt32 (Console.ReadLine());
        Console.Write("\nDigite outro número: ");
        double num2 = Convert.ToInt32(Console.ReadLine());

        double resultado = num + num2;

        if (resultado == 0){ Console.WriteLine("Numero Inválido"); }
        if (resultado == 1) { Console.WriteLine("Numero Inválido"); }
        if (resultado == 2) { Console.WriteLine("Numero Inválido"); }

        Console.WriteLine($"O resultado da multiplicação é {resultado}");

        Console.ReadKey();
    }
}
