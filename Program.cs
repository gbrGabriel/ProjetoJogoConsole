using System;
using ProjetoJogoRPG.src.Entities;
using static System.Console;


namespace Projeto
{
    class JogoRPG
    {
        static void Main(string[] args)
        {
            var arus = new Knight("Arus", 23, "Knight");
            var wizard = new Wizard("Jennica", 23, "White Wizard");
            WriteLine(arus.Attack());
            WriteLine(wizard.Attack(5));
        }
    }
}