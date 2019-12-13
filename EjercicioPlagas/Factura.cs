using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioPlagas
{
    public class Factura : IFactura
    {
        public int IdFactura
        {
            get => default(int);
            set
            {
            }
        }

        public Cliente Cliente
        {
            get ;
            set
           ;
        }

        public List<Servicio> Servicio
        {
            get;
            set
          ;
        }

        public int Fecha
        {
            get;
            set
          ;
        }

    }
}