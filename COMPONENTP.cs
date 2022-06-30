using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPOSITE
{
    abstract class COMPONENTP
    {
        public string Nombre { get; set; }
        public decimal Valor { get; set; }

        public COMPONENTP(string Nombre, decimal Valor)
        {
            this.Nombre = Nombre;
            this.Valor = Valor;
        }
    }
}
