using System;

namespace SRP
{
    public class Biblioteca
    {
        /*Se crea una nueva clase biblioteca, la cual tiene la responsabilidad de conocer en que estante y
        sector se almacena el librao*/
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public void AlmacenarLibro(Libro libro, String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }
    }
}