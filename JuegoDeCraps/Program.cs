using System;
using JuegoDeCraps;

namespace JuegoDeCraps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego de Craps!");

            Craps juego = new Craps();
            juego.Jugar();
        }
    }
}
