using PPAI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PPAI.Interfaces
{
    internal interface InterfazAPIBodega
    {
        public List<JsonObject> obtenerActualizacionesBodega(string nombreBodega) {
            List<JsonObject> vinosDeAPI = new List<JsonObject>();
            string v = "{añada:1970,fechaActualización:'',imagenEtiqueta:'',nombre:'Alma Mora',notaDeCataBodega:10,precioARS:5000}";
            List<string> nombres = new List<string>();
            nombres.Add(v);
           
            //traer los vinos del Sistema de Bodega 
            //fetch o get a un endpoint que me trae un vector de vinos segun el nombre de la bodega
            return vinosDeAPI;
        }
    }
}
