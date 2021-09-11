using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            while (menu)
            {
                menu = menuprincipal();
            }
            Console.ReadKey();
        }

        // menu principal de la consola
        private static bool menuprincipal()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("1 - ingresar nombre del paciente");
            Console.WriteLine("2 - actualizar datos del paciente");
            Console.WriteLine("3 - mostrar listado de pacientes");
            Console.WriteLine("4 - cerrar");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("cerrar.");

            switch (Console.ReadLine())
            {
                case "1":
                    regprod();
                    return true;
                case "2":
                    return true;
                case "3":
                    return true;
                case "4":
                    return false;
                default:
                    return false;
            }
        }
        // obtener la ruta del archivo
        private static string direccion()
        {
            string path = @"";
            return path;
        }
        // registro de productos
        private static void regprod()
        {
            Console.WriteLine("Registar un nuevo paciente: ");
            Console.Write("Nombre del paciente: ");
            String nompac = Console.ReadLine();
            Console.Write("edad del paciente: ");
            int edadpac = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter pr = File.AppendText(direccion()))
            {
                pr.WriteLine("{0}; {1}", nompac, edadpac);
                pr.Close();

            }
        }
    }
}

