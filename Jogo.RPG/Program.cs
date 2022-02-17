using Jogo.RPG.Entities;
using System;

namespace Jogo.RPG
{
    class Program
    {
        static void Main(string[] args)
        {
          Knight arus = new Knight ("Arus", 23, "Knight");
          Wizard wizard = new Wizard("Rainha dos magos ", 90, "Knight");
          Ninja ninja = new Ninja("Ninja", 70, "Ninja");

            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
           




        }
    }
}
 