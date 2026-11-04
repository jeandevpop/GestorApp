using System.Dynamic;
using GestorCalificaciones.Models;
namespace GestorCalificaciones.Models;

public class Estudiante : Persona

{




    private Dictionary<string, int[]> Materias = new Dictionary<string, int[]>();
    public int StudenID { get; private set; }
    private  List<int> CalificacionesListInt = new List<int>();
    
    private bool Isaproved{get; set;}
    double MinimoAprovado = 75.0;
    





    public Estudiante(string name, string lastName, int age, int studentID,List<int>?calificaciones) : base(name, lastName, age)
    {

        StudenID = studentID;
        if(calificaciones != null)
        {
            CalificacionesListInt = calificaciones;
        }
    
    }

    public override void Greet()
    {
        System.Console.WriteLine($"Hola {Name} {LastName} ,  de  {Age} años bienvenido a la escuela ");

    }
    public void EstudianteInscrito()
    {
        System.Console.WriteLine($"Hola ID:{StudenID} - {Name} {LastName} ,  de  {Age} esta inscrito ");

    }

    public void SetNotas()
    {
            CalificacionesListInt.Add(70);
            CalificacionesListInt.Add(85);
            CalificacionesListInt.Add(90);
            CalificacionesListInt.Add(80);


    }

    public void AddMaterias(string materia, int periodos)
    {

        Materias.Add(materia, new int[periodos]);

    }
    public void GetNotas()
    {
        if(CalificacionesListInt.Count> 0 && CalificacionesListInt.Count >= 4)
        {
            double promedio;
            int notas= 0;
            // System.Console.WriteLine();
            foreach (int nota in CalificacionesListInt)
            {
            notas += nota;
            }

            promedio = notas / CalificacionesListInt.Count;
            
            System.Console.WriteLine($"Las todas de este {Name} son: {string.Join(",",CalificacionesListInt)} ");

            System.Console.WriteLine($"El promedio del estudiante es {promedio}");
            
        }
        else
        {
            System.Console.WriteLine("Este estudiante no tiene notas agregadas");
        }


    }
    


}

