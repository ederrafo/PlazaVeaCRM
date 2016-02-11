using System;
using System.ComponentModel.DataAnnotations;

namespace PlazaVeaCRMWeb.Models
{
    public class DetalleOrdenDespacho
    {
        [Key]
        public int IdDetalleOrdenDespacho { get; set; }

        public int? IdOrdenDespacho { get; set; }
        public int? IdProducto { get; set; }
        public decimal? CantidadRequerida { get; set; }

        public virtual OrdenDespacho OrdenDespacho { get; set; }

        public virtual Producto Producto { get; set; }


    }
}