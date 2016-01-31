
namespace PlazaVeaCRMWeb.Models
{
    public enum Moneda
    {
        Soles,
        Dolares
    }

    public class CuentaBanco
    {
        public int ID { get; set; }
        public int BancoID { get; set; }
        public int CuentaBancariaID { get; set; }
        public bool Habilitada { get; set; }

        public virtual Banco Banco { get; set; }
        public virtual CuentaBancaria CuentaBancaria { get; set; }
    }
}
