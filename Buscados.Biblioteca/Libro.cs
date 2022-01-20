using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio2
{
    class Libro : Publicacion
    {

        private string autor;


        public Libro(string codigo, string titulo, string autor, int año) : base (codigo, titulo , año)
        {
            this.autor = autor;
        }

        public override string MostrarInfo()
        {           
            string info = base.MostrarInfo();
            info += "\n Autor: " + this.autor;
            return info;
        }

    }
}
