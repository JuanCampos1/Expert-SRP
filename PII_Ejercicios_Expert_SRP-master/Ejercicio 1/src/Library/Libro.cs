using System;

namespace SRP
{
    public class Libro
    {
        /*Se mueve el método AlmacenarLibro a una clase biblioteca ya que el libro no tiene
        la necesidad de conocer en donde se almacena*/

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

    }
}
