using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class TipoUva
    {
        private string descripcion;
        private string nombre;

        public TipoUva(string descripcion, string nombre)
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
        }
        public TipoUva() { }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Boolean esElTipoUva(string tipoUvaDelNuevoVino)
        {       
            if (this.nombre == tipoUvaDelNuevoVino)
            {
                   return true;
            }
            return false;
        }
    }
}
