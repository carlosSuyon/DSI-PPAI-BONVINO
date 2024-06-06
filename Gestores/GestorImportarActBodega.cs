using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Nodes;
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
        private List<VinosSistemaBodega> vinosImportados;
        private List<VinosSistemaBodega> vinosListoParaActualizar;
        private List<Maridaje> maridajes;
        private List<TipoUva> tiposUva;

        private APISistemaBodega APISistemaBodega;
        private InterfazNotificacionPush interfazNotificacionPush;

        // constructor 
        public GestorImportarActBodega() { }
        public GestorImportarActBodega(PantallaImportadorActBodega pantalla){
            this.bodegas = new List<Bodega>();  
            this.tiposUva = new List<TipoUva>(); 
            this.vinosImportados = new List<VinosSistemaBodega>();
            this.vinosListoParaActualizar = new List<VinosSistemaBodega>();
            this.maridajes = new List<Maridaje>();
            this.enofilosSeguidores = new List<Enofilo>();
            this.pantalla = pantalla;
             

            this.load();
        }
        private void load()
        {
            //Esta clase se utiliza para generar números aleatorios en C#.
            Random random = new Random();
            // Definición de nombres de vinos populares
            string[] nombresVinosPopulares = new string[]
            {
            "Malbec Reserva", "Chardonnay Gran Reserva", "Cabernet Sauvignon", "Merlot Clásico", "Sauvignon Blanc Premium",
            "Syrah Vendimia Seleccionada", "Pinot Noir Joven", "Tannat Roble", "Rosé Brut Nature", "Torrontés Dulce"
            };
            // maridajes randoms
            string[] maridajeDescripciones = {
                "Realza las características de los platos",
                "Combina a la perfección con carnes rojas",
                "Ideal para acompañar platos de pescado",
                "Equilibra los sabores de platos agridulces"
            };
            // Lista de variedades de uva tintas y blancas
            string[] variedadesTintas = { "Merlot", "Syrah", "Cabernet Sauvignon" };
            string[] variedadesBlancas = { "Verdejo", "Godello" };
            //bodegas del sistema - mock-

            //bodega1
            // fechaUltimaActualizacion random
            int año = random.Next(2023, 2025);
            int mes = random.Next(1, 13);
            int dia = random.Next(1, DateTime.DaysInMonth(año, mes));
            DateTime fechaUltimaActualizacion = new DateTime(año, mes, dia);
            Bodega bodega1 = new Bodega("Bodega1", "descripcion1", fechaUltimaActualizacion, 2, "historia de la bodega 1");
            // Vinos para bodega1
            for (int i = 1; i <= 8; i++)
            {
                // Generar datos para el vino
                int yearAñada = random.Next(1950, 2025);
                int yearFecha = random.Next(2020, 2025);
                int month = random.Next(1, 13);
                int day = random.Next(1, DateTime.DaysInMonth(yearFecha, month));
                DateTime fechaAleatoria = new DateTime(yearFecha, month, day);
                int precioAleatorio = random.Next(5000, 100001);

                // Generar descripción de maridaje aleatoria
                string descripcionMaridaje = maridajeDescripciones[random.Next(maridajeDescripciones.Length)];
                string nombreMaridaje = $"Maridaje{i}";
                Maridaje maridaje = new Maridaje(descripcionMaridaje, nombreMaridaje);

                // Generar datos para el varietal
                string nombreVarietal = $"Varietal{i}";
                string descripcionVarietal = $"Vino varietal con predominancia de una variedad de uva";
                int porcentajeComposicion = random.Next(80, 101); // Entre 80% y 100%

                // Elegir una variedad de uva al azar
                string[] variedades;
                if (random.Next(2) == 0)
                {
                    variedades = variedadesTintas;
                }
                else
                {
                    variedades = variedadesBlancas;
                }
                string nombreUva = variedades[random.Next(variedades.Length)];
                string descripcionUva = $"Descripción de la uva {nombreUva}";

                // Crear instancia de TipoUva
                TipoUva tipoUva = new TipoUva(descripcionUva, nombreUva);

                // Crear instancia de Varietal
                Varietal varietal = new Varietal(nombreVarietal, descripcionVarietal, porcentajeComposicion, tipoUva);

                // Crear instancia de Vino con los datos generados
                string nombreVino = nombresVinosPopulares[random.Next(nombresVinosPopulares.Length)];
                Vino vino = new Vino(yearAñada.ToString(), fechaAleatoria, "https://picsum.photos/200/",nombreVino, descripcionMaridaje, precioAleatorio);
                vino.Maridaje.Add(maridaje);
                vino.Varietal.Add(varietal);
                // Establecer fechaActualizacion
                vino.FechaActualizacion = fechaAleatoria;

                // Agregar vino a bodega1
                bodega1.MisVinos.Add(vino);
            }
            this.bodegas.Add(bodega1);

            //bodega2
            // fechaUltimaActualizacion random
            int añob2 = random.Next(2023, 2025);
            int mesb2 = random.Next(1, 13);
            int diab2 = random.Next(1, DateTime.DaysInMonth(añob2, mesb2));
            DateTime fechaUltimaActualizacion2 = new DateTime(añob2, mesb2, diab2);
            Bodega bodega2 = new Bodega("Bodega2", "descripcion2", fechaUltimaActualizacion2, 1, "historia de la bodega 1");
            // Vinos para bodega2
            for (int i = 1; i <= 3; i++)
            {
                // Generar datos para el vino
                int yearAñada = random.Next(1950, 2025);
                int yearFecha = random.Next(2020, 2025);
                int month = random.Next(1, 13);
                int day = random.Next(1, DateTime.DaysInMonth(yearFecha, month));
                DateTime fechaAleatoria = new DateTime(yearFecha, month, day);
                int precioAleatorio = random.Next(5000, 100001);

                // Generar descripción de maridajes aleatorias
                string descripcionMaridaje1 = maridajeDescripciones[random.Next(maridajeDescripciones.Length)];
                string descripcionMaridaje2 = maridajeDescripciones[random.Next(maridajeDescripciones.Length)];
                string nombreMaridaje1 = $"Maridaje{i}_1";
                string nombreMaridaje2 = $"Maridaje{i}_2";
                Maridaje maridaje1 = new Maridaje(descripcionMaridaje1, nombreMaridaje1);
                Maridaje maridaje2 = new Maridaje(descripcionMaridaje2, nombreMaridaje2);

                // Generar datos para el varietal
                string nombreVarietal = $"Varietal{i}";
                string descripcionVarietal = $"Vino varietal con predominancia de una variedad de uva";
                int porcentajeComposicion = random.Next(80, 101); // Entre 80% y 100%

                // Elegir una variedad de uva al azar
                string[] variedades;
                if (random.Next(2) == 0)
                {
                    variedades = variedadesTintas;
                }
                else
                {
                    variedades = variedadesBlancas;
                }
                string nombreUva = variedades[random.Next(variedades.Length)];
                string descripcionUva = $"Descripción de la uva {nombreUva}";

                // Crear instancia de TipoUva
                TipoUva tipoUva = new TipoUva(descripcionUva, nombreUva);

                // Crear instancia de Varietal
                Varietal varietal = new Varietal(nombreVarietal, descripcionVarietal, porcentajeComposicion, tipoUva);

                // Crear instancia de Vino con los datos generados
                string nombreVino = nombresVinosPopulares[random.Next(nombresVinosPopulares.Length)];
                Vino vino = new Vino(yearAñada.ToString(), fechaAleatoria, "https://picsum.photos/200/", nombreVino, $"{descripcionMaridaje1}, {descripcionMaridaje2}", precioAleatorio);
                vino.Varietal.Add(varietal);
                vino.Maridaje.Add(maridaje1);
                vino.Maridaje.Add(maridaje2);

                // Establecer fechaActualizacion
                vino.FechaActualizacion = fechaAleatoria;

                // Agregar vino a bodega2
                bodega2.MisVinos.Add(vino);
            }
            this.bodegas.Add(bodega2);

            //Bodega3
            // fechaUltimaActualizacion random
            int añob3 = random.Next(2024, 2025);
            int mesb3 = random.Next(1, 6);
            int diab3 = random.Next(1, DateTime.DaysInMonth(añob3, mesb3));
            DateTime fechaUltimaActualizacion3 = new DateTime(añob3, mesb3, diab3);
            Bodega bodega3 = new Bodega("Bodega3", "descripcion3",fechaUltimaActualizacion3, 1, "historia de la bodega 1");
            // Vinos para bodega3
            for (int i = 1; i <= 10; i++)
            {
                // Generar datos para el vino
                int yearAñada = random.Next(1950, 2025);
                int yearFecha = random.Next(2020, 2025);
                int month = random.Next(1, 13);
                int day = random.Next(1, DateTime.DaysInMonth(yearFecha, month));
                DateTime fechaAleatoria = new DateTime(yearFecha, month, day);
                int precioAleatorio = random.Next(5000, 100001);

                // Generar descripción de maridajes aleatorias
                string descripcionMaridaje1 = maridajeDescripciones[random.Next(maridajeDescripciones.Length)];
                string descripcionMaridaje2 = maridajeDescripciones[random.Next(maridajeDescripciones.Length)];
                string nombreMaridaje1 = $"Maridaje{i}_1";
                string nombreMaridaje2 = $"Maridaje{i}_2";
                Maridaje maridaje1 = new Maridaje(descripcionMaridaje1, nombreMaridaje1);
                Maridaje maridaje2 = new Maridaje(descripcionMaridaje2, nombreMaridaje2);

                // Generar datos para el varietal
                string nombreVarietal = $"Varietal{i}";
                string descripcionVarietal = $"Vino varietal con predominancia de una variedad de uva";
                int porcentajeComposicion = random.Next(80, 101); // Entre 80% y 100%

                // Elegir una variedad de uva al azar
                string[] variedades;
                if (random.Next(2) == 0)
                {
                    variedades = variedadesTintas;
                }
                else
                {
                    variedades = variedadesBlancas;
                }
                string nombreUva = variedades[random.Next(variedades.Length)];
                string descripcionUva = $"Descripción de la uva {nombreUva}";

                // Crear instancia de TipoUva
                TipoUva tipoUva = new TipoUva(descripcionUva, nombreUva);

                // Crear instancia de Varietal
                Varietal varietal = new Varietal(nombreVarietal, descripcionVarietal, porcentajeComposicion, tipoUva);

                // Crear instancia de Vino con los datos generados
                string nombreVino = nombresVinosPopulares[random.Next(nombresVinosPopulares.Length)];
                Vino vino = new Vino(yearAñada.ToString(), fechaAleatoria, "https://picsum.photos/200/",nombreVino, $"{descripcionMaridaje1}, {descripcionMaridaje2}", precioAleatorio);
                vino.Varietal.Add(varietal);
                vino.Maridaje.Add(maridaje1);
                vino.Maridaje.Add(maridaje2);

                // Establecer fechaActualizacion
                vino.FechaActualizacion = fechaAleatoria;

                // Agregar vino a bodega3
                bodega3.MisVinos.Add(vino);
            }
            this.bodegas.Add(bodega3);

            //Bodega4 
            // fechaUltimaActualizacion random
            int a4 = random.Next(2024, 2025);
            int mes4 = random.Next(1, 6);
            int d4 = random.Next(1, DateTime.DaysInMonth(a4, mes4));
            DateTime fechaUltimaActualizacion4 = new DateTime(a4, mes4, d4);
            Bodega bodega4 = new Bodega("Bodega4", "descripcion4", fechaUltimaActualizacion4, 6, "historia de la bodega 1");
            // Vinos para bodega4
            for (int i = 1; i <= 15; i++)
            {
                // Generar datos para el vino
                int yearAñada = random.Next(1950, 2025);
                int yearFecha = random.Next(2020, 2025);
                int month = random.Next(1, 13);
                int day = random.Next(1, DateTime.DaysInMonth(yearFecha, month));
                DateTime fechaAleatoria = new DateTime(yearFecha, month, day);
                int precioAleatorio = random.Next(5000, 100001);

                string descripcionMaridaje1 = maridajeDescripciones[random.Next(maridajeDescripciones.Length)];
                string descripcionMaridaje2 = maridajeDescripciones[random.Next(maridajeDescripciones.Length)];

                string nombreVino = nombresVinosPopulares[random.Next(nombresVinosPopulares.Length)];

                // Crear instancia de Vino con los datos generados
                Vino vino = new Vino(yearAñada.ToString(), fechaAleatoria, "https://picsum.photos/200/", nombreVino, $"{descripcionMaridaje1}, {descripcionMaridaje2}", precioAleatorio);

                // Establecer fechaActualizacion
                vino.FechaActualizacion = fechaAleatoria;

                // Agregar vino a bodega4
                bodega4.MisVinos.Add(vino);
            }




            // tipoUva - mock -  

            TipoUva tip1 = new TipoUva("Descripcion 1 ", "Merlot");
                this.tiposUva.Add(tip1);
                TipoUva tip2 = new TipoUva("Descripcion2 ", "Syrah");
                this.tiposUva.Add(tip2);
                TipoUva tip3 = new TipoUva("Descripcion 3 ", "Cabernet Sauvignon");
                this.tiposUva.Add(tip3);
                TipoUva tip4 = new TipoUva("Descripcion 4 ", "Verdejo");
                this.tiposUva.Add(tip4);
                TipoUva tip5 = new TipoUva("Descripcion 5 ", "Godello");
                this.tiposUva.Add(tip5);

                // maridajes -mock- 
                Maridaje m1 = new Maridaje("Realza las características de los platos", "Maridaje1");
                this.maridajes.Add(m1);
                Maridaje m2 = new Maridaje("Combina a la perfección con carnes rojas", "Maridaje2");
                this.maridajes.Add(m2);
                Maridaje m3 = new Maridaje("Ideal para acompañar platos de pescado", "Maridaje3");
                this.maridajes.Add(m3);
                Maridaje m4 = new Maridaje("Acentúa los sabores de quesos suaves", "Maridaje4");
                this.maridajes.Add(m4);
                Maridaje m5 = new Maridaje("Equilibra los sabores de platos agridulces", "Maridaje5");
                this.maridajes.Add(m5);
            // todos los enofilos del sistema 
           
            // Crear objetos Enofilo con un usuario asignado de la lista de usuarios
            List<Enofilo> enofilos = new List<Enofilo>();
            for (int i = 0; i < 10; i++)
            {
                string apellido = "Apellido" + (i + 1);
                string imagenPerfil = "imagen" + (i + 1);
                string nombreEnofilo = "Enofilo" + (i + 1);
                for (int j = 0; j < 10; j++)
                {
                    string contraseña = "Contraseña" + (j + 1);
                    string nombreUsuario = "Usuario" + (j + 1);
                    bool premium = (j % 2 == 0); // true para índices pares, false para índices impares
                    Usuario usuario = new Usuario(contraseña, nombreUsuario, premium);
                    Enofilo enofilo = new Enofilo(apellido, imagenPerfil, nombreEnofilo, usuario);
                    enofilos.Add(enofilo);
                }
                
                
            }


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

            foreach (Bodega bodega in this.bodegas)
            {
                if (bodega.esParaActualizar(fechaActual))
                {
                    bodegasParaActualizar.Add(bodega);
                }
            }
            
            return bodegasParaActualizar; 
         }
        public DateTime getFechaActual()
        {
            // tomar la fecha actual
            DateTime x = DateTime.Now.Date;     
            return x;
        }
        public void tomarSelecciónBodega(string bodegaSeleccionada)
        {
            // buscar segun nombre bodega seleccionada y crear el objeto
            foreach (Bodega  b in this.bodegas)
            {
                if (b.Nombre == bodegaSeleccionada)
                {
                    this.bodegaElegida = b;
                }
            }
            obtenerActualizacionesBodega(this.bodegaElegida.Nombre);
        }

        public void obtenerActualizacionesBodega(string nombreBodega)
        {
            //nuestra Interfaz busca los vinos del sistema bodega usando su API
            
            
            this.APISistemaBodega = new APISistemaBodega(nombreBodega);
            this.vinosImportados =  this.APISistemaBodega.ObtenerActualizacionesBodega(nombreBodega);
            this.obtenerVinosAActualizar();
        }
        public void obtenerVinosAActualizar()
        {
            foreach (var v in this.vinosImportados){
                string nombreVinoImportado = "";
                nombreVinoImportado = v.Nombre;
                if (bodegaElegida.tieneVino(nombreVinoImportado))
                {
                    this.vinosListoParaActualizar.Add(v);
                }
            }
            this.crearOActualizarVinos();
        }
        public void crearOActualizarVinos()
        {
            foreach (var v in this.vinosImportados)
            {
                //valida para c/u de los vinos importados si es un vino a actulizar en la bodega seleccionada
                
                if (vinosListoParaActualizar.Contains(v)) //
                {
                     
                    this.actualizarVino(v);
                }
                // este  vino importado no pertenece hasta ahora a la bodega seleccionada,se crea el nuevo vino
                else
                {
                    
                    this.hayQueCrearVino(v);
                }
            }
            this.actualizarFechaActualizacionBodega();
            this.pantalla.mostrarResumenVinosImportados(this.bodegaElegida);
            //this.buscarSeguidoresDeBodega();
        }

         

        public void actualizarVino(VinosSistemaBodega vinoAActualizar) {
            //convertir de  vinoAActualizar  a Vino
            Vino v = new Vino(vinoAActualizar.Añada, vinoAActualizar.FechaActualizacion, vinoAActualizar.ImagenEtiqueta, vinoAActualizar.Nombre, vinoAActualizar.NotaDeCataBodega, vinoAActualizar.PrecioARS);
            this.bodegaElegida.actualizarVino(v);
        }
        public void hayQueCrearVino(VinosSistemaBodega nuevoVino)
        {
            //creo Vino segun los datos que vienen del sistema Bodega
            Vino v = new Vino(nuevoVino.Añada, nuevoVino.FechaActualizacion, nuevoVino.ImagenEtiqueta, nuevoVino.Nombre, nuevoVino.NotaDeCataBodega, nuevoVino.PrecioARS);
            
            // validar si el vino tiene ALGUN maridaje
            List<Maridaje> maridajesParaNuevoVino = new List<Maridaje>();
            if (nuevoVino.Maridajes.Count >0)
            {
                 
                // se debe cargar maridajes con los datos del nuevo vino
                maridajesParaNuevoVino = this.buscarMaridaje(nuevoVino.Maridajes);
            }

            //validar  si el vino tiene ALGUN tipo de uva
            List<TipoUva> tipoUvasParaNuevoVino = new List<TipoUva>();
            if (nuevoVino.TiposUvas.Count >0)
            {
                // se debe cargar tiposDeUva con los datos del del sistema Bodega
               tipoUvasParaNuevoVino = this.buscarTipoUva(nuevoVino.TiposUvas);
            }
            

            this.crearVino(maridajesParaNuevoVino,tipoUvasParaNuevoVino,v);
        }

        public void crearVino(List<Maridaje> maridajes,List<TipoUva>tiposUva,Vino vino)
        {
            Vino nuevoVino = new Vino();
            nuevoVino = vino;
            nuevoVino.Maridaje = maridajes;
            nuevoVino.crearVarietal();
            
        }

        public List<Maridaje> buscarMaridaje(List<Maridaje> maridajes) {
            List<Maridaje> maridajesUtiles = new List<Maridaje>();
            foreach (Maridaje mNuevoVino in maridajes)
            {
                foreach (Maridaje mDelSistema in this.maridajes)
                {
                    if (mDelSistema.sosMaridaje(mNuevoVino.Nombre))
                    {
                        maridajesUtiles.Add(mDelSistema);
                        
                    }   
                }
            }
            return maridajesUtiles;
        }
        public List<TipoUva> buscarTipoUva(List<TipoUva> tiposDeUva){
            List<TipoUva> tipoUvaUtil = new List<TipoUva>();    
            foreach (TipoUva tipo in tiposDeUva)
            {
                foreach (TipoUva tipoUvaSistema in this.tiposUva)
                {
                    if (tipoUvaSistema.esElTipoUva(tipo.Nombre))
                    {
                        tipoUvaUtil.Add(tipoUvaSistema);
                    }
                }
            }
            return tipoUvaUtil;
        }
        public void actualizarFechaActualizacionBodega() {
            this.bodegaElegida.setFechaUltimaActualizacion(this.getFechaActual());
        }
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
            this.interfazNotificacionPush = new InterfazNotificacionPush();
            this.interfazNotificacionPush.notificarNovedadVinoParaBodega(enofilosANotificar);
            this.finCU();
        }             
        public void finCU() {
            MessageBox.Show("Fin CU.");
            //pantalla.Close();
        }

    }
}
