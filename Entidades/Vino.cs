using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Vino
    {
        //atributos
        private string añada;
        private DateTime fechaActualizacion;
        private string imagenEtiqueta;
        private string nombre;
        private string notaDeCataBodega;
        private int precioARS;

        private List<Maridaje> maridaje;
        private List<Varietal> varietal;
        //constructor
        public Vino(string añada, DateTime fechaActualización, string imagenEtiqueta, string nombre, string notaDeCataBodega, int precioARS)
        {
            this.añada = añada;
            this.fechaActualizacion = fechaActualizacion;
            this.imagenEtiqueta = imagenEtiqueta;
            this.nombre = nombre;
            this.notaDeCataBodega = notaDeCataBodega;
            this.precioARS = precioARS;

            //faltan pasar el maridaje y el varietal 
        }
        //metodos
        public void crearVarietal() { }
        public Boolean sosEsteVino(Vino vino) {
            /*
            if (this.nombre = vino.getNombre() )
            {
                return true;
            }*/
            return false;
        }
        public Boolean sosVinoParaActualizar(string nombreDeVinoParaActualizar){
            if (nombreDeVinoParaActualizar == this.getNombre())
            {
                return true;
            }
            return false;
        }
        public void esDeBodega() { }
        public void esActualizable() { }
        public String getNombre(){ 
            return this.nombre;
        }

        public void setNotaCata(string notaCata)
        {
            this.notaDeCataBodega = notaCata;
        }

        public void setPrecio(int precio)
        {
            this.precioARS = precio;
        }

        public void setImagenEtiqueta( string imagen)
        {
            this.imagenEtiqueta = imagen;
        }

        public void setFechaActulizacion(DateTime fechaActual)
        {
            this.fechaActualizacion = fechaActual;
        }
    }
}
