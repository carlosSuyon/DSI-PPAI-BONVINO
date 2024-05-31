namespace PPAI.Entidades
{
    public class Siguiendo
    {
        // atributos
        private DateTime fechaInicio;
        private DateTime fechaFin;

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
            // me falta buscar como programar las relaciones ME
            return false;
        }

    }
}