Console.WriteLine("Vamos a hacer operaciones entre 2 numeros enteros");

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

bool opcionValida;
int eleccion;
double resultado;
Console.WriteLine("A continuacion elija la operacion que desea realizar:");

do
{
    Console.WriteLine("Si deseas hacer suma, oprime 1");
    Console.WriteLine("Si deseas hacer resta, oprime 2");
    Console.WriteLine("Si deseas hacer multiplicacion, oprime 3");
    Console.WriteLine("Si deseas hacer division, oprime 4");

    opcionValida = int.TryParse(Console.ReadLine(), out eleccion);
    if (eleccion >= 1 && eleccion <= 4)
    {
        opcionValida = false;
    }
    else
    {
        Console.WriteLine("Opcion no valida, intenta de nuevo.");
    }
} while (opcionValida);
switch (eleccion)
{
    case 1:
        resultado = num1 + num2;
        break;
    case 2:
        resultado = num1 - num2;
        break;
    case 3:
        resultado = num1 * num2;
        break;
    case 4:
        if (num2 != 0)
        {
            resultado = num1 / num2;
        }
        else
        {
            Console.WriteLine("No se puede dividir entre 0");
            return;
        }
        break;
    default:
        Console.WriteLine("Entrada no válida");
        return;
}
Console.WriteLine($"El resultado de la operacion que elegiste entre {num1} y {num2} es: " + resultado);
Console.ReadKey();