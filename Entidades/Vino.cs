﻿namespace PPAI.Entidades
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
        private Bodega bodega;
        public string Añada { get => añada; set => añada = value; }
        public DateTime FechaActualizacion { get => fechaActualizacion; set => fechaActualizacion = value; }
        public string ImagenEtiqueta { get => imagenEtiqueta; set => imagenEtiqueta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NotaDeCataBodega { get => notaDeCataBodega; set => notaDeCataBodega = value; }
        public int PrecioARS { get => precioARS; set => precioARS = value; }
        public List<Maridaje> Maridaje { get => maridaje; set => maridaje = value; }
        public List<Varietal> Varietal { get => varietal; set => varietal = value; }
        public Bodega Bodega { get => bodega; set => bodega = value; }

        //constructor
        public Vino() { }
        public Vino(string añada, DateTime fechaActualización, string imagenEtiqueta, string nombre, string notaDeCataBodega, int precioARS, Bodega bodega)
        {
            this.añada = añada;
            this.fechaActualizacion = fechaActualización;
            this.imagenEtiqueta = imagenEtiqueta;
            this.nombre = nombre;
            this.notaDeCataBodega = notaDeCataBodega;
            this.precioARS = precioARS;
            this.Bodega = bodega;
            this.maridaje = new List<Maridaje>();
            this.varietal = new List<Varietal>();
        }
        //metodos
        public void crearVarietal(List<string[]> varietales, List<TipoUva> tiposDeUva)
        {
            foreach (string[] varietal in varietales)
            {
                string nV = varietal[0];
                string dV = varietal[1];
                int pC = int.Parse(varietal[2]);
                TipoUva uva = new TipoUva();
                for (int i = 0; i < tiposDeUva.Count; i++)
                {
                    uva = tiposDeUva[i];
                }
                Varietal v = new Varietal(nV, dV, pC, uva);
                this.Varietal.Add(v);
            }

        }
        public Boolean esDeBodega(string nombreVino)
        {

            if (this.nombre == nombreVino)
            {
                return true;
            }
            return false;
        }
        public Boolean sosVinoParaActualizar(string nombreDeVinoParaActualizar)
        {
            if (this.Nombre == nombreDeVinoParaActualizar)
            {
                return true;
            }
            return false;
        }

        public Boolean esActualizable()
        {
            return false;
        }
        public String getNombre()
        {
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

        public void setImagenEtiqueta(string imagen)
        {
            this.imagenEtiqueta = imagen;
        }

        public void setFechaActulizacion(DateTime fechaActual)
        {
            this.fechaActualizacion = fechaActual;
        }
    }
}
