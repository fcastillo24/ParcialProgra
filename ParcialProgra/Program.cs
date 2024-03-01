while (true)
{
    Console.WriteLine("Por Favor Seleccione que Conversion Desea Realizar:\n");
    Console.WriteLine("1. Numero entero Positivo");
    Console.WriteLine("2. Dos numero Enteros");
    Console.WriteLine("3. Imprimer tabla de multiplicar");
    Console.WriteLine("4. Adivinar numero");
    Console.WriteLine("5. Salir\n");

    int opcion = int.Parse(Console.ReadLine());
    Console.WriteLine("\n");

    switch (opcion)
    {
        case 1: 
            Ejercicio1();
            break;
        case 2: 
            Ejercicio2();
            break;
        case 3:
            Ejercicio3();
            break;
        case 4: 
            Ejercicio4();
            break;
        case 5:
            return;
        default: 
            Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 5.");
            break;
    }
}

static void Ejercicio1()

    {
        int numero;

        do
        {
            Console.WriteLine("Ingrese un número entero positivo (o ingrese 0 para salir):");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out numero) || numero < 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo válido.");
                continue;
            }

            if (numero == 0)
            {
                Console.WriteLine("Saliendo del programa...");
                break;
            }

            MostrarMenu(numero);

        } while (true);
    }

    static void MostrarMenu(int numero)
    {
        Console.WriteLine("\nMenú:");
        Console.WriteLine("1. Calcular el factorial del número.");
        Console.WriteLine("2. Calcular la raíz cuadrada del número.");
        Console.WriteLine("3. Salir del programa.");
        Console.WriteLine("Ingrese el número de la opción deseada:");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                CalcularFactorial(numero);
                break;
            case "2":
                CalcularRaizCuadrada(numero);
                break;
            case "3":
                Console.WriteLine("Saliendo del programa...");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, ingrese 1, 2 o 3.");
                break;
        }
    }

    static void CalcularFactorial(int numero)
    {
        long factorial = 1;
        for (int i = 2; i <= numero; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }

    static void CalcularRaizCuadrada(int numero)
    {
        double raizCuadrada = Math.Sqrt(numero);
        Console.WriteLine($"La raíz cuadrada de {numero} es: {raizCuadrada}");
    }


static void Ejercicio2()
{
    static int SolicitarEntero(string mensaje)
    {
        int entero;
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out entero))
            {
                return entero;
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número entero válido.");
            }
        }
    }

    static char SolicitarOperador()
    {
        char[] operadoresValidos = { '+', '-', '*', '/' };
        while (true)
        {
            Console.Write("Introduce un operador matemático (+, -, *, /): ");
            char operador = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (Array.IndexOf(operadoresValidos, operador) != -1)
            {
                return operador;
            }
            else
            {
                Console.WriteLine("Operador inválido. Por favor, introduce un operador válido.");
            }
        }
    }

    static double RealizarOperacion(int num1, int num2, char operador)
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
                {
                    return (double)num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir por cero.");
                    return double.NaN;
                }
            default:
                return double.NaN;
        }
    }

    {
        Console.WriteLine("Calculadora Simple");
        int num1 = SolicitarEntero("Introduce el primer número entero: ");
        int num2 = SolicitarEntero("Introduce el segundo número entero: ");
        char operador = SolicitarOperador();
        double resultado = RealizarOperacion(num1, num2, operador);
        if (!double.IsNaN(resultado))
        {
            Console.WriteLine($"El resultado de {num1} {operador} {num2} es: {resultado}");
        }
    }
}

static void Ejercicio3()
{
    {
        Console.WriteLine("Ingrese un número para imprimir su tabla de multiplicar del 1 al 10:");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine($"Tabla de multiplicar del {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }
    }
}

static void Ejercicio4()
{
    {
        Random rand = new Random();
        int numeroSecreto = rand.Next(1, 101);
        int intentos = 0;
        int intentoUsuario;

        Console.WriteLine("¡Bienvenido al juego de adivinar el número secreto!");
        Console.WriteLine("Se ha generado un número secreto entre 1 y 100. ¡Inténtalo!");

        do
        {
            Console.Write("Introduce tu intento: ");
            if (int.TryParse(Console.ReadLine(), out intentoUsuario))
            {
                intentos++;

                if (intentoUsuario < numeroSecreto)
                {
                    Console.WriteLine("El número secreto es mayor.");
                }
                else if (intentoUsuario > numeroSecreto)
                {
                    Console.WriteLine("El número secreto es menor.");
                }
                else
                {
                    Console.WriteLine($"¡Felicidades! Has adivinado el número secreto {numeroSecreto} en {intentos} intentos.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }

        } while (intentoUsuario != numeroSecreto);

        Console.WriteLine("¡Gracias por jugar!");
    }
}
