using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio2
{
    class Revista : Publicacion //código, titulo, mes, año, articulos
    {

        private int mes;
        private Articulo[] articulos;

        public Revista(string codigo, string titulo, int mes, int anio, Articulo[] articulo) : base(codigo , titulo, anio)
        {
            this.mes = mes;
            this.articulos = articulo;
        }
       

        public override string MostrarInfo()
        {

            string info = base.MostrarInfo();

            info += "\n mes: " + this.mes.ToString();
            info += "\n articulos: \n";
            foreach(Articulo art in articulos)
            {
                info += art.Ver() + "\n";
            }
            return info;
        }

        public Articulo[] RetornarArticulos()
        {
            return articulos;
        }

        public override bool Coincidencia(string palabra)
        {
            if (base.Coincidencia(palabra))
            {
                return true;
            }

            else
            {
                foreach(Articulo art in articulos)
                {
                    if (art.Coincidencia(palabra))
                        return true;
                }
            }

            return false;

        }

    }
}
