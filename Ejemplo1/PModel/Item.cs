using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1.PModel
{
    class Item
    {
        public Item()
        {
        }

        public Item(int id, string label)
        {
            this.IdOpcion = id;
            this.Label = label;
        }


        // definir internamente una propiedad privada cuanto es el ancho en esapacion de las opciones
        public int IdOpcion { get; set; }
        public string Label { get; set; }
        public override string ToString()
        {
            return $"| {this.IdOpcion.ToString()} | {this.Label} |";
        }
    }
}
