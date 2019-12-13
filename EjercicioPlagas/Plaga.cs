using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioPlagas
{
    public class Plaga
    {
        public int IdPlaga
        {
            get => default(int);
            set
            {
            }
        }

        public string Nombre
        {
            get;
            set
          ;
        }

        public int Cantidad
        {
            get;
            set
           ;
        }

        public Veneno Veneno
        {
            get;
            set
           ;
        }
    }
}