using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1.Model
{
    class Libro
    {
        //private int id;
        //public void setId(int id)
        //{
        //    this.id = id;
        //}x

        public Libro()
        {
        }

        public Libro(int id, string titulo, string autor, string genero, string isbn)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Genero = genero;
            this.Isbn = isbn;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string Isbn { get; set; }

        public override string ToString()
        {
            return $"| {this.Id} | {this.Titulo} | {this.Autor} | {this.Genero} | {this.Isbn} |";
        }

    }
}
