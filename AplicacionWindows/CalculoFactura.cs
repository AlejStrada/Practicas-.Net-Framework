using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace AplicacionWindows
{
    internal class CalculoFactura
    {
        public double kwhtTotal{ get; set; }
        public double impuestos { get; set; }
        public double kwhDepartamento { get; set; }
        public double importeKwh { get; set; }

        public double calculo()
        {
            double resultado = ((kwhDepartamento * importeKwh) / kwhtTotal) + (impuestos / 2 );
            return resultado;
        }


    }
}
