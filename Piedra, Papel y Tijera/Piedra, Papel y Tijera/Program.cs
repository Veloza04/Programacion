Random eleccion = new();
char[] opciones = { 'R', 'P', 'S' };
int puntuacionJugador = 0;
int puntuacionMaquina = 0;

Console.WriteLine("Juguemos Piedra, Papel o Tijera");

while (true)
{
    char eleccionMaquina = opciones[eleccion.Next(3)];
    Console.Write("Ingresa tu opción Piedra (R), Papel (P) o Tijera (S)): ");
    string eleccionJugador = Console.ReadLine().ToUpper();
    Console.WriteLine($"La computadora eligió {eleccionMaquina}. Y tu elegiste {eleccionJugador}.");

    switch (eleccionJugador)
    {
        case "R":
            if (eleccionMaquina == 'R')
            {
                Console.WriteLine("¡Empate!");
            }
            else if (eleccionMaquina == 'P')
            {
                Console.WriteLine("¡La computadora gana!");
                puntuacionMaquina++;
            }
            else
            {
                Console.WriteLine("¡Usted gana!");
                puntuacionJugador++;
            }
            break;
        case "P":
            if (eleccionMaquina == 'R')
            {
                Console.WriteLine("¡Usted gana!");
                puntuacionJugador++;
            }
            else if (eleccionMaquina == 'P')
            {
                Console.WriteLine("¡Empate!");
            }
            else
            {
                Console.WriteLine("¡La computadora gana!");
                puntuacionMaquina++;
            }
            break;
        case "S":
            if (eleccionMaquina == 'R')
            {
                Console.WriteLine("¡La computadora gana!");
                puntuacionMaquina++;
            }
            else if (eleccionMaquina == 'P')
            {
                Console.WriteLine("¡Usted gana!");
                puntuacionJugador++;
            }
            else
            {
                Console.WriteLine("¡Empate!");
            }
            break;
        default:
            Console.WriteLine("Elección inválida.");
            break;
    }
    Console.WriteLine($"Puntuación: Usuario: {puntuacionJugador}, Computadora: {puntuacionMaquina}");
    Console.WriteLine("");
}