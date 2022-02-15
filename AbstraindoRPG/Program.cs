using System;
using AbstraindoRPG.src.Entities;

namespace AbstraindoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenna", 23, "White Wizard");
            Ninja ninja = new Ninja("Wedge", 23, "Ninja");
            BlackWizard blackWizard = new BlackWizard("Topapa", 23, "Black Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
        }
    }
}
