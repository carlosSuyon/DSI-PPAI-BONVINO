using PPAI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Interfaces
{
    internal interface InterfazAPIBodega
    {
        public  List<Vino> obtenerActualizacionesBodega(){
            //traer los vinos del Sistema de Bodega 
            List<Vino> vinosDeAPI = new List<Vino>();
            //fetch o get a un endpoint que me trae un vector de vinos segun el nombre de la bodega
            return vinosDeAPI;
        }
    }
}
