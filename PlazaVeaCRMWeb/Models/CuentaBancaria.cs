using System.Collections.Generic;

namespace PlazaVeaCRMWeb.Models
{
    public class CuentaBancaria
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Numero { get; set; }
        public string NombrePropietario { get; set; }
        public Moneda Moneda { get; set; }
        public double Importe { get; set; }

        public virtual ICollection<CuentaBanco> CuentasBancos { get; set; }
    }
}
