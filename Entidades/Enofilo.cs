﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Entidades
{
    public class Enofilo
    {
        //atributos
        private string apellido;
        private string imagenPerfil;
        private string nombre;

        private Usuario usuario;

        private List<Vino> favorito;
        private List<Siguiendo> seguido;

        // getters and setters
        public string Apellido { get => apellido; set => apellido = value; }
        public string ImagenPerfil { get => imagenPerfil; set => imagenPerfil = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Vino> Favorito { get => favorito; set => favorito = value; }
        public List<Siguiendo> Seguido { get => seguido; set => seguido = value; }

        //constructor
        public Enofilo(string apellido, string imagenPerfil, string nombre,Usuario usu)
        {
            this.Apellido = apellido;
            this.ImagenPerfil = imagenPerfil;
            this.Nombre = nombre;
            this.usuario = usu;
            this.Seguido = new List<Siguiendo>();
        }
        //metodos
        public Boolean sosSeguidorBodega(Bodega bodega)
        {
            Boolean x = false;
            foreach (Siguiendo s in this.seguido)
            {
                if (s.sosDeBodega(bodega)){
                    x = true;   
                }
            }
            return x;

        }
        public string getNombreUsuario(){
                return this.usuario.getNombre();
        }
    }
}
