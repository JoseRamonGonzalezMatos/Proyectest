using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioPlagas
{
    public class Trabajador
    {
        public string Nombre { get; set; }
        public int IdTrabajador { get; set;}

        public decimal Ingreso
        {
            get => default(int);
            set
            {
            }
        }
    }
}