using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlazaVeaCRMWeb.Models
{
    public class Turno
    {
        public Turno()
        {
            PersonalProgramado = new HashSet<PersonalProgramado>();
        }

        [Key]
        public int IdTurno { get; set; }
        
        public string DescripcionTurno { get; set; }

        public virtual ICollection<PersonalProgramado> PersonalProgramado { get; set; }

    }
}