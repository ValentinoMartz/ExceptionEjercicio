using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnException
{
    public class Medico
    {
        public Medico(string nombre)
        {
            if (nombre.Length < 1 || nombre.Length > 50)
            {
                throw new Exception("El nombre no puede estar vacío o superar los 50 carácteres");
            }
            else if (nombre.Split(' ').Length > 1)
            {
                throw new Exception("Quitar espacios en blanco antes o después del nombre");
            }

            else
            {
                Nombre = nombre;
            }
        }

        public string Nombre { get; set; }  
    }
}
