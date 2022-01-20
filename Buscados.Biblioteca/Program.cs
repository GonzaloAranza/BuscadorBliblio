using System;

namespace ejercicio2
{
    class Program
    {
        static void Main()
        {            Publicacion[] p = new Publicacion[4];

            p[0] = new Libro("L1000", "Cien años de soledad", "Garcia Marquez", 1967); //código, titulo, autor, año publicacion



        
            Articulo[] art_aux = new Articulo[3];
            art_aux[0] = new Articulo("Calentamiento global", "Juan Gomez", 340); //titulo, autor, cant de palabras
            art_aux[1] = new Articulo("La selva misionera", "Pepe Rodriguez", 250);
            art_aux[2] = new Articulo("Crisis del Artico", "Maria Perez", 400);
                      p[1] = new Revista("R1234", "National Geographic", 3, 2019, art_aux);  //código, titulo, mes, año, articulos

                      p[2] = new Libro("L2222", "Como programar en C#", "Deitel", 2000);

                      p[3] = new Libro("L2345", "Cuentos de la selva", "Horacio Quiroga", 1918);

            
       /*     foreach(Publicacion publi in p)
            {
                Console.WriteLine(publi.MostrarInfo());
            }
       */
           


           //   string prueba = "vamos a probar el metodo contains usando este string.";
             
             // Console.WriteLine (prueba.Contains("hola"));
            


                     Buscador.Publicaciones = p;

                        Console.WriteLine("- Buscando selva:");
                        Buscador.ImprimirConcidenciasPorTitulo("selva"); //muestra como resultados: R1234 y L2345
            
                        Console.WriteLine("- Buscando National:");
                        Buscador.ImprimirConcidenciasPorTitulo("National"); //muestra como resultados: R1234

                        Console.WriteLine("\n- Buscando soledad:");
                        Buscador.ImprimirConcidenciasPorTitulo("soledad"); //muestra como resultados: L1000

                        Console.WriteLine("- Buscando zzzzz:");
                        Buscador.ImprimirConcidenciasPorTitulo("zzzzz"); //muestra como resultados: "sin coincidencias"

                        Console.ReadKey();
            
        }


    }
}
