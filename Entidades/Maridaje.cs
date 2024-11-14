namespace PPAI.Entidades
{
    public class Maridaje
    {
        private string descripcion;
        private string nombre;

        public Maridaje(string descripcion, string nombre)
        {
            this.descripcion = descripcion; this.nombre = nombre;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Boolean esElMaridaje(string maridaje)
        {
            if (this.nombre == maridaje)
            {
                return true;
            }
            return false;
        }
    }
}
