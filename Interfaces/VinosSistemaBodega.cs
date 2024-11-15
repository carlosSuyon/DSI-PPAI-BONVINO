﻿namespace PPAI.Interfaces
{
    public class VinosSistemaBodega
    {
        private string añada;
        private DateTime fechaActualizacion;
        private string imagenEtiqueta;
        private string nombre;
        private string notaDeCataBodega;
        private int precioARS;

        private List<string> maridajes;

        private List<string[]> varietales;

        public VinosSistemaBodega(string añada, DateTime fechaActualizacion, string imagenEtiqueta, string nombre, string notaDeCataBodega, int precioARS)
        {
            this.añada = añada;
            this.fechaActualizacion = fechaActualizacion;
            this.imagenEtiqueta = imagenEtiqueta;
            this.nombre = nombre;
            this.notaDeCataBodega = notaDeCataBodega;
            this.precioARS = precioARS;
            this.maridajes = new List<string>();
            this.varietales = new List<string[]>();

        }

        public DateTime FechaActualizacion { get => fechaActualizacion; set => fechaActualizacion = value; }
        public List<string> Maridajes { get => maridajes; set => maridajes = value; }
        //public List<TipoUva> TiposUvas { get => tiposUvas; set => tiposUvas = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Añada { get => añada; set => añada = value; }
        public string ImagenEtiqueta { get => imagenEtiqueta; set => imagenEtiqueta = value; }
        public string Nombre1 { get => nombre; set => nombre = value; }
        public string NotaDeCataBodega { get => notaDeCataBodega; set => notaDeCataBodega = value; }
        public int PrecioARS { get => precioARS; set => precioARS = value; }
        public List<string[]> Varietales { get => varietales; set => varietales = value; }

    }
}
