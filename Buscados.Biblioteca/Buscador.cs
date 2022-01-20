using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio2
{
    static class Buscador
    {
        static public Publicacion[] Publicaciones;

        static public void ImprimirConcidenciasPorTitulo(string palabra)
        {
            string codigos = "";
            foreach (Publicacion publi in Publicaciones)
            {

                if (publi.Coincidencia(palabra))
                {
                    codigos += " " + publi.RetornarCodigo();
                }

                                                                                                                                                                                /*

                                                                                                                                                                                    if (publi.RetornarTitulo().Contains(palabra))
                                                                                                                                                                                    {
                                                                                                                                                                                    codigos += " " + publi.RetornarCodigo();
                                                                                                                                                                                    }

                                                                                                                                                                                    if (publi is Revista)
                                                                                                                                                                                    {
                                                                                                                                                                                        Revista rev = (Revista)publi;
                                                                                                                                                                                        Articulo [] arts = rev.RetornarArticulos();

                                                                                                                                                                                        bool match = false;
                                                                                                                                                                                        for(int i = 0; i< arts.Length && !match ; i++)
                                                                                                                                                                                        {                        
                                                                                                                                                                                            if (arts[i].RetornarTitulo().Contains(palabra))
                                                                                                                                                                                            {
                                                                                                                                                                                                codigos += publi.RetornarCodigo();
                                                                                                                                                                                                match = true;
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                                if (String.IsNullOrEmpty(codigos))
                                                                                                                                                                                {
                                                                                                                                                                                    Console.WriteLine("no hubo coincidencias");
                                                                                                                                                                                }
                                                                                                                                                                                else 
                                                                                                                                                                                {
                                                                                                                                                                                    Console.WriteLine(codigos);
                                                                                                                                                                                }                      
                                                                                                                                                                                */
            }

            if (String.IsNullOrEmpty(codigos))
            {
                Console.WriteLine("no hubo coincidencias");
            }
            else
            {
                Console.WriteLine(codigos);
            }
            

        }
    }
}

