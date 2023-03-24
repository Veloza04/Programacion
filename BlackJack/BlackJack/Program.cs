Console.WriteLine("Juguemos BlackJack");
bool seguirJugando;
do
{
    Random cartas = new();

    int[] opciones = Enumerable.Range(1, 10).ToArray();
    int[] opcionesMaquina = Enumerable.Range(5, 6).ToArray(); //rango de 5 a 10 
    int carta1Jugador = opciones[cartas.Next(opciones.Length)];
    int carta2Jugador = opciones[cartas.Next(opciones.Length)];
    int carta1Maquina = opcionesMaquina[cartas.Next(opcionesMaquina.Length)];
    int carta2Maquina = opcionesMaquina[cartas.Next(opcionesMaquina.Length)];
    int sumaInicial = carta1Jugador + carta2Jugador;
    int sumaMaquina = carta1Maquina + carta2Maquina;

    Console.WriteLine($"Tus cartas son: {carta1Jugador} y {carta2Jugador}");
    Console.WriteLine($"En total tienes {sumaInicial}");

    string pedirCarta = "";
    int sumaActual = sumaInicial;
    while (sumaActual <= 21 && pedirCarta != "N")
    {
        Console.WriteLine("Deseas recibir otra carta? S/N");
        pedirCarta = Console.ReadLine().ToUpper();

        if (pedirCarta == "S")
        {
            int nuevaCarta = opciones[cartas.Next(opciones.Length)];
            sumaActual += nuevaCarta;
            Console.WriteLine($"Has recibido una carta con valor {nuevaCarta}");
            Console.WriteLine($"En total, tienes una suma de {sumaActual}");
        }
    }
    Console.WriteLine($"La maquina tiene las cartas: {carta1Maquina} y {carta2Maquina} para un total de: {sumaMaquina}");
    if (sumaActual > sumaMaquina && sumaActual < 21)
    {
        Console.WriteLine("¡Has Ganado!");
    }
    else
    {
        Console.WriteLine("¡Has Perdido!");
    }

    Console.WriteLine("¿Deseas seguir jugando? S/N");
    string jugarDeNuevo = Console.ReadLine().ToUpper();
    seguirJugando = jugarDeNuevo == "S";

} while (seguirJugando);
Console.WriteLine("Gracias por jugar. Presione cualquier tecla para salir.");