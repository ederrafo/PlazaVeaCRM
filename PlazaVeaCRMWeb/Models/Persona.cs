using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlazaVeaCRMWeb.Models
{
    public enum TipoPersona
    {
        Conductor = 1,
        Operario = 2
    }

    public class Persona
    {
        public Persona()
        {
            PersonalProgramado = new HashSet<PersonalProgramado>();
        } 

        [Key]
        public int IdPersona { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string ApeParterno { get; set; }
        public string ApeMaterno { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public TipoPersona TipoPersona { get; set; }

        public virtual ICollection<PersonalProgramado> PersonalProgramado { get; set; }
    }
}