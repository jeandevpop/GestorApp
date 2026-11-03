using System;
using System.Security.Cryptography.X509Certificates;

namespace GestorCalificaciones.Models;

public class Persona
{

    protected string Name { get; private set; }
    protected int Age { get; private set; }


    public Persona(string name, int age)
    {
        Name = name;
        Age = age;

    }


    public virtual void Greet()
    {

        System.Console.WriteLine($"Hola {Name}");
    }



}
public class Estudiante : Persona
{

    // private Dictionary<string, List<int>> Notas3 { get;  set; }
    private Dictionary<string, int[]> Notas { get;  set; }


    public Estudiante(string name, int age) : base(name, age)
    {


    }

    public override void Greet()
    {
        System.Console.WriteLine($"Hola {Name} bienvenido a la escuela ");

    }

    private void SetNotas()
    {
        
    }

    public  void AddNotas(string materia)
    {
        Notas.Add(materia,new int [4]);

    }
    public void GetNotas(string materia)
    {
       

    }


}
