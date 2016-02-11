using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlazaVeaCRMWeb.Models
{
    public enum TipoTransporte
    {
        Publico = 0,
        Privado = 1
    }

    public class Transporte
    {
        public Transporte()
        {
            OrdenDespacho = new HashSet<OrdenDespacho>();
        }

        [Key]
        public int IdTransporte { get; set; }
        public string NroPlaca { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Soat { get; set; }
        public TipoTransporte TipoTransporte { get; set; }
        public decimal? Capacidad { get; set; }
        public ICollection<OrdenDespacho> OrdenDespacho { get; set; }

    }
}