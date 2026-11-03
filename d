[1mdiff --git a/GestorCalificaciones/Models/Persona.cs b/GestorCalificaciones/Models/Persona.cs[m
[1mindex 0c9e3d7..da76296 100644[m
[1m--- a/GestorCalificaciones/Models/Persona.cs[m
[1m+++ b/GestorCalificaciones/Models/Persona.cs[m
[36m@@ -31,7 +31,9 @@[m [mpublic class Estudiante : Persona[m
 {[m
 [m
     // private Dictionary<string, List<int>> Notas3 { get;  set; }[m
[31m-    private Dictionary<string, int[]> Notas { get;  set; }[m
[32m+[m[32m    // private Dictionary<string, int[]> Notas { get;  set; }[m
[32m+[m[32m    private Dictionary<string, int[]> Notas = new Dictionary<string, int[]>();[m
[32m+[m
 [m
 [m
     public Estudiante(string name, int age) : base(name, age)[m
[36m@@ -48,17 +50,18 @@[m [mpublic class Estudiante : Persona[m
 [m
     private void SetNotas()[m
     {[m
[31m-        [m
[32m+[m
     }[m
 [m
[31m-    public  void AddNotas(string materia)[m
[32m+[m[32m    public void AddNotas(string materia)[m
     {[m
[31m-        Notas.Add(materia,new int [4]);[m
[32m+[m
[32m+[m[32m        Notas.Add(materia, new int[4]);[m
 [m
     }[m
     public void GetNotas(string materia)[m
     {[m
[31m-       [m
[32m+[m
 [m
     }[m
 [m
