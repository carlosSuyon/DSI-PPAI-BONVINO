namespace PPAI.Entidades
{
    public class Siguiendo
    {
        // atributos
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private Bodega bodega;
        private Enofilo amigo;

        public Bodega Bodega
        {
            get { return bodega; }
            set
            {
                if (amigo != null)
                    throw new InvalidOperationException("La relación con Enofilo ya está establecida.");
                bodega = value;
            }
        }

        public Enofilo Enofilo
        {
            get { return amigo; }
            set
            {
                if (bodega != null)
                    throw new InvalidOperationException("La relación con Bodega ya está establecida.");
                amigo = value;
            }
        }
        //constructor
        public Siguiendo() { }
        public Siguiendo(DateTime fechaInicio, DateTime fechaFin)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }
        // getters and setters 
        public DateTime GetFechaInicio() { return fechaInicio; }
        public DateTime GetFechaFin() { return fechaFin; }

        public void setFechaFin(DateTime nuevaFechaFin) { this.fechaFin = nuevaFechaFin; }
        public void setFechaInicio(DateTime nuevaFechaInicio) { this.fechaInicio = nuevaFechaInicio;}

        // metodos 

        public Boolean sosDeBodega(Bodega bodega) {

            return (bodega != null && bodega.Equals(bodega));
        }

    }
}