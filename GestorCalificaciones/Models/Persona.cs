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
    // private Dictionary<string, int[]> Notas { get;  set; }
    private Dictionary<string, int[]> Materias = new Dictionary<string, int[]>();



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

    public void AddMaterias(string materia,int periodos)
    {

        Materias.Add(materia, new int[periodos]);

    }
    public void GetNotas(string materia)
    {


    }


}
