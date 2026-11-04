using System.Security.Cryptography.X509Certificates;
using GestorCalificaciones.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


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


                        AddEstudianteToList(CreacionEstudiante(), listaEstudiantes);



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
            // string inscripcionImput = Console.ReadLine();

            return Console.ReadLine();
        }

        static string Menu()
        {
            Console.WriteLine("Hola bienvenido a la escuelita  Las Cañitas ");
            Console.WriteLine("Que quieres hacer? \n");
            Console.WriteLine("1: Inscribir un nuevo estudiante ");
            Console.WriteLine("2: Ver si se quemo y darle su correaso aqui mimito ");
            System.Console.WriteLine("3: ver los estudiantes inscritos");
            Console.WriteLine("4: Salir \n");


            return Console.ReadLine();
        }
        static Estudiante? CreacionEstudiante()
        {

            string name;
            string lastName;
            int edad ;




            name = LoopImputString("Cual es el nombre del estudiante");
            if (name == "cancelar")
            {
                System.Console.WriteLine("le diste a cancelar la inscripcion hablamo el malte");
                return default;
            }
            lastName = LoopImputString("Cual es el apellido del estudiante");
            if (lastName == "cancelar")
            {
                System.Console.WriteLine("le diste a cancelar la inscripcion hablamo el malte");
                return default;
            }



            // if (name == "cancelar" || lastName == "cancelar" )
            // {
            //     System.Console.WriteLine("le diste a cancelar la inscripcion hablamo el malte");
            //     return default;
            // }

            // System.Console.WriteLine("Cual es la edad del estudiante");
            edad = LoopImputInt("Cual es la edad del estudiante");
            if (edad == null)
            {
                System.Console.WriteLine("le diste a cancelar la inscripcion hablamo el malte");
                return default;


            }
            else
            {
            Estudiante estudiante = new Estudiante(name, lastName, edad);
                
            return estudiante;
            }

            // while (!int.TryParse(Console.ReadLine(), out edad) || edad < 3 || edad > 22)
            // {


            //     System.Console.WriteLine("Edad no valida para edad tiene que ser mas de 3 y menos de 23. Intente de nuevo:");



            // }












        }





        static string LoopImputString(string msj)
        {
            bool loopingImput = true;
            string stringToreturn = "";

            while (loopingImput)
            {
                Console.WriteLine(msj);
                System.Console.WriteLine("Si quieres cancelar escribe Cancelar ");

                string imput = Console.ReadLine();


                if (imput.ToLower() == "cancelar")
                {
                    return "cancelar";
                    loopingImput = false;
                    break;
                }
                else if (string.IsNullOrEmpty(imput))
                {
                    System.Console.WriteLine("Por favor entra un valor en letras valido");
                }
                else if (imput.Any(char.IsDigit))
                {
                    System.Console.WriteLine("Por favor entra un valor en letras valido");

                }
                else
                {
                    stringToreturn = imput;
                    loopingImput = false;
                }




            }
            loopingImput = false;

            return stringToreturn;


        }


        static int LoopImputInt(string msj)
        {
            bool loopingImput = true;
            // int intToreturn = 0;

            while (loopingImput)
            {
                Console.WriteLine(msj);
                System.Console.WriteLine("Si quieres cancelar escribe Cancelar ");

                string imput = Console.ReadLine();
                if (imput.ToLower() == "cancelar")
                {
                    return default;
                    loopingImput = false;
                    break;
                }else if (string.IsNullOrEmpty(imput))
                {
                    System.Console.WriteLine("Por favor entra un valor en numeros valido");
                }

                bool edadbool = int.TryParse(imput, out int edad);
                if (edadbool)
                {
                    if (edad >= 3)
                    {
                            return edad;

                    }
                    else if(edad <3)
                    {
                        System.Console.WriteLine("error!!!!! Edad menor a 3 años");
                        // System.Console.WriteLine("error!!!!! vuelve looping egain");
                    }
                }



                
                // else if (int.TryParse(imput, out int edad))
                // {
                //     System.Console.WriteLine("Por favor entra un valor en numeros valido");
                // }
                // else if (int.TryParse(imput, out edad))
                // {
                //     System.Console.WriteLine($" Entraste {imput}");
                //     intToreturn = edad;
                //     return edad;

                // }
                // else
                // {

                //     System.Console.WriteLine("error!!!!! vuelve looping egain");
                //     // stringToreturn = imput;
                //     // loopingImput = false;
                // }









            }
            // loopingImput = false;

            return default;


        }



        static void EstudiantesInscritos(Estudiante estudiante)
        {
            estudiante.EstudianteInscrito();

        }


        static void AddEstudianteToList(Estudiante estudiante, List<Estudiante> lista)
        {

            lista.Add(estudiante);


        }


    }




}


