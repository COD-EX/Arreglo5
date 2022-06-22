using System;

namespace Arreglo6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrar las notas del examen parcial, oral y final de 3 alumnos, si el promedio es mayor a 11.5 se debe mostrar un mensaje de APROBADOS, caso contrario DESAPROBADO.
            string[] nombre = new string[3];
            double[] examenParcial = new double[3];
            double[] examenOral = new double[3];
            double[] examenFinal = new double[3];

            double promedio = 0;

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("Ingrese nombre del estudiante " + i);
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese su examen Parcial");
                examenParcial[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese su examen Oral");
                examenOral[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese su examen Final");
                examenFinal[i] = Convert.ToDouble(Console.ReadLine());

                promedio = (examenParcial[i] + examenOral[i] + examenFinal[i])/3;
                if (promedio >= 11.5)
                {
                    Console.WriteLine("Promedio es " + promedio);
                    Console.WriteLine("APROBADO");
                }
                else
                {
                    Console.WriteLine("Promedio es " + promedio);
                    Console.WriteLine("DESAPROBADO");
                }
                    
            }
            Console.ReadKey();
        }
    }
}
