using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlazaVeaCRMWeb.Models
{
    public enum EstadoSolicitudCompra
    {
        Pendiente = 1,
        Devuelto = 2
    }

    public class SolicitudCompra
    {
        public SolicitudCompra()
        {
            DetalleSolicitudCompra = new HashSet<DetalleSolicitudCompra>();
        }


        [Key]
        public int IdSolicitudCompra { get; set; }
        public DateTime FechaSolicitudCompra { get; set; }
        public string NroTienda { get; set; }
        public EstadoSolicitudCompra EstadoSolicitudCompra { get; set; }
        public int IdOrdenDespacho { get; set; }
        public virtual ICollection<DetalleSolicitudCompra> DetalleSolicitudCompra { get; set; }
        public virtual OrdenDespacho OrdenDespacho { get; set; }

    }
}