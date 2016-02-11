using PlazaVeaCRMWeb.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System;

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

            var persona = new List<Persona>
            {
                new Persona { Dni= "20557271", Nombre = "Kiefer", ApeParterno = "Fernandez", ApeMaterno = "Valladolid", Direccion = "Urb. Pasaje Oculto", Telefono = "5745748", Celular = "987987987", TipoPersona = TipoPersona.Conductor },
                new Persona { Dni= "20557272", Nombre = "Christian", ApeParterno = "Munguía", ApeMaterno = "Munguía", Direccion = "Los Olivos", Telefono = "5745747", Celular = "987987986", TipoPersona = TipoPersona.Operario },
                new Persona { Dni= "20557273", Nombre = "Jesus", ApeParterno = "Vallejos", ApeMaterno = "Vallejos", Direccion = "San Miguel", Telefono = "5745746", Celular = "987987985", TipoPersona = TipoPersona.Operario },
                new Persona { Dni= "20557274", Nombre = "Kenyi", ApeParterno = "Nuñez", ApeMaterno = "Nuñez", Direccion = "La Molina", Telefono = "5745745", Celular = "987987984", TipoPersona = TipoPersona.Operario },
                new Persona { Dni= "20557275", Nombre = "Julio", ApeParterno = "Huamancama", ApeMaterno = "Huamancama", Direccion = "Ate", Telefono = "5745744", Celular = "987987983", TipoPersona = TipoPersona.Conductor }
            };

            persona.ForEach(s => context.Persona.Add(s));
            context.SaveChanges();

            var turno = new List<Turno>
            {
                new Turno {DescripcionTurno = "Turno A"},
                new Turno {DescripcionTurno = "Turno B"},
                new Turno {DescripcionTurno = "Turno C"},
                new Turno {DescripcionTurno = "Turno D"}
            };


            turno.ForEach(s => context.Turno.Add(s));
            context.SaveChanges();

            var transporte = new List<Transporte>
            {
                new Transporte { NroPlaca = "F6L-901", Modelo = "Modelo 1", Marca = "Hyundai", Soat = "INTERSEGURO - 3375929", TipoTransporte = TipoTransporte.Privado, Capacidad = 1000.0m },
                new Transporte { NroPlaca = "AF1-944", Modelo = "Modelo 2", Marca = "Toyota", Soat = "PACIFICO - 3375928", TipoTransporte = TipoTransporte.Privado, Capacidad = 1200.0m },
                new Transporte { NroPlaca = "AFW-926", Modelo = "Modelo 3", Marca = "Mazda", Soat = "MAPFRE - 3375927", TipoTransporte = TipoTransporte.Privado, Capacidad = 1200.0m },
                new Transporte { NroPlaca = "F3S-818", Modelo = "Modelo 4", Marca = "Kia", Soat = "INTERSEGURO - 3375926", TipoTransporte = TipoTransporte.Privado, Capacidad = 1300.0m }
            };

            transporte.ForEach(s => context.Transporte.Add(s));
            context.SaveChanges();

            var producto = new List<Producto>
            {
                new Producto { DescripcionProducto = "Huevos", UnidadMedida = "Kg.", TipoProducto = TipoProducto.Perecible, CategoriaProducto = CategoriaProducto.Huevos_Lacteos_Y_Cafe },
                new Producto { DescripcionProducto = "Cafe", UnidadMedida = "Kg.", TipoProducto = TipoProducto.Perecible, CategoriaProducto = CategoriaProducto.Huevos_Lacteos_Y_Cafe },
                new Producto { DescripcionProducto = "Gaseosa Fanta", UnidadMedida = "Lt.", TipoProducto = TipoProducto.Perecible, CategoriaProducto = CategoriaProducto.Zumos_Y_Bebidas },
                new Producto { DescripcionProducto = "Lomo Fino", UnidadMedida = "Kg.", TipoProducto = TipoProducto.Perecible, CategoriaProducto = CategoriaProducto.Carnes_Y_Embutidos },
                new Producto { DescripcionProducto = "Aceitunas", UnidadMedida = "Kg.", TipoProducto = TipoProducto.Perecible, CategoriaProducto = CategoriaProducto.Aperitivos },
            };

            producto.ForEach(s => context.Producto.Add(s));
            context.SaveChanges();
            
        }
    }
}
