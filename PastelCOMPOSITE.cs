using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPOSITE
{
    class PastelCOMPOSITE : COMPONENTP
    {
        private List<COMPONENTP> ingredientes = new List<COMPONENTP>();

        public decimal ValorTotal
        {
            get
            {
                decimal Valor= 0;
                foreach (var oElemento in ingredientes)
                {
                    if (oElemento.GetType().Name == "PastelCOMPOSITE")
                        Valor += ((PastelCOMPOSITE)oElemento).ValorTotal;
                    else
                        Valor += oElemento.Valor;
                }

                return Valor;

            }
        }

        public void Add(COMPONENTP oElemento)
        {
            ingredientes.Add(oElemento);
        }

        public void Remove(COMPONENTP oElemento)
        {
            ingredientes.Remove(oElemento);
        }

        public PastelCOMPOSITE(string Nombre, decimal Valor=0) : base(Nombre, Valor)
        {
        }


    }
}
