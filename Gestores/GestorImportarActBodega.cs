using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PPAI.Entidades;
using PPAI.Interfaces;

namespace PPAI.Gestores
{
    public class GestorImportarActBodega
    {
        //atributos
        private PantallaImportadorActBodega pantalla;
        private Bodega bodegaElegida;
        private List<Bodega> bodegas;
        private List<Enofilo> enofilosSeguidores;
        private List<string> enofilosANotificar;
        private List<Vino> vinosImportados;
        private List<Vino> vinosListoParaActualizar;
        private List<Maridaje> maridajes;
        private List<TipoUva> tiposUva;

        private InterfazAPIBodega interfazAPIBodega;
        private InterfazNotificacionPush interfazNotificacionPush;

        // constructor 
        public GestorImportarActBodega() { }
        public GestorImportarActBodega(PantallaImportadorActBodega pantalla){
            this.bodegas = new List<Bodega>();  
            this.tiposUva = new List<TipoUva>(); 
            this.vinosImportados = new List<Vino>();
            this.vinosListoParaActualizar = new List<Vino>();   
            this.load();
            this.pantalla = pantalla;
        }
        private void load()
        {
            
            //bodegas del sistema - mock-
            Bodega bodega1 = new Bodega("Bodega1", "descripcion1", DateTime.Now, "40 dias", "historia de la bodega 1");
            this.bodegas.Add(bodega1);
            Bodega bodega2 = new Bodega("Bodega2", "descripcion2", DateTime.Now, "5 dias", "historia de la bodega 1");
            this.bodegas.Add(bodega2);
            Bodega bodega3 = new Bodega("Bodega3", "descripcion3", DateTime.Now, "22 dias", "historia de la bodega 1");
            this.bodegas.Add(bodega3);
            Bodega bodega4 = new Bodega("Bodega4", "descripcion4", DateTime.Now, "10 dias", "historia de la bodega 1");
            this.bodegas.Add(bodega4);


            // -tipoUva- mock 
            
            TipoUva tip1 = new TipoUva("Descripcion 1 ", "Nombre1");
            this.tiposUva.Add(tip1);
            TipoUva tip2 = new TipoUva("Descripcion2 ", "Nombre2");
            this.tiposUva.Add(tip2);
            TipoUva tip3 = new TipoUva("Descripcion 3 ", "Nombre3");
            this.tiposUva.Add(tip3);
            TipoUva tip4 = new TipoUva("Descripcion 4 ", "Nombre4");
            this.tiposUva.Add(tip4);
            TipoUva tip5 = new TipoUva("Descripcion 5 ", "Nombre5");
            this.tiposUva.Add(tip5);

            // todos los enofilos del sistema 
            /*
            Enofilo e1 = new Enofilo("Perez", "direccion a donde esta guardada la imagen perfil", "Juan");
            this.enofilosSeguidores.Add(e1);
            Enofilo e2 = new Enofilo("Calamaro", "direccion a donde esta guardada la imagen perfil", "Andres");
            this.enofilosSeguidores.Add(e2);
            Enofilo e3 = new Enofilo("", "direccion a donde esta guardada la imagen perfil", "Ciro");
            this.enofilosSeguidores.Add(e3);
            Enofilo e4 = new Enofilo("Cantillo", "direccion a donde esta guardada la imagen perfil", "Fabiana");
            this.enofilosSeguidores.Add(e4);
            Enofilo e5 = new Enofilo("Paez", "direccion a donde esta guardada la imagen perfil", "Fito");
            this.enofilosSeguidores.Add(e5);
            Enofilo e6 = new Enofilo("Dargelos", "direccion a donde esta guardada la imagen perfil", "Adrian");
            this.enofilosSeguidores.Add(e6);
            //faltan agregar 6 enofilos mas,asi cada una de las cuatro bodegas tiene 3 enofilos seguidores
            */
        }

        //metodos 

        public void importarActVinosBodega()
        {
            //Busca y muestra todas las bodegas que tienen actualizaciones disponibles
            List<Bodega> bodegasConActualizacion = new List<Bodega>();
            bodegasConActualizacion = (this.buscarBodegas());

            // muestra en la grilla la bodegas (string) en una grilla
            pantalla.mostrarBodegas(bodegasConActualizacion);            
        }

         public List<Bodega> buscarBodegas()
         {
            List<Bodega> bodegasParaActualizar = new List<Bodega>();

            DateTime fechaActual = this.getFechaActual();

            /* foreach (Bodega bodega in this.bodegas)
            {
                if (bodega.esParaActualizar(fechaActual))
                {
                    bodegasParaActualizar.Add(bodega.getNombre());
                }
            }*/
            bodegasParaActualizar = this.bodegas;
            return bodegasParaActualizar; 
         }
        public DateTime getFechaActual()
        {
            // tomar la fecha actual
            DateTime x = DateTime.Now.Date;
            //MessageBox.Show(x.ToShortDateString());
            return x;
        }
        public void tomarSelecciónBodega(string bodegaSeleccionada)
        {
            // buscar segun nombre bodega seleccionada y crear el objeto
            foreach (Bodega  b in this.bodegas)
            {
                if (bodegaSeleccionada == b.Nombre)
                {
                    this.bodegaElegida = b;
                }
            }
        }

        public void obtenerActualizacionesBodega()
        {
            //buscar los vinos del sistema bodega,usando la API
            this.vinosImportados =  this.interfazAPIBodega.obtenerActualizacionesBodega();
            this.obtenerVinosAActualizar();
        }
        public void obtenerVinosAActualizar()
        {
            foreach (Vino v in this.vinosImportados)
            {
                if (bodegaElegida.tieneVino(v))
                {
                    this.vinosListoParaActualizar.Add(v);
                }
            }

        }
        public void crearOActualizarVinos()
        {
            foreach (Vino v in this.vinosImportados)
            {
                //valida para c/u de los vinos importados es un vino a actulizar en la bodega seleccionada
                if (vinosListoParaActualizar.Contains(v))
                {
                    this.actualizarVino(v);
                }
            }
        }
        public void actualizarVino(Vino v) {

            this.bodegaElegida.actualizarVino(v);
        }

        public void hayQueCrearVino() { }

        public void buscarMaridaje() { }
        public void buscarTipoUva() { }
        public void crearVino() { }

        
        public void actualizarFechaActualizacionBodega() { }
        public void buscarSeguidoresDeBodega()
        {
            foreach (Enofilo enofilo in this.enofilosSeguidores)
            {
                if (enofilo.sosSeguidorBodega(this.bodegaElegida))
                {
                    // corregir en el diagrama de secuencia el metodo *notificarNovedadVinoParaBodega(), no lleva asterisco
                    enofilosANotificar.Add(enofilo.getNombreUsuario());
                }
            }

            this.interfazNotificacionPush.notificarNovedadVinoParaBodega(enofilosANotificar);
        }             
        public void finCU() {
            MessageBox.Show("Fin CU.");
            pantalla.Close();
        }

    }
}
