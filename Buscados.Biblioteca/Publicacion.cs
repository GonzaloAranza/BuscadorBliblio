using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio2

{
    abstract class Publicacion
    {
        protected string codigo;
        protected string titulo;
        protected int anio;

        public Publicacion(string codigo , string titulo , int anio){
            this.codigo = codigo;
            this.titulo = titulo;
            this.anio = anio;
        }

        public virtual string MostrarInfo()
        {
            string info = "";
            info += "Titulo: " + this.titulo;
            info += "\n Codigo: " + this.codigo;
            info += "\n Año: " + this.anio.ToString();
            return info;
        }

        public string RetornarCodigo()
        {
            return codigo;
        }

        public string RetornarTitulo()
        {
            return titulo;
        }

        public virtual bool Coincidencia(string palabra)           
        {
            if (titulo.Contains(palabra)){
                return true;
            }
            return false;
        }
}
}
