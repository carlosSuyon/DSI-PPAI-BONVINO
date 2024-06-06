using PPAI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Interfaces
{
    public class APISistemaBodega
    {
        private string nombre;
        public APISistemaBodega(string nombre) {
            this.nombre = nombre;
        }
        internal List<VinosSistemaBodega> ObtenerActualizacionesBodega(string nombreBodega)
        {
            //traer los vinos del Sistema de Bodega 
            //fetch o get a un endpoint que me trae una coleccion de vinos segun el nombre de la bodega
            List<VinosSistemaBodega> vinosDeAPI = new List<VinosSistemaBodega>();
            Random random = new Random();

            // Lista de variedades de uva tintas y blancas
            string[] variedadesTintas = { "Merlot", "Syrah", "Cabernet Sauvignon" };
            string[] variedadesBlancas = { "Verdejo", "Godello" };

            // Lista de descripciones de maridajes
            string[] maridajeDescripciones = {
            "Realza las características de los platos",
            "Combina a la perfección con carnes rojas",
            "Ideal para acompañar platos de pescado",
            "Equilibra los sabores de platos agridulces"
            };



            // Datos de ejemplo para cargar en los objetos
            string[] nombres = new string[]
            {
            "Vino Tinto Reserva", "Vino Blanco Seco", "Vino Rosado", "Vino Tinto Joven", "Vino Espumoso Brut",
            "Vino Tinto Reserva Especial", "Vino Dulce", "Vino Tinto Roble", "Vino Tinto Crianza", "Vino Blanco Semidulce"
            };

            string[] notasDeCata = new string[]
            {
            "Frutos rojos intensos, vainilla, suave.", "Notas cítricas, manzana verde, fresco.", "Fresas, florales, ligero y refrescante.",
            "Frutos negros, taninos suaves, fácil de beber.", "Manzana, pera, burbujeante y elegante.", "Frutos maduros, roble, estructurado.",
            "Pasas, miel, untuoso y delicioso.", "Ciruelas, vainilla, suave y equilibrado.", "Frutos rojos, especias, final persistente.",
            "Melocotón, miel, frescura equilibrada."
            };

            // Cargar 10 objetos de la clase VinosSistemaBodega
            for (int i = 1; i <= 10; i++)
            {
                // Generar datos aleatorios para el vino
                string añada = random.Next(1950, 2025).ToString();
                DateTime fechaActualizacion = DateTime.Now.AddDays(-random.Next(1, 365));
                string imagenEtiqueta = "URL de la imagen"; // Puedes proporcionar una URL de imagen o dejarla como un marcador de posición
                string nombre = nombres[random.Next(nombres.Length)];
                string notaDeCataBodega = notasDeCata[random.Next(notasDeCata.Length)];
                int precioARS = random.Next(5000, 100001); // Precio en pesos argentinos

                // Generar descripciones de maridajes aleatorias
                List<Maridaje> maridajes = new List<Maridaje>();

                for (int j = 0; j < 2; j++)
                {
                    string descripcionMaridaje = maridajeDescripciones[random.Next(maridajeDescripciones.Length)];
                    string nombreMaridaje = $"Maridaje{i}_{j + 1}";
                    maridajes[j] = new Maridaje(descripcionMaridaje, nombreMaridaje);
                }

                // Generar datos para el varietal
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
                List<TipoUva> tipoUva = new List<TipoUva>();
                tipoUva.Add(new TipoUva(descripcionUva, nombreUva));


                // Crear instancia de VinosSistemaBodega con los datos generados
                VinosSistemaBodega vino = new VinosSistemaBodega(añada, fechaActualizacion, imagenEtiqueta, nombre, notaDeCataBodega, precioARS);
                vino.Maridajes = maridajes;
                vino.TiposUvas = tipoUva;
                // Establecer fechaActualizacion
                vino.FechaActualizacion = fechaActualizacion;

                // Agregar vino a la lista

                vinosDeAPI.Add(vino);
                MessageBox.Show("Se cargo los vinos");

            }
            return vinosDeAPI;
        }
    }
}
