using System;

namespace GestorCalificaciones.Models;

public class GestorCalifaciones
{
        private Dictionary<string, int[]> Materias = new Dictionary<string, int[]>();
        private List<int> CalificacionesListInt= new List<int>();
        private int[] CalificacionesArrInt= new int[4];
        private string Materia {get; set;}


        public GestorCalifaciones()
    {
        

    }


    public void GetNotas(Estudiante estudiante)
    {
        estudiante.GetNotas();

    }
    public void SetNotas(Estudiante estudiante,int nota)
    {
        estudiante.SetNotas(nota);

    }
    public bool CreacionEstudiante(string name, string lastName, int edad, int studentID)
    {
                        Estudiante estudiante = new Estudiante(name, lastName, edad, studentID, null);


        return false;
    }

}
