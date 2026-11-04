using System.Dynamic;
using GestorCalificaciones.Models;
namespace GestorCalificaciones.Models;

public class Estudiante : Persona

{

   


    private Dictionary<string, int[]> Materias = new Dictionary<string, int[]>();
    public int StudenID {get; private set;}
    



    public Estudiante(string name, string lastName, int age,int studentID) : base(name, lastName, age)
    {
       
        StudenID =studentID;
        




    }

    public override void Greet()
    {
        System.Console.WriteLine($"Hola {Name} {LastName} ,  de  {Age} años bienvenido a la escuela ");

    }
    public  void EstudianteInscrito()
    {
        System.Console.WriteLine($"Hola ID:{StudenID} - {Name} {LastName} ,  de  {Age} esta inscrito ");

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

