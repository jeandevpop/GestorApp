using System.Security.Cryptography.X509Certificates;
using GestorCalificaciones.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Persona persona = new Persona("juan", 20);
        // Estudiante estudiante1 = new Estudiante("juanito", 12);
        List<Estudiante> listaEstudiantes = new List<Estudiante>();

        // estudiante1.Greet();

        bool isRunning = true;

        while (isRunning)
        {


            string isRunningImput = Menu();

            switch (isRunningImput)
            {
                case "1":

                    string inscripcionImput = Inscripcion();

                    if (inscripcionImput == "1")
                    {


                       listaEstudiantes= AddEstudianteToList(CreacionEstudiante(), listaEstudiantes);



                    }
                    else if (inscripcionImput == "2")
                    {
                        System.Console.WriteLine("ver las notas");

                    }
                    else if (inscripcionImput == "3")
                    {


                    }
                    else
                    {
                        Console.WriteLine("Entrada no reconocida");
                    }

                    break;

                case "2":

                    break;
                case "3":
                    System.Console.WriteLine("ver los estudiantes inscritos");
                    foreach (Estudiante alumno in listaEstudiantes)
                    {
                        EstudiantesInscritos(alumno);

                    }
                    break;
                case "4":
                    System.Console.WriteLine("Muchas gracias hablamos luego");
                    isRunning = false;

                    break;

                default:

                    System.Console.WriteLine("No te entendi, escribe de nuevo del 1 al 3\n");
                    System.Console.WriteLine("\n");
                    Console.ReadLine();
                    break;
            }








        }
        static string Inscripcion()
        {
            Console.WriteLine("Para inscribir a un estudiante debe tener 3 cosas");
            System.Console.WriteLine("- Acta de nacimiento para el nombre, el apellido y la edad");
            System.Console.WriteLine("- El ultimo curso aprovado ");
            System.Console.WriteLine("- 300 pesos para la inscripcion ");
            System.Console.WriteLine("Si tienes todo esto escribe: 1 ");
            System.Console.WriteLine("Si  no tienes todo esto escribe: 2 ");
            string inscripcionImput = Console.ReadLine();

            return inscripcionImput;
        }

        static string Menu()
        {
            Console.WriteLine("Hola bienvenido a la escuelita  Las Cañitas ");
            Console.WriteLine("Que quieres hacer? \n");
            Console.WriteLine("1: Inscribir un nuevo estudiante ");
            Console.WriteLine("2: Ver si se quemo y darle su correaso aqui mimito ");
            System.Console.WriteLine("3: ver los estudiantes inscritos");
            Console.WriteLine("4: Salir \n");
            // Console.WriteLine("");

            return Console.ReadLine();
        }
        static Estudiante CreacionEstudiante()
        {
            string name;
            string lastName;
            int edad = 0;
            System.Console.WriteLine("Cual es el nombre del estudiante");
            name = Console.ReadLine();
            System.Console.WriteLine("Cual es el apellido del estudiante");
            lastName = Console.ReadLine();
            System.Console.WriteLine("Cual es la edad del estudiante");
            bool intEdad = int.TryParse(Console.ReadLine(), out int intParseResult);
            if (intEdad)
            {
                edad = intParseResult;
            }
            else
            {
                System.Console.WriteLine("entrada no valida para edad");
            }

            // Console.WriteLine($" El estudiante que quieres instribir es {name} {lastName} y tiene {edad} años. \n ");
            Estudiante estudiante = new Estudiante(name, lastName, edad);
            Console.WriteLine($" El estudiante {name} {lastName} fue inscrito  \n");
            estudiante.Greet();

            estudiante.AddMaterias("Matematica", 4);
            // System.Console.WriteLine();
            return estudiante;

        }


        static void EstudiantesInscritos(Estudiante estudiante)
        {
            estudiante.EstudiantesInscritos();

        }


        static List<Estudiante> AddEstudianteToList(Estudiante estudiante,List<Estudiante>lista)
        {
            List<Estudiante> estudiantes =lista ;
            estudiantes.Add(estudiante);
            
            return estudiantes;
        }
    }




}


