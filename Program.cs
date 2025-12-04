using System;

namespace PracticaGit_Adrián_González
{
    class Program
    {
        static void Main(string[] args) 
        { 
            Persona persona = new Persona("Adrian", 21);

            Salutador salutador = new Salutador();

            salutador.Saluda(persona);
        }
    }
}
