using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Interfaces
{
    public class InterfazNotificacionPush
    {
        public void notificarNovedadVinoParaBodega(List<string> nombreDeEnofilosANotificar)
        {
            MessageBox.Show("Se notifico a los enofilos ");
        }
    }
}
