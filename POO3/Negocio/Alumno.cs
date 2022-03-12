using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3.Negocio
{
    class Alumno
    {
        public String DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string sexo { get; set; }
       

        public int promediar(int n1, int n2, int n3)
        {
            int promedio = (n1 + n2 + n3) / 3;
            return promedio;
        }


        public void limpiar()
        {
            Console.Clear();
        }
        public void Mostrardatos()
        {
            Console.WriteLine("-----------datos alumno------");
            Console.WriteLine("DNI :" + this.DNI);
            Console.WriteLine("Nombres :" + this.Nombres);
            Console.WriteLine("APELLIDOS :" + this.Apellidos);
            Console.WriteLine("SEXO : " + this.sexo);
           
        }

        public string GenerarCodigo(int n1, int n2, int n3)
        {
            String codigo = this.DNI.Substring(0, 5) + this.Apellidos.Substring(0, 3);
            return codigo;
        }

      
        public string leerNota(int nota)
        {
            String notaTexto = null;
            if (nota == 0)
            {
                notaTexto = "cero";

            }
            else if (nota == 1)
            {
                notaTexto = "uno ";

            }
            else if (nota == 2)
            {
                notaTexto = "dos";

            }
            else if (nota == 3)
            {
                notaTexto = "tres ";

            }
            else if (nota == 4)
            {
                notaTexto = "Cuatro";

            }
            else if (nota == 5)
            {
                notaTexto = "Cinco";
            }
            else if (nota == 6)
            {
                notaTexto = "seis";

            }
            else if (nota == 7)
            {
                notaTexto = "siete";
            }
            else if (nota == 8)
            {
                notaTexto = " ocho";
            }
            else if (nota == 9)
            {
                notaTexto = " nieve";
            }
            else if (nota == 10)
            {
                notaTexto = "Dies";
            }
            else if (nota == 11)
            {
             notaTexto = "once";
            }  

             else if (nota == 12)
            {
            notaTexto = "Doce";

            }
            else if (nota == 13)
            {
                notaTexto = "Trece";

            }
            else if (nota == 14)
            {
                notaTexto = "Catorce";

            }
            else if (nota == 15)
            {
                notaTexto = "Quince";

            }
            else if (nota == 16)
            {
                notaTexto = "Diesisesis";

            }
            else if (nota == 17)
            {
                notaTexto = "diecicitete";

            }
            else if (nota == 18)
            {
                notaTexto = "Dociciocho";

            }
            else if (nota == 19)
            {
                notaTexto = " diecinueve";
            }
            else if (nota == 20)
            {
                notaTexto = "venite";

            }

            return notaTexto;
        
        }
    }
}
