namespace PPAI.Entidades
{
    public class Usuario
    {
        private string contraseña;
        private string nombre;
        private bool premium;

        public Usuario(string contraseña, string nombre, bool premium)
        {
            this.contraseña = contraseña;
            this.nombre = nombre;
            this.premium = premium;
        }
        public string getNombre() {  return nombre; }   
    }

}