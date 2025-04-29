using System.Linq.Expressions;
using Calculator_Project;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cargando el programa...");
        CalculatorApp.AnimateLoading();
        Console.WriteLine("\nCargado con éxito.");
        MostrarMenu();
        
    }

    static double Division(double a, double b)
    {
        Calculator calculator = new Calculator();
        try
        {
            double resultado = calculator.Divide(a, b);
            Console.WriteLine($"El resultado de la división es: {resultado}");
            return resultado; // Aseguramos que se devuelve un valor en todas las rutas de acceso.
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error al realizar la operación: {ex.Message}");
            return 0; // Devolvemos un valor predeterminado en caso de error.
        }
    }

    static double Multiplication(double a, double b)
    {
        Calculator calculator = new Calculator();
        try
        {
            double resultado = calculator.Multiply(a, b);
            Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
            return resultado; // Aseguramos que se devuelve un valor en todas las rutas de acceso.
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error al realizar la operación: {ex.Message}");
            return 0; // Devolvemos un valor predeterminado en caso de error.
        }
    }

    static double Substraction(double a, double b)
    {
        Calculator calculator = new Calculator();

        try
        {
            double resultado = calculator.Substract(a, b);
            Console.WriteLine($"El resultado de la resta es {resultado}");
            return resultado; // Aseguramos que se devuelve un valor en todas las rutas de acceso.
        }
        catch (Exception ex)
        { 
            Console.WriteLine($"Ocurrió un error al realizar la operación: {ex.Message}");
            return 0; // Devolvemos un valor predeterminado en caso de error.
        }
    }

    static double Addition(double a, double b)
    {
        Calculator calculator = new Calculator();
        try
        {
            double resultado = calculator.Add(a, b);
            Console.WriteLine($"El resultado de la suma es: {resultado}");
            return resultado; // Aseguramos que se devuelve un valor en todas las rutas de acceso.
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error al realizar la operación: {ex.Message}");
            return 0; // Devolvemos un valor predeterminado en caso de error.
        }
    }

    static double SolicitarNumero(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string? entrada = Console.ReadLine();

            if (double.TryParse(entrada, out double numero))
            {
                return numero;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("Bienvenido al proyecto de calculadora.");

        double num1 = SolicitarNumero("Ingrese el primer número: ");
        double num2 = SolicitarNumero("Ingrese el segundo número: ");

        Console.WriteLine("Seleccione una operación:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Salir");

        var opcion = string.Empty;

        while (true) // Bucle infinito hasta que se ingrese una opción válida
        {
            Console.Clear();
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Addition(num1, num2);
                    return; // Salir del método después de una operación válida
                case "2":
                    Substraction(num1, num2);
                    return;
                case "3":
                    Multiplication(num1, num2);
                    return;
                case "4":
                    Division(num1, num2);
                    return;
                case "5":
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break; // Repite el bucle si la opción no es válida
            }
        }
    }
}