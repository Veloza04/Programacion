Console.WriteLine("Vamos a sumar 2 numeros enteros");

int num1, num2;
bool numeroValido1, numeroValido2;
do
{
    Console.Write("Ingrese el primer número: ");
    numeroValido1 = int.TryParse(Console.ReadLine(), out num1);
    if (!numeroValido1)
    {
        Console.WriteLine("Entrada no válida, por favor inténtelo de nuevo.");
    }
} while (!numeroValido1);
do
{
    Console.Write("Ingrese el segundo número: ");
    numeroValido2 = int.TryParse(Console.ReadLine(), out num2);
    if (!numeroValido2)
    {
        Console.WriteLine("Entrada no válida, por favor inténtelo de nuevo.");
    }
} while (!numeroValido2);
int resultado = num1 + num2;
Console.WriteLine($"La suma de {num1} y {num2} es: " + resultado);
Console.ReadKey();