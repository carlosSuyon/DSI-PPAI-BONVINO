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
            //fetch o get a un endpoint que me responde con  una coleccion de vinos segun el nombre de la bodega

            string[] tipoUva = new string[]
            {
                // Variedades tintas
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
                // Variedades blancas
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
            string[] notasDeCata = {
            "Frutos rojos intensos, vainilla, suave.", "Notas cítricas, manzana verde, fresco.", "Fresas, florales, ligero y refrescante.",
            "Frutos negros, taninos suaves, fácil de beber.", "Manzana, pera, burbujeante y elegante.", "Frutos maduros, roble, estructurado.",
            "Pasas, miel, untuoso y delicioso.", "Ciruelas, vainilla, suave y equilibrado.", "Frutos rojos, especias, final persistente.",
            "Melocotón, miel, frescura equilibrada."
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
                "Pinot Grigio delle Venezie",
    
                "Lambrusco Amabile",
                "Gewürztraminer Select",
                "Gamay Beaujolais Nouveau",
                "Porto Vintage",
                "Shiraz Barossa Valley",
                "Chenin Blanc Old Vine",
                "Pinotage Reserve",
                "Fiano di Avellino",
                "Monastrell Reserva",
                "Mencia Bierzo",
                "Blaufränkisch Classic",
                "Cortese di Gavi",
                "Arneis Langhe",
                "Nero d'Avola Sicilia",
                "Touriga Nacional",
                "Negroamaro Salento",
                "Aglianico del Vulture",
                "Cannonau di Sardegna",
                "Dolcetto d'Alba",
                "Lacrima di Morro d'Alba",
                "Petit Verdot",
                "Bonarda Argentina",
                "Marsanne Roussanne",
                "Pedro Ximénez Dulce",
                "Torrontés Cafayate"
            };

            Random rand = new Random();

            List<VinosSistemaBodega> vinos = new List<VinosSistemaBodega>();
            
            for (int i = 0; i < 10; i++)
            {
                // Generar datos para el vino
                int añoAñada = rand.Next(1950, 2025);
                DateTime fechaActualizacion = DateTime.Now;
                string imagenEtiqueta = $"Etiqueta_{i}";
                string nombre = nombresVinosPopulares[rand.Next(0, nombresVinosPopulares.Length-1)];
                string notaDeCataBodega = notasDeCata[i];
                int precioARS = rand.Next(500, 50000);

                VinosSistemaBodega vino = new VinosSistemaBodega(añoAñada.ToString(), fechaActualizacion, imagenEtiqueta, nombre, notaDeCataBodega, precioARS);

                // Añadir entre 0 y  3 maridajes
                int numMaridajes = rand.Next(0, 3);
                List<string> maridajes = new List<string>();
                for (int j = 0; j < numMaridajes; j++)
                {
                    string m = "Maridaje" + (j + 1);
                    maridajes.Add(m);
                }
                vino.Maridajes = maridajes;

                // Añadir entre 1 y 5 varietales
                int numVarietales = rand.Next(1, 6);
                List<string[]> varietales = new List<string[]>();
                for (int j = 0; j < numVarietales; j++)
                {
                    string nV = $"Varietal : {j}";
                    string dV = $"Vino varietal con predominancia de una variedad de uva";
                    string pC = rand.Next(80, 101).ToString(); // Entre 80% y 100%
                    string tU = tipoUva[rand.Next(0,tipoUva.Length)];
                    
                    string[] v = new string[] { nV, dV, pC, tU };
                    varietales.Add(v);
                }
                vinos.Add(vino);
                vino.Varietales = varietales;
            }
            return vinos;
        }
    }
}
