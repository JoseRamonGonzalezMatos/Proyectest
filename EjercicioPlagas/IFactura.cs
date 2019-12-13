using System.Collections.Generic;

namespace EjercicioPlagas
{
    public interface IFactura
    {
        Cliente Cliente { get; set; }
        int Fecha { get; set; }
        int IdFactura { get; set; }
        List<Servicio> Servicio { get; set; }
    }
}