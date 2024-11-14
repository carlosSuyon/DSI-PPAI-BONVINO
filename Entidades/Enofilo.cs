using PPAI.Interfaces;

namespace PPAI.Entidades
{
    public class Enofilo 
    {
        //atributos
        private string apellido;
        private string imagenPerfil;
        private string nombre;

        private Usuario usuario;

        private List<Vino> favorito;
        private List<Siguiendo> seguido;

        // getters and setters
        public string Apellido { get => apellido; set => apellido = value; }
        public string ImagenPerfil { get => imagenPerfil; set => imagenPerfil = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Vino> Favorito { get => favorito; set => favorito = value; }
        public List<Siguiendo> Seguido { get => seguido; set => seguido = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }

        //constructor
        public Enofilo(string apellido, string imagenPerfil, string nombre, Usuario usu)
        {
            this.Apellido = apellido;
            this.ImagenPerfil = imagenPerfil;
            this.Nombre = nombre;
            this.usuario = usu;
            this.Seguido = new List<Siguiendo>();
        }
        //metodos
        public Boolean sosSeguidorBodega(Bodega bodega)
        {
            foreach (Siguiendo s in this.Seguido)
            {
                if (s.sosDeBodega(bodega))
                {

                    return true;
                }
            }
            return false;

        }

        public string getNombreUsuario()
        {
            return this.Usuario.getNombre();
        }

        //Metodo polimorfico - interfaz 

        public void Actualizar(List<string> formaNotificacion)
        {
             
        }
    }
}
