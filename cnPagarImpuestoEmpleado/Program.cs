using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnPagarImpuestoEmpleado
{
    internal class Program
    {
        /// <summary>
        /// Nombre: jhonatan stiven mosquera moreno
        /// fecha: 24/02/2023
        /// descripcion: Elpograma dice si el usuario debe o no pagar impuesto
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del empleado:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del empleado:");
            double sueldo = Convert.ToDouble(Console.ReadLine());
            SueldoEimpuesto(sueldo, nombre);

            Console.ReadKey();
        }

        static void SueldoEimpuesto(double sueldo, string nombre)
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("señor " + nombre + " debe pagar impuestro ");
            }
            else
            {
                Console.WriteLine("señor " + nombre + " no debe pagar impuestro ");
            }


        }



    }
}

