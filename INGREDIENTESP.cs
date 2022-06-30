using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPOSITE
{
    class INGREDIENTESP : COMPONENTP
    {
        public int Cantidad { get; set; }
        public string Unidad { get; set; }

        public INGREDIENTESP(string Nombre, decimal Valor,int Cantidad, string Unidad) 
            : base(Nombre, Valor)
        {
            this.Cantidad = Cantidad;
            this.Unidad = Unidad;
        }
    }
}
