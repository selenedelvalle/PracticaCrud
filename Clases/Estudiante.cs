using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCrud.Clases
{
    internal class Estudiante
    {
        public int matricula { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string edad { get; set; }
        public string sexo { get; set; }
        public Estudiante() 
        { 
        }
    }
    
}
