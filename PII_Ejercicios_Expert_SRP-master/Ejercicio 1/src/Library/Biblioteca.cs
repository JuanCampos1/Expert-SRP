using System;

namespace SRP
{
    public class Biblioteca
    {
        /*Se crea una nueva clase biblioteca, la cual tiene la responsabilidad de conocer en que estante y
        sector se almacena el libro*/
        public string SectorBiblioteca;
        public string EstanteBiblioteca;

        public void AlmacenarLibro(Libro libro, String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }
    }
}