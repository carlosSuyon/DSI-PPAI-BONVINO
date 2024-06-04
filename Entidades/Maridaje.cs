using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Maridaje
    {
        private string descripcion;
        private string nombre;

        public Maridaje(string descripcion,string nombre){
            this.descripcion = descripcion; this.nombre = nombre;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Boolean sosMaridaje()
        {
            Boolean x = false;
            //logica
            return x;
        }
    }
}
