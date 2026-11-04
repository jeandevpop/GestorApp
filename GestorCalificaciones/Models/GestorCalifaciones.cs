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

}
