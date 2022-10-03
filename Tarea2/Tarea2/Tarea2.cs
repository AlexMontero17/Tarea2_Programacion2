using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{

    internal class Tarea2
    {
        
        public string nombre;

        public void Nombreempleado(string nombres, int salario)
        {
            Console.WriteLine("El nombre del empleado es " + nombres + ", su salario es de " + salario + " dolares y su aguinaldo es " + salario * 12 + " dolares.");
        }



        static void Main(string[] args)
        {
            int num_empleados;
            string linea;
            string[] info;
            string nombres;
            int salario;


            Console.WriteLine("Digite la cantidad de empleados a analizar: ");
            linea = Console.ReadLine();
            num_empleados = int.Parse(linea);


            info = new string[num_empleados];
            for (int f = 0; f < info.Length; f++)
            {
                Console.WriteLine("Ingrese el nombre del empleado: ");
                nombres = Console.ReadLine();

                Console.WriteLine($"Ingrese el salario de {nombres}: ");
                linea = Console.ReadLine();
                salario = int.Parse(linea);


                Tarea2 miTarea2 = new Tarea2();
                miTarea2.Nombreempleado(nombres, salario);
                Console.WriteLine();
            }
            Console.WriteLine("Pulse alguna tecla para salir");
            Console.ReadKey();
        }
    }
}