using System;

namespace GestorCalificaciones.Models;

public class GestorCalifaciones
{
    private Dictionary<string, int[]> Materias = new Dictionary<string, int[]>();
    private List<int> CalificacionesListInt = new List<int>();
    private int[] CalificacionesArrInt = new int[4];
    private string Materia { get; set; }


    public GestorCalifaciones()
    {


    }


    public void GetNotas(Estudiante estudiante)
    {
        estudiante.GetNotas();

    }
    public void SetNotas(Estudiante estudiante, double nota)
    {
        bool addNotaLoop = true;
        while (addNotaLoop)
        {
            if (nota <= 0 && nota > 100)
            {
                

                System.Console.WriteLine("EL valor de la nota no es valida intenta de nuvo");
                bool isValidNota = double.TryParse(Console.ReadLine(), out double nota2);
                if (isValidNota)
                {
                    estudiante.SetNotas(nota2);
                    addNotaLoop = false;
                }
            }
            else
            {
                estudiante.SetNotas(nota);
                addNotaLoop =false;

            }
        }


    }
    public bool CreacionEstudiante(string name, string lastName, int edad, int studentID)
    {
        Estudiante estudiante = new Estudiante(name, lastName, edad, studentID, null);


        return false;
    }

}
