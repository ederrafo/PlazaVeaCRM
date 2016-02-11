using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlazaVeaCRMWeb.Models
{
    public class PersonalProgramado
    {
        public PersonalProgramado()
        {
            OrdenDespacho = new HashSet<OrdenDespacho>();
        }

        [Key]
        public int IdPersonalProgramado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Observacion { get; set; }
        public int IdPersona { get; set; }
        public int IdTurno { get; set; }
        public virtual ICollection<OrdenDespacho> OrdenDespacho { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual Turno Turno { get; set; }


    }
}