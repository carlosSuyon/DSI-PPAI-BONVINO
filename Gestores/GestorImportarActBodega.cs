using PPAI.Entidades;
using PPAI.Interfaces;

namespace PPAI.Gestores
{
    public class GestorImportarActBodega : ISujetoNovedadesVinos
    {
        //atributos
        private PantallaImportadorActBodega pantalla;

        private Bodega bodegaElegida;

        private List<Bodega> bodegas;
        private List<Enofilo> enofilosSeguidores;

        private List<VinosSistemaBodega> vinosImportados;
        private List<VinosSistemaBodega> vinosParaActualizar;

        private List<Maridaje> maridajes;
        private List<TipoUva> tiposUva;

        private APISistemaBodega APISistemaBodega;

        // todos los enofilos/observadores 
        private readonly List<IObservadorNovedadesBodegas> observadoresANotificar = new List<IObservadorNovedadesBodegas>();

        List<string> vinosAActualizar = new List<string>();
        List<string> vinosNuevos = new List<string>();
        // constructor 

        public GestorImportarActBodega(PantallaImportadorActBodega pantalla)
        {

            this.bodegas = new List<Bodega>();
            this.tiposUva = new List<TipoUva>();
            this.vinosImportados = new List<VinosSistemaBodega>();
            this.vinosParaActualizar = new List<VinosSistemaBodega>();
            this.maridajes = new List<Maridaje>();
            //todos los enofilos - usuarios del sistema de bonvino
            this.enofilosSeguidores = new List<Enofilo>();
           
            this.pantalla = pantalla;

            //crea y carga los objetos necesarios para ejecutar el cu.
            this.load();


        }
        private void load()
        {

            //Esta clase se utiliza para generar números aleatorios en C#.
            Random random = new Random();

            List<Vino> vinosDelSistema = new List<Vino>();

            // string necesarios para crear mis objetos
            string[] variedadesTintas = new string[]
            {
                "Merlot",
                "Syrah",
                "Cabernet Sauvignon",
                "Pinot Noir",
                "Malbec",
                "Tempranillo",
                "Zinfandel",
                "Grenache",
                "Nebbiolo",
                "Sangiovese",
                "Barbera",
            };
            string[] variedadesBlancas = new string[]
            {
                "Verdejo",
                "Godello",
                "Chardonnay",
                "Sauvignon Blanc",
                "Riesling",
                "Pinot Grigio",
                "Chenin Blanc",
                "Gewürztraminer",
                "Viognier",
                "Albariño"
            };
            string[] maridajeDescripciones = new string[]
            {
                "Realza las características de los platos",
                "Combina a la perfección con carnes rojas",
                "Ideal para acompañar platos de pescado",
                "Equilibra los sabores de platos agridulces",
                "Perfecto para maridar con quesos fuertes",
                "Excelente con pastas en salsas cremosas",
                "Complementa bien con ensaladas frescas",
                "Realza los sabores de platos picantes",
                "Marida perfectamente con mariscos",
                "Ideal para acompañar aves de corral",
                "Combina bien con platos vegetarianos",
                "Equilibra los sabores de platos grasos",
                "Perfecto para acompañar sushi",
                "Excelente con postres de chocolate",
                "Marida bien con platos de cerdo",
                "Ideal para acompañar tapas y aperitivos",
                "Realza los sabores de comidas mediterráneas",
                "Combina bien con platos ahumados",
                "Perfecto para acompañar guisos y estofados",
                "Marida bien con pizzas y platos italianos"
            };
            string[] nombres =
            {
              "Juan", "Carlos", "Martín", "Pedro", "Lucas",
                "Javier", "Miguel", "Diego", "Gonzalo", "Agustín",
                "María", "Laura", "Ana", "Sofía", "Valentina",
                "Elena", "Camila", "Julieta", "Abril", "Florencia"
            };
            string[] apellidos = new string[]
            {
                "García", "Martínez", "Rodríguez", "López", "González", "Hernández", "Pérez", "Sánchez", "Ramírez", "Torres",
                "Flores", "Rivera", "Gómez", "Diaz", "Cruz", "Reyes", "Morales", "Ortiz", "Gutiérrez", "Chávez",
                "Ramos", "Romero", "Vargas", "Ruiz", "Castillo", "Fernández", "Jiménez", "Mendoza", "Iglesias", "Silva",
                "Soto", "Delgado", "Ortiz", "Ramos", "Guerrero", "Molina", "Castro", "Suárez", "Domínguez", "Alvarez",
                "Vega", "Paredes", "Rojas", "Campos", "Mejía", "Herrera", "Aguilar", "Santos", "Montes", "Peña"
            };
            string[] nombresVinosPopulares = new string[]
            {
                "Malbec Reserva",
                "Chardonnay Gran Reserva",
                "Cabernet Sauvignon",
                "Merlot Clásico",
                "Sauvignon Blanc Premium",
                "Syrah Vendimia Seleccionada",
                "Pinot Noir Joven",
                "Tannat Roble",
                "Rosé Brut Nature",
                "Torrontés Dulce",
                "Riesling Seco",
                "Tempranillo Crianza",
                "Zinfandel Old Vine",
                "Grenache Blanc",
                "Viognier Prestige",
                "Petite Sirah Reserva",
                "Carmenere Especial",
                "Garnacha Joven",
                "Verdejo Superior",
                "Barbera d'Asti",
                "Nebbiolo Langhe",
                "Sangiovese Classico",
                "Albariño Rías Baixas",
                "Grüner Veltliner",
                "Cava Brut Reserva",
                "Champagne Brut Rosé",
                "Prosecco Superiore",
                "Moscato d'Asti",
                "Chianti Riserva",
                "Pinot Grigio delle Venezie"
            };
            string[] nombreBodegas = new string[]
            {
                "Catena Zapata",
                "Bodega Norton",
                "Trapiche",
                "Bodegas Salentein",
                "Bodega Luigi Bosca",
                "Bodega El Esteco",
                "Bodega Colomé",
                "Bodega Zuccardi",
                "Bodega La Rural",
                "Bodega Vistalba",
                "Bodega Familia Schroeder",

            };

            // Tipos de Uva del sistema

            for (int i = 1; i <= variedadesTintas.Length; i++)
            {
                string nombre = variedadesTintas[i - 1];
                string descripcion = "Descripcion uva(Tinta) :" + nombre;
                TipoUva tip = new TipoUva(descripcion, nombre);
                this.tiposUva.Add(tip);
            }
            for (int i = 1; i < variedadesBlancas.Length; i++)
            {
                string nombre = variedadesBlancas[i - 1];
                string descripcion = "Descripción uva(Blanca): " + nombre;
                TipoUva tip = new TipoUva(descripcion, nombre);
                this.tiposUva.Add(tip);
            }

            // Maridajes del sistema
            for (int i = 1; i <= maridajeDescripciones.Length; i++)
            {
                string descripcion = maridajeDescripciones[i - 1];
                string nombre = "Maridaje" + (i - 1);
                Maridaje maridaje = new Maridaje(descripcion, nombre);
                this.maridajes.Add(maridaje);
            }

            // Bodegas del sistema
            for (int b = 1; b <= (nombreBodegas.Length); b++)
            {
                // nombre
                string nombreBodega = nombreBodegas[b - 1];

                // fechaUltimaActualizacion random
                int año = random.Next(2023, 2025);
                int mes = random.Next(1, 13);
                int dia = random.Next(1, DateTime.DaysInMonth(año, mes));
                DateTime fechaUltimaActualizacion = new DateTime(año, mes, dia);

                // periodo de actualizacion
                int periodo = random.Next(1, 13);

                // Crear instancia de Bodega con los datos generados
                Bodega bodega = new Bodega(nombreBodega, "descripcion" + b, fechaUltimaActualizacion, periodo, "historia de la bodega" + b);
                // Agregar la bodega a la lista de bodegas
                this.bodegas.Add(bodega);
            }

            //Vinos

            for (int i = 1; i <= (nombresVinosPopulares.Count() - 1); i++)
            {
                // Generar datos para el vino
                int añoAñada = random.Next(1950, 2025);

                int añoFAleatoria = random.Next(2022, 2025);
                int mesFAleatoria = random.Next(1, 7);
                int diaFAleatoria = random.Next(1, DateTime.DaysInMonth(añoFAleatoria, mesFAleatoria));
                DateTime fechaActualizacion = new DateTime(añoFAleatoria, mesFAleatoria, diaFAleatoria);

                int precioAleatorio = random.Next(1000, 100001);

                string notaDeCata = "";

                // Maridajes
                List<Maridaje> maridajeVino = new List<Maridaje>();
                int nroM = random.Next(1, 6);
                for (int z = 0; z < nroM; z++)
                {
                    maridajeVino.Add(this.maridajes[random.Next(nroM)]);
                }

                // Varietales
                List<Varietal> varietalesVino = new List<Varietal>();
                int nroV = random.Next(1, 6); // nro al azar entre 1 y 5, pq tengo 5 tiposUva en el sistema
                for (int z = 0; z < nroV; z++)
                {
                    string nombreVarietal = $"Varietal : {z}";
                    string descripcionVarietal = $"Vino varietal con predominancia de una variedad de uva";
                    int porcentajeComposicion = random.Next(80, 101); // Entre 80% y 100%
                    Varietal v = new Varietal(nombreVarietal, descripcionVarietal, porcentajeComposicion, this.tiposUva[random.Next(nroV)]);
                    varietalesVino.Add(v);
                }

                //Bodega para el vino
                var indiceAleatorio = random.Next(0, this.bodegas.Count());
                var bodegaAleatoria = this.bodegas[indiceAleatorio];

                // Crear instancia de Vino con los datos generados
                string nombreVino = nombresVinosPopulares[i - 1];
                string linkImg = "https://picsum.photos/" + i;

                Vino vino = new Vino(añoAñada.ToString(), fechaActualizacion, linkImg, nombreVino, notaDeCata, precioAleatorio, bodegaAleatoria);
                vino.Maridaje = maridajeVino;
                vino.Varietal = varietalesVino;

                // se carga a la bodega el vino en cuestion
                bodegaAleatoria.MisVinos.Add(vino);
                vinosDelSistema.Add(vino);
                //this.vinosDelSistema.Add(vino);
            }
            // Enofilos del sistema

            for (int i = 1; i <= 15; i++)
            {
                string nombreEnofilo = nombres[random.Next(nombres.Length)];
                string apellidoEnofilo = apellidos[random.Next(apellidos.Length)];
                string linkImgPerfil = "https://example.com/images/" + i;
                string password = "password" + i;
                bool activo = i % 2 == 0; // Alternar entre true y false

                Usuario usuario = new Usuario(password, nombreEnofilo, activo);
                Enofilo enofilo = new Enofilo(apellidoEnofilo, linkImgPerfil, nombreEnofilo, usuario);

                // Vinos favoritos del Enofilo
                for (int j = 0; j <= random.Next(vinosDelSistema.Count); j++)
                {
                    if (enofilo.Favorito == null)
                    {
                        enofilo.Favorito = new List<Vino>();
                    }
                    enofilo.Favorito.Add(vinosDelSistema[j]);
                }

                // Seguidos del enofilo y cada seguido conoce una bodega o un enofilo
                List<Siguiendo> seguidos = new List<Siguiendo>();

                int cantidadSeguidos = random.Next(1, 6);
                for (int k = 1; k <= cantidadSeguidos; k++)
                {
                    DateTime fechaInicio = DateTime.Now.AddDays(random.Next(1, 365));
                    DateTime fechaFin = DateTime.Now.AddDays(random.Next(1, 365));

                    Siguiendo siguiendo = new Siguiendo(fechaInicio, fechaFin);

                    if (random.Next(2) == 0) // 50% probabilidad de seguir una bodega
                    {
                        siguiendo.Bodega = this.bodegas[random.Next(this.bodegas.Count)];
                    }
                    else // 50% probabilidad de seguir un enófilo
                    {
                        if (this.enofilosSeguidores.Count > 0)
                        {
                            siguiendo.Enofilo = this.enofilosSeguidores[random.Next(this.enofilosSeguidores.Count)];
                        }
                        else { siguiendo.Bodega = this.bodegas[random.Next(this.bodegas.Count)]; }

                    }
                    seguidos.Add(siguiendo);
                }
                enofilo.Seguido = seguidos;
                
                this.enofilosSeguidores.Add(enofilo);


            }
        }

        //metodos del gestor 
        public void importarActVinosBodega()
        {
            //Busca y muestra todas las bodegas que tienen actualizaciones disponibles
            List<string> bodegasConActualizacion = new List<string>();
            bodegasConActualizacion = (this.buscarBodegas());

            // muestra en la grilla las bodegas (string) en una grilla
            pantalla.mostrarBodegas(bodegasConActualizacion);
        }

        public List<string> buscarBodegas()
        {
            List<string> bodegasParaActualizar = new List<string>();

            DateTime fechaActual = this.getFechaActual();

            foreach (Bodega bodega in this.bodegas)
            {
                if (bodega.esParaActualizar(fechaActual))
                {
                    bodegasParaActualizar.Add(bodega.Nombre);
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

        //metodo hook con el analisis de diseño 
        public void tomarSelecciónBodega(string bodegaSeleccionada)
        {
            // buscar segun nombre de bodega seleccionada y selecciona el objeto
            foreach (Bodega b in this.bodegas)
            {
                if (b.Nombre == bodegaSeleccionada)
                {
                    this.bodegaElegida = b;
                }
            }

            this.obtenerActualizacionesBodega(this.bodegaElegida.Nombre);
            //metodo para crear un observador concreto para cada enofilo que sigue a la bodega seleccionada,ademas lo suscribo
            this.crearYSuscribirObservadores();
            this.crearOActualizarVinos();
        }
        public void crearYSuscribirObservadores()
        {
            // Busco los enofilos de mi sistema que sean seguidores de mi bodega seleccionada y los suscribo(metodo polimorfico) a mi sujeto(this)

            foreach (Enofilo enofilo in this.enofilosSeguidores)
            {
                if (enofilo.sosSeguidorBodega(this.bodegaElegida))
                {
                    //creo la InterfazNotificacionEnofilo (observador concreto )
                    InterfazNotificacionEnofilo interfaz = new InterfazNotificacionEnofilo(enofilo.Nombre +" "+ enofilo.Apellido);

                    // suscribo InterfazNotificacionEnofilo 
                    this.suscribir(interfaz);
                }
                else
                {
                    // el enofilo no es seguidor de la bodega 

                }
            }
        }
        public void obtenerActualizacionesBodega(string nombreBodega)
        {
            //nuestra Interfaz busca los vinos del sistema bodega usando su API
            this.APISistemaBodega = new APISistemaBodega(nombreBodega);
            this.vinosImportados = this.APISistemaBodega.ObtenerActualizacionesBodega(nombreBodega);
            this.obtenerVinosAActualizar();
        }
        public void obtenerVinosAActualizar()
        {
            foreach (var v in this.vinosImportados)
            {
                string nombreVinoImportado = v.Nombre;
                if (bodegaElegida.tieneVino(nombreVinoImportado))
                {
                    this.vinosParaActualizar.Add(v);
                }
            }
        }

        // se produce un cambio de estado en terminos de que hay vinos nuevos o actualizados
        public void crearOActualizarVinos()
        {
            MessageBox.Show("Cant de Vinos antes de realizar la Importacion :  " + this.bodegaElegida.MisVinos.Count.ToString());

            MessageBox.Show("Cant de Vinos Importados " + this.vinosImportados.Count.ToString());
            foreach (var v in this.vinosImportados)
            {
                //valida para c/u de los vinos importados si es un vino para actualizar o para crear  en la bodega seleccionada

                if (vinosParaActualizar.Contains(v)) // este vino importado pertenece a la bodega,se actualiza sus parametros
                {
                    this.actualizarVino(v);
                    vinosAActualizar.Add(v.Nombre);
                }
                else // este  vino importado no pertenece hasta ahora a la bodega,se crea el nuevo vino
                {
                    this.hayQueCrearVino(v);
                    vinosNuevos.Add(v.Nombre);
                }
            }

            MessageBox.Show("Cant de Vinos post Importacion: " + this.bodegaElegida.MisVinos.Count.ToString());
            this.actualizarFechaActualizacionBodega();
            this.pantalla.mostrarResumenVinosImportados(this.bodegaElegida.Nombre, this.bodegaElegida.MisVinos);


            //Deberia tener un nombre mas representativo de la logica solicitada,por ej: notificarSeguidoresDeBodega()
            this.notificarSeguidoresDeBodega(); //this.buscarSeguidoresDeBodega();
             
        }

        public void actualizarVino(VinosSistemaBodega vinoAActualizar)
        {
            //convertir de  vinoAActualizar  a Vino

            DateTime fecha = vinoAActualizar.FechaActualizacion;
            string img = vinoAActualizar.ImagenEtiqueta;
            string nombre = vinoAActualizar.Nombre;
            string nota = vinoAActualizar.NotaDeCataBodega;
            int precio = vinoAActualizar.PrecioARS;
            this.bodegaElegida.actualizarVino(nombre, precio, nota, img, fecha);
        }
        public void hayQueCrearVino(VinosSistemaBodega nuevoVino)
        {
            // validar si el vino importado tiene ALGUN maridaje
            List<Maridaje> maridajesParaNuevoVino = new List<Maridaje>();
            if (nuevoVino.Maridajes.Count > 0)
            {
                maridajesParaNuevoVino = this.buscarMaridaje(nuevoVino.Maridajes);
            }

            //validar  si el vino tiene ALGUN tipo de uva
            List<TipoUva> tipoUvasParaNuevoVino = new List<TipoUva>();
            if (nuevoVino.Varietales.Count > 0)
            {
                tipoUvasParaNuevoVino = this.buscarTipoUva(nuevoVino.Varietales);
            }
            string añada = nuevoVino.Añada;
            DateTime fecha = nuevoVino.FechaActualizacion;
            string img = nuevoVino.ImagenEtiqueta;
            string nombre = nuevoVino.Nombre;
            string nota = nuevoVino.NotaDeCataBodega;
            int precio = nuevoVino.PrecioARS;
            Bodega bodega = this.bodegaElegida;
            this.crearVino(añada, fecha, img, nombre, nota, precio, maridajesParaNuevoVino, tipoUvasParaNuevoVino, nuevoVino.Varietales, bodega);
        }

        public void crearVino(string añada, DateTime fecha, string img, string nombre, string nota, int precio, List<Maridaje> maridajesParaNuevoVino, List<TipoUva> tipoUvasParaNuevoVino, List<string[]> varietales, Bodega b)
        {
            Vino nuevoVino = new Vino(añada, fecha, img, nombre, nota, precio, b);
            nuevoVino.Maridaje = maridajes;
            nuevoVino.crearVarietal(varietales, tipoUvasParaNuevoVino);
            b.MisVinos.Add(nuevoVino);
        }

        public List<Maridaje> buscarMaridaje(List<string> maridajesVinoNuevo)
        {

            List<Maridaje> maridajesUtiles = new List<Maridaje>();
            foreach (var mNuevoVino in maridajesVinoNuevo)
            {
                foreach (Maridaje mDelSistema in this.maridajes)
                {
                    if (mDelSistema.esElMaridaje(mNuevoVino))
                    {
                        maridajesUtiles.Add(mDelSistema);
                    }
                }
            }
            return maridajesUtiles;
        }
        public List<TipoUva> buscarTipoUva(List<string[]> varietalesNuevoVino)
        {
            List<TipoUva> tiposUvaUtil = new List<TipoUva>();

            foreach (string[] varietal in varietalesNuevoVino)
            {
                for (int i = 1; i < this.tiposUva.Count; i++)
                {
                    if (this.tiposUva[i - 1].esElTipoUva(varietal[3]))
                    {
                        tiposUvaUtil.Add(tiposUva[i - 1]);
                    }
                }
            }
            return tiposUvaUtil;
        }
        public void actualizarFechaActualizacionBodega()
        {
            this.bodegaElegida.setFechaUltimaActualizacion(this.getFechaActual());
        }
        public void notificarSeguidoresDeBodega() // paso 7 
        {

            this.notificar(); //metodo polimorfico
            this.finCU();
        }


        public void finCU()
        {
            MessageBox.Show("Fin CU.");
            //pantalla.Close();
        }

        public void  notificar(){
           
            MessageBox.Show("Se notificara a " + observadoresANotificar.Count.ToString() + "  enofilos suscriptos ") ;
            
            foreach (var o in observadoresANotificar)
                {

                    string nbn = "Novedad en la bodega :  " + bodegaElegida.Nombre;
                    string fecha = DateTime.Now.ToString();
                    string titulo = "Novedades en los vinos : ";

                    // Convertir lista de vinos con novedades a cadena
                    string nombresVinosConNovedad = string.Join(", ", vinosAActualizar.Select(v => v));

                    // Convertir array de nombres de vinos nuevos a cadena
                    string nombresNuevosVinos = (vinosNuevos != null && vinosNuevos.Count > 0) ?
                    string.Join(", ", vinosNuevos) : "Ningún vino nuevo.";
                    // Crear la lista de strings
                    List<string> novedad = new List<string>
                    {
                                nbn,  // Nombre en la bodega
                                "Fecha: " + fecha,  // Fecha de la notificación
                                titulo + "[" + nombresVinosConNovedad + "]",  // Novedades en los vinos
                                "Nuevos vinos disponibles: [" + nombresNuevosVinos + "]"  // Nuevos vinos disponibles
                    };

                    o.Actualizar(novedad); //metodo polimorfico 
                    //mostrar form con la notificaciones hechas
                }
        }

        public void quitar(IObservadorNovedadesBodegas observadorNovedadesBodegas)
        {
            if (observadoresANotificar.Contains(observadorNovedadesBodegas))
            {
                observadoresANotificar.Remove(observadorNovedadesBodegas);
            }
            else
            {
                throw new Exception("El enofilo no es un observer de la Bodega");
            }
        }

        public void suscribir(IObservadorNovedadesBodegas observadorNovedadesBodegas)
        {
            // Verifica que el enofilo ya no sea un observador suscripto,en tal caso los suscribe.

            if (!observadoresANotificar.Contains(observadorNovedadesBodegas))
            {
                observadoresANotificar.Add(observadorNovedadesBodegas);
            }
            else
            {
                MessageBox.Show("El enofilo ya esta suscrito a las novedades de la bodega.");
            }
        }

        //
        public void limpiarObserver()
        {
            observadoresANotificar.Clear();
            vinosAActualizar.Clear();
            vinosNuevos.Clear();
        }
    }
}
