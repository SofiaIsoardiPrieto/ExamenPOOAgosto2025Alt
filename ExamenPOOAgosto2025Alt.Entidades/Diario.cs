using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOOAgosto2025Alt.Entidades
{
    public class Diario : Producto
    {
        public DateTime FechaPublicacion { get; set; }
        public Diario():base()
        {
        }

        
        public Diario(int productiId, string? descripcion, decimal precio, int stock, DateTime fechaPublicacion) : base(productiId, descripcion, precio, stock)
        {
            FechaPublicacion = fechaPublicacion;
        }

        public override decimal AplicarDescuento()
        {
            return Precio;
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Fecha publicacion: {FechaPublicacion}");
            return sb.ToString();
        }
    }
}
