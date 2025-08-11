using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOOAgosto2025Alt.Entidades
{
    public abstract class Producto
    {
        private int _stock;
        private decimal _precio;
        private int _contador = 1;
        public Producto()   
        {
           
        }
        
        protected Producto(int productiId,string? descripcion, decimal precio, int stock ) 
        {
            _contador++;
            Stock = stock;
            Precio = precio;
            Descripcion = descripcion;
            ProductoId=productiId;
        }
        private int _productoId;
        public int ProductoId
        {
            get { return _productoId; }
            set
            {
                if (_productoId == _contador)
                {

                    _productoId = value;
                }
                else
                {
                    throw new ArgumentException("el id ya esta ingresado");
                }
            }
        }
        public string? Descripcion { get; set; }
        
        public int Stock 
        {
            get { return _stock; }
            set
            {
                if (_stock >= 0)
                {

                    _stock = value;
                }
                else
                {
                    throw new ArgumentException("el stock no puede ser negativo");
                }
            }
        }
        public decimal Precio
        {
            get { return _precio; }
            set
            {
                if (_precio >0)
                {

                    _precio = value;
                }
                else
                {
                    throw new ArgumentException("el precio no puede ser 0 o negativo");
                }
            }
        }


        public abstract decimal AplicarDescuento();

        public virtual string MostrarDatos()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"Producto nro: {ProductoId}");
            sb.AppendLine($"Descripción: {Descripcion}");
            sb.AppendLine($"Precio: $ {Precio}");
            sb.AppendLine($"Stock: {Stock} Unidades");
            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            // uso pattern matching para castear obj a otroProducto
            // con eso ya se si viene null o no porque si es null no puede ser un Producto

            if (obj is not Producto otroProducto)
            {
                return false;
            }
            return this.ProductoId == otroProducto.ProductoId;
        }
        public override int GetHashCode()
        {
            return ProductoId.GetHashCode();
        }
    }
}
