using PlazaVeaCRMWeb.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace PlazaVeaCRMWeb.DAL
{
    public class PlazaVeaCrmInitializer : DropCreateDatabaseIfModelChanges<PlazaVeaCrmContext>
    {
        protected override void Seed(PlazaVeaCrmContext context)
        {
            var bancos = new List<Banco>
            {
                new Banco { Codigo="BCP", Nombre="Banco de Credito del Perú" },
                new Banco { Codigo="BBVA", Nombre="Banco Bilvao y Vizcarra del Perú" }
            };

            bancos.ForEach(s => context.Banco.Add(s));
            context.SaveChanges();

        }
    }
}
