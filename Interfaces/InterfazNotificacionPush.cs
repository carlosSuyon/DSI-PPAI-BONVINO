using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI.Interfaces
{
    public class InterfazNotificacionPush
    {
        public void notificarNovedadVinoParaBodega(List<string> nombreDeEnofilosANotificar)
        {
            foreach (var enofilo in nombreDeEnofilosANotificar)
            {
               MessageBox.Show($"Enviando notificación a {enofilo}");
            }
            MessageBox.Show("Se notifico a los enofilos ");
        }
    }
}
