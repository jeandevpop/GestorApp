using GestorCalificaciones.Models;

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

