using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOOAgosto2025Alt.Entidades
{
    public class Revista:Producto
    {
        private string _periodicidad;
        private int _nroEdicion;
        public string Periodicidad { get => _periodicidad; set => _periodicidad = string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Ingreso nulo en la periodicidad"); }
        public int NroEdicion
        {
            get { return _nroEdicion; }
            set
            {
                if (_nroEdicion > 0)
                {

                    _nroEdicion = value;
                }
                else
                {
                    throw new ArgumentException("el nro de edicion tienen que ser mayor a 0");
                }
            }
        }
        public Revista() : base()
        {
        }

       

        public Revista(int productiId, string? descripcion, decimal precio, int stock, int nroEdicion,string perdiodicidad) : 
            base(productiId, descripcion, precio, stock)
        {
            Periodicidad = perdiodicidad;
            NroEdicion = nroEdicion;
        }

        public override decimal AplicarDescuento()
        {
            return Precio * 0.10m;
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Preiodicidad: {Periodicidad}");
            sb.AppendLine($"número de edición: {NroEdicion}");
            return sb.ToString();
        }
    }
}
