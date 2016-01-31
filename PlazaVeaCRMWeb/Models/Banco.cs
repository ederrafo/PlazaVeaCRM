using System.Collections.Generic;

namespace PlazaVeaCRMWeb.Models
{
    public class Banco
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<CuentaBanco> CuentasBancos { get; set; }
    }
}
