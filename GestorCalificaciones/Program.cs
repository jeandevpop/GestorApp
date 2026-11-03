using GestorCalificaciones.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Persona persona = new Persona("juan", 20);
        Estudiante estudiante1 = new Estudiante("juanito", 12);

        estudiante1.Greet();

        bool isRunning = true;

        while (isRunning)
        {

            Console.WriteLine("Hola bienvenido a la escuelita  Las Cañitas ");
            Console.WriteLine("Que quieres hacer? \n");
            Console.WriteLine("1: Inscribir un nuevo estudiante ");
            Console.WriteLine("2: Ver si se quemo y darle su correaso aqui mimito ");
            Console.WriteLine("3: Salir \n");
            Console.WriteLine("");
            string isRunningImput = Console.ReadLine();

            switch (isRunningImput)
            {
                case "1":
                    Console.WriteLine("Para inscribir a un estudiante debe tener 3 cosas");
                    System.Console.WriteLine("1: Acta de nacimiento para el nombre, el apellido y la edad");
                    System.Console.WriteLine("2: El ultimo curso aprovado ");
                    System.Console.WriteLine("3: 300 pesos para la inscripcion ");
                    System.Console.WriteLine("Si tienes todo esto escribe: 1 ");
                    System.Console.WriteLine("Si  no tienes todo esto escribe: 2 ");
                    string inscripcionImput = Console.ReadLine();
                    if (inscripcionImput == "1")
                    {

                    }
                    else if(inscripcionImput== "2")
                    {
                        System.Console.WriteLine("Vuelva cuando lo tenga");

                    }
                    else
                    {
                       Console.WriteLine("Entrada no reconocida");     
                    }

                    break;

                case "2":

                    break;
                case "3":
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




    }
}