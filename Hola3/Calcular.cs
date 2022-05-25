using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola3
{
    public class Calcular
    {
        private int precioppieza;
        private int cant;

        public int Precioppieza { get; set; }
        public int Cant { get; set; }

        public double CalcularPrecio(int ppp, int cant)
        {
            double subtotal = ppp * cant;
            double iva = subtotal * 0.16;
            double preciototal = subtotal + iva;
            
            return preciototal;
        }
    }
}
