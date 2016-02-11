using System;
using System.ComponentModel.DataAnnotations;

namespace PlazaVeaCRMWeb.Models
{

    public enum EstadoDetalleSolicitudCompra
    {
        Sin_Despachar = 0,
        Despachada = 1
    }

    public class DetalleSolicitudCompra
    {
        [Key]
        public int IdDetalleSolicitudCompra { get; set; }

        public int? IdSolicitudCompra { get; set; }
        public int? IdProducto { get; set; }

        public decimal? CantidadSolicitada { get; set; }
        public EstadoDetalleSolicitudCompra EstadoDetalleSolicitudCompra { get; set; }

        public virtual Producto Producto { get; set; }

        public virtual SolicitudCompra SolicitudCompra { get; set; }
    }
}