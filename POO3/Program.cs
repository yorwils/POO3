using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO3.Negocio;

namespace POO3
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();

            Console.WriteLine("ingese el dni");
            alumno.DNI = Console.ReadLine();
            Console.WriteLine("ingrese el Nombres: ");
            alumno.Nombres = Console.ReadLine();
            Console.WriteLine("ingrese apellidos: ");
            alumno.Apellidos = Console.ReadLine();
            Console.WriteLine("ingrese sexo");
            alumno.sexo = Console.ReadLine();


            Console.WriteLine("ingres nota 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese nota 2");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese nota 3");
            int n3 = int.Parse(Console.ReadLine());
            alumno.limpiar();
            alumno.Mostrardatos();
            alumno.leerNota(0);
            Console.WriteLine(" promedio: " + alumno.promediar(n1, n2, n3));
         int nota = 0;  
            Console.WriteLine("leer nota :" + alumno.leerNota(nota));
            
        }

    }
}
