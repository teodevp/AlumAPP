using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alum.Modelos
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }
        public string Curso { get; set; }
        public bool Activo { get; set; }
    }
}