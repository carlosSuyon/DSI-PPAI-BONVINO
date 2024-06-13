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
        public void notificarNovedadVinoParaBodega(string nombreDeEnofilosANotificar)
        {

            MessageBox.Show("Se notifico al enofilo "+ nombreDeEnofilosANotificar);
        }
    }
}
