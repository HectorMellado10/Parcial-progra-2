using System;

class Program
{
    static void Main()
    {
        int num1, num2;
        char operador;

        Console.WriteLine("--- Calculadora Simple ---");

        Console.Write("Ingrese el primer número entero: ");
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("Ingrese un número entero válido: ");
        }

        Console.Write("Ingrese el segundo número entero: ");
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.Write("Ingrese un número entero válido: ");
        }

        Console.Write("Ingrese un operador matemático (+, -, *, /): ");
        while (!char.TryParse(Console.ReadLine(), out operador) || !EsOperadorValido(operador))
        {
            Console.Write("Ingrese un operador válido: ");
        }

        Console.WriteLine($"El resultado de la operación es: {RealizarOperacion(num1, num2, operador)}");

        Console.WriteLine("\nFin del programa.");
    }

    static bool EsOperadorValido(char operador)
    {
        return operador == '+' || operador == '-' || operador == '*' || operador == '/';
    }

    static int RealizarOperacion(int num1, int num2, char operador)
    {
        switch (operador)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                if (num2 != 0)
                    return num1 / num2;
                else
                    Console.WriteLine("Error: No se puede dividir por cero.");
                break;
        }
        return 0;
    }
}
