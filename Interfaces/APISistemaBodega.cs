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
            // Datos de ejemplo
            string[] variedadesTintas = { "Merlot", "Syrah", "Cabernet Sauvignon" };
            string[] variedadesBlancas = { "Verdejo", "Godello" };
            string[] maridajeDescripciones = {
            "Realza las características de los platos",
            "Combina a la perfección con carnes rojas",
            "Ideal para acompañar platos de pescado",
            "Equilibra los sabores de platos agridulces"
        };
            string[] nombres = {
            "Vino Tinto Reserva", "Vino Blanco Seco", "Vino Rosado", "Vino Tinto Joven", "Vino Espumoso Brut",
            "Vino Tinto Reserva Especial", "Vino Dulce", "Vino Tinto Roble", "Vino Tinto Crianza", "Vino Blanco Semidulce"
        };
            string[] notasDeCata = {
            "Frutos rojos intensos, vainilla, suave.", "Notas cítricas, manzana verde, fresco.", "Fresas, florales, ligero y refrescante.",
            "Frutos negros, taninos suaves, fácil de beber.", "Manzana, pera, burbujeante y elegante.", "Frutos maduros, roble, estructurado.",
            "Pasas, miel, untuoso y delicioso.", "Ciruelas, vainilla, suave y equilibrado.", "Frutos rojos, especias, final persistente.",
            "Melocotón, miel, frescura equilibrada."
        };

            Random rand = new Random();
            List<VinosSistemaBodega> vinos = new List<VinosSistemaBodega>();

            for (int i = 0; i < 10; i++)
            {
                string añada = $"20{rand.Next(10, 24)}";
                DateTime fechaActualizacion = DateTime.Now;
                string imagenEtiqueta = $"Etiqueta_{i}";
                string nombre = nombres[i];
                string notaDeCataBodega = notasDeCata[i];
                int precioARS = rand.Next(500, 5000);

                VinosSistemaBodega vino = new VinosSistemaBodega(añada, fechaActualizacion, imagenEtiqueta, nombre, notaDeCataBodega, precioARS);

                // Añadir 2 maridajes
                for (int j = 0; j < 2; j++)
                {
                    string maridajeDescripcion = maridajeDescripciones[rand.Next(maridajeDescripciones.Length)];
                    vino.Maridajes.Add(new Maridaje(maridajeDescripcion, $"Maridaje_{j + 1}"));
                }

                // Añadir entre 0 y 5 varietales
                int numVarietales = rand.Next(0, 6);
                for (int j = 0; j < numVarietales; j++)
                {
                    bool esTinta = rand.Next(2) == 0;
                    string varietalNombre = esTinta ? variedadesTintas[rand.Next(variedadesTintas.Length)] : variedadesBlancas[rand.Next(variedadesBlancas.Length)];
                    TipoUva tipoUva = new TipoUva($"Descripción de {varietalNombre}", varietalNombre);
                    Varietal varietal = new Varietal(varietalNombre, $"Descripción Varietal {varietalNombre}", rand.Next(0, 100), tipoUva);
                    vino.Varietales.Add(varietal);
                }
                vinos.Add(vino);

            }
            return vinos;
        }
    }
}
