using PPAI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Interfaces
{
    internal class VinosSistemaBodega
    {
        private string añada;
        private DateTime fechaActualizacion;
        private string imagenEtiqueta;
        private string nombre;
        private string notaDeCataBodega;
        private int precioARS;

        private List<Maridaje> maridajes;
        private List<TipoUva> tiposUvas;

        public VinosSistemaBodega(string añada, DateTime fechaActualizacion, string imagenEtiqueta, string nombre, string notaDeCataBodega, int precioARS)
        {
            this.añada = añada;
            this.fechaActualizacion = fechaActualizacion;
            this.imagenEtiqueta = imagenEtiqueta;
            this.nombre = nombre;
            this.notaDeCataBodega = notaDeCataBodega;
            this.precioARS = precioARS;
            this.maridajes = new List<Maridaje>();
            this.tiposUvas = new List<TipoUva>();
        }

        public DateTime FechaActualizacion { get => fechaActualizacion; set => fechaActualizacion = value; }
        public List<Maridaje> Maridajes { get => maridajes; set => maridajes = value; }
        public List<TipoUva> TiposUvas { get => tiposUvas; set => tiposUvas = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
