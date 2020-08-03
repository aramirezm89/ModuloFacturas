using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloFacturas
{
    class ClsFactura
    {
        private int numero;
        private string proveedor;
        private string detalle;
        private int totales;

        public ClsFactura(int numero, string proveedor, string detalle, int totales)
        {
            this.numero = numero;
            this.proveedor = proveedor;
            this.detalle = detalle;
            this.totales = totales;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public int Totales { get => totales; set => totales = value; }
    }



}
