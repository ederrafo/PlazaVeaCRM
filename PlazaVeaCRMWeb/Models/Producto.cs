using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlazaVeaCRMWeb.Models
{
    public enum TipoProducto
    {
        Perecible = 0,
        NoPerecible = 1,
        Devuelto = 2
    }

    public enum CategoriaProducto
    {
        Carnes_Y_Embutidos = 0,
        Frutas_Y_Verduras = 1,
        Panaderia_Y_Dulces = 2,
        Huevos_Lacteos_Y_Cafe = 3,
        Aceite_Pasta_Y_Legumbre = 4,
        Conservas_Y_ComidaPreparada = 5,
        Zumos_Y_Bebidas = 6,
        Aperitivos = 7,
        Algas_Tofu_Y_Preparados = 8,
        Infantil = 9,
        Cosmetica_Y_CuidadoPersonal = 10,
        Hogar_Y_Limpieza = 11
    }

    public class Producto
    {
        public Producto()
        {
            DetalleOrdenDespacho = new HashSet<DetalleOrdenDespacho>();
            DetalleSolicitudCompra = new HashSet<DetalleSolicitudCompra>();
        }

        [Key]
        public int IdProducto { get; set; }

        public string DescripcionProducto { get; set; }
        public string UnidadMedida { get; set; }
        public TipoProducto TipoProducto { get; set; }
        //public string DescTipoProducto { get; set; }
        public CategoriaProducto CategoriaProducto { get; set; }
        //public string DescCateogoriaProducto { get; set; }


        public virtual ICollection<DetalleOrdenDespacho> DetalleOrdenDespacho { get; set; }
        public virtual ICollection<DetalleSolicitudCompra> DetalleSolicitudCompra { get; set; }

    }
}