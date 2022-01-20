using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio2
{
    class Articulo 
    {
        private string titulo;
        private string autor;
        private int palabras;



        public Articulo (string titulo , string autor , int palabras)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.palabras= palabras;
        }

        public string Ver()
        {
            string info = "";
            info += "\n Titulo: " + this.titulo;
            info += "\n Autor: " + this.autor;
            info += "\n cantidad de palabras: " + this.palabras.ToString();
            return info;
        }

        public string RetornarTitulo()
        {
            return titulo;
        }

        public bool Coincidencia(string palabra)
        {
            if (titulo.Contains(palabra))
            {
                return true;
            }
            return false;
        }

    }
}
