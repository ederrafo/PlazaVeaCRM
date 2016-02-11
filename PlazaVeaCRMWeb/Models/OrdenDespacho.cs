using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlazaVeaCRMWeb.Models
{
    public enum TipoPrioridadOrdenDespacho
    {
        Baja = 0,
        Media = 1,
        Alta = 2
    }

    public enum EstadoOrdenDespacho
    {
        Creado =  0,
        Aprobado = 1
    }

    public class OrdenDespacho
    {
        public OrdenDespacho()
        {
            DetalleOrdenDespacho = new HashSet<DetalleOrdenDespacho>();
            RutaOrdenDespacho = new HashSet<RutaOrdenDespacho>();
            SolicitudCompra = new HashSet<SolicitudCompra>();
        }


        [Key]
        public int IdOrdenDespacho { get; set; }
        public DateTime FechaDespacho { get; set; }
        public TipoPrioridadOrdenDespacho TipoPrioridadOrdenDespacho { get; set; }

        public int IdTransporte { get; set; }
        public int? IdConductor { get; set; }
        public int? IdOperario { get; set; }

        public string Observacion { get; set; }
        public EstadoOrdenDespacho EstadoOrdenDespacho { get; set; }
        
        
        public virtual PersonalProgramado PersonalProgramado { get; set; }
        public virtual Transporte Transporte { get; set; }
        public virtual ICollection<DetalleOrdenDespacho> DetalleOrdenDespacho { get; set; }
        public virtual ICollection<RutaOrdenDespacho> RutaOrdenDespacho { get; set; }
        public virtual ICollection<SolicitudCompra> SolicitudCompra { get; set; }

    }
}