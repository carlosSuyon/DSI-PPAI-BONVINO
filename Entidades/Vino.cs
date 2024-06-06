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

        public string Añada { get => añada; set => añada = value; }
        public DateTime FechaActualizacion { get => fechaActualizacion; set => fechaActualizacion = value; }
        public string ImagenEtiqueta { get => imagenEtiqueta; set => imagenEtiqueta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NotaDeCataBodega { get => notaDeCataBodega; set => notaDeCataBodega = value; }
        public int PrecioARS { get => precioARS; set => precioARS = value; }
        public List<Maridaje> Maridaje { get => maridaje; set => maridaje = value; }
        public List<Varietal> Varietal { get => varietal; set => varietal = value; }

        //constructor
        public Vino() { }
        public Vino(string añada, DateTime fechaActualización, string imagenEtiqueta, string nombre, string notaDeCataBodega, int precioARS)
        {
            this.añada = añada;
            this.fechaActualizacion = fechaActualizacion;
            this.imagenEtiqueta = imagenEtiqueta;
            this.nombre = nombre;
            this.notaDeCataBodega = notaDeCataBodega;
            this.precioARS = precioARS;



            //faltan pasar el maridaje y el varietal 
            this.maridaje = new List<Maridaje>();
            
            this.varietal = new List<Varietal>();
            this.crearVarietal();

        }
        //metodos
        public void crearVarietal() { }
        public Boolean esDeBodega(string nombreVino) {
            
            if ( this.nombre == nombreVino )
            {
                return true;
            }
            return false;
        }
        public Boolean sosVinoParaActualizar(string nombreDeVinoParaActualizar){
            if (nombreDeVinoParaActualizar == this.getNombre())
            {
                return true;
            }
            return false;
        }
         
        public Boolean esActualizable(){
            return false;   
        }
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
