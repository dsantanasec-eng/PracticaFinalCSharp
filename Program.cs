// See https://aka.ms/new-console-template for more information
int opcion = -1;

Console.Clear();

while (opcion != 0)
{
    Console.WriteLine("MENU PRINCIPAL");
    Console.WriteLine("1. Numero Par o Impar");
    Console.WriteLine("2. Fibonacci");
    Console.WriteLine("3. Factorial");
    Console.WriteLine("4. Numero Primo");
    Console.WriteLine("5. Palindroma");
    Console.WriteLine("6. Mayor, menor y medio");
    Console.WriteLine("0. Salir");

    Console.Write("Seleccione una opcion: ");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Digite un numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es PAR");
            }
            else
            {
                Console.WriteLine("El numero es IMPAR");
            }
            break;

        case 2:
            Console.Write("Digite la cantidad de numeros Fibonacci: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            Console.WriteLine("Secuencia Fibonacci:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                int siguiente = a + b;
                a = b;
                b = siguiente;
            }

            Console.WriteLine();
            break;

        case 3:
            Console.Write("Digite un numero: ");
            int num = int.Parse(Console.ReadLine());

            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("El factorial es: " + factorial);
            break;

        case 4:
            Console.Write("Digite un numero: ");
            int numeroprimo = int.Parse(Console.ReadLine());

            bool esPrimo = true;

            if (numeroprimo <= 1)
            {
                esPrimo = false;
            }
            else
            {
                for (int i = 2; i < numeroprimo; i++)
                {
                    if (numeroprimo % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }

            if (esPrimo)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }
            break;

        case 5:
        {
            Console.Write("Digite un numero: ");
            int numeroPal = int.Parse(Console.ReadLine());

            int original = numeroPal;
            int invertido = 0;

            while (numeroPal > 0)
            {
                int digito = numeroPal % 10;
                invertido = invertido * 10 + digito;
                numeroPal = numeroPal / 10;
            }

            if (original == invertido)
            {
                Console.WriteLine("El numero es palindromo");
            }
            else
            {
                Console.WriteLine("El numero no es palindromo");
            }

            break;
        }

        case 6:
        {
            Console.Write("Digite el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite el segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite el tercer numero: ");
            int num3 = int.Parse(Console.ReadLine());

            int mayor, menor, medio;

            mayor = Math.Max(num1, Math.Max(num2, num3));
            menor = Math.Min(num1, Math.Min(num2, num3));
            medio = num1 + num2 + num3 - mayor - menor;

            Console.WriteLine("Mayor: " + mayor);
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("Medio: " + medio);

            break;
        }

        case 0:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opcion no valida");
            break;
    }

  if (opcion != 0)
{
    Console.WriteLine();
    Console.WriteLine("Presione una tecla para continuar...");
    Console.ReadKey();
}
}