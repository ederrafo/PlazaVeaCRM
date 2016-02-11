using System.ComponentModel.DataAnnotations;

namespace PlazaVeaCRMWeb.Models
{
    public class RutaOrdenDespacho
    {
        [Key]
        public int IdRutaOrdenDespacho { get; set; } // IdRuta

        public int IdOrdenDespacho { get; set; } // OrdenDespacho
        public string NroTienda { get; set; }
        public int Orden { get; set; }

        public virtual OrdenDespacho OrdenDespacho { get; set; }

    }
}