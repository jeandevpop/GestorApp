using System;
using System.Security.Cryptography.X509Certificates;

namespace GestorCalificaciones.Models;

public class Persona
{

    protected string Name { get;   set; }
    protected string LastNameName { get;   set; }
    protected int Age { get; private set; }


    public Persona(string name, string lastName, int age)
    {
        Name = name;
        LastNameName =lastName;
        Age = age;

    }


    public virtual void Greet()
    {

        System.Console.WriteLine($"Hola {Name}");
    }



}
