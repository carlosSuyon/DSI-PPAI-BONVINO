
using System.Windows.Forms;

namespace PPAI.Interfaces
{
    public class InterfazNotificacionEnofilo : IObservadorNovedadesBodegas
    {
        
        private string nombreEnofilo;
        
        
        public InterfazNotificacionEnofilo(string nombreEnofilo){
            this.nombreEnofilo = nombreEnofilo;
           

        }
        //enviarNotificacionPush
        public void Actualizar(List<string> formaNotificacion)
        {
            //MessageBox.Show("Se envio Notificacion Push para : " + nombreEnofilo);
            this.EnviarNotificacion(formaNotificacion);
        }
        public void EnviarNotificacion(List<string> formaNotificacion)
        {
            NotificacionPush.Mostrar(formaNotificacion, nombreEnofilo); // Form para mostrar la notificacion           

        }

    }
}
