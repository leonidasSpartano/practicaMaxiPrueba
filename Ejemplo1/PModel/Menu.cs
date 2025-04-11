using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1.PModel
{
    class Menu
    {
        public List<Item> Opciones;

        public Menu()
        {
            this.Opciones = new List<Item>();
        }

        public override string ToString()
        {
            string linea = "+-------------------------+";
            string titulo = "|      Menu de libros     |";
            string salto = "\n";


            string res = linea + salto;
            res += titulo + salto;
            res += linea + salto;

            foreach (var opcion in this.Opciones)
            {
                res += opcion + salto;
            }

            res += linea + salto;

            return res;
        }



    }
}
