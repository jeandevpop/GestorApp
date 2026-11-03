using GestorCalificaciones.Models;
namespace GestorCalificaciones.Models;

public class Estudiante : Persona

{

    // string _name { get; set; }
    // string Name { get; set; }
    // string _lastName { get; set; }
    // string lastName { get; set; }
    // int _age { get; set; }
    // int age { get; set; }
    // private Dictionary<string, List<int>> Notas3 { get;  set; }
    // private Dictionary<string, int[]> Notas { get;  set; }
    private Dictionary<string, int[]> Materias = new Dictionary<string, int[]>();



    public Estudiante(string name, string lastName, int age) : base(name, lastName, age)
    {
        // _name = name;
        // _lastName = lastName;
        // _age = age;

        




    }

    public override void Greet()
    {
        System.Console.WriteLine($"Hola {Name} {LastName} ,  de  {Age} años bienvenido a la escuela ");

    }
    public  void EstudiantesInscritos()
    {
        System.Console.WriteLine($"Hola {Name} {LastName} ,  de  {Age} esta inscrito ");

    }

    private void SetNotas()
    {

    }

    public void AddMaterias(string materia, int periodos)
    {

        Materias.Add(materia, new int[periodos]);

    }
    public void GetNotas(string materia)
    {


    }


}

