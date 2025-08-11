using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOOAgosto2025Alt.Entidades
{
    public class Libro: Producto
    {
        private string _autor;
        private int _cantPaginas;
        public string Autor { get => _autor; set => _autor = string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Ingreso nulo en el autor"); }
        public int CantPaginas
        {
            get { return _cantPaginas; }
            set
            {
                if (_cantPaginas > 0)
                {

                    _cantPaginas = value;
                }
                else
                {
                    throw new ArgumentException("la cantidad de pagina tienen que ser mayor a 0");
                }
            }
        }
        public Libro() : base()
        {
        }

       

        public Libro(int productiId, string? descripcion, decimal precio, int stock, string autor, int cantPaginas) : base(productiId, descripcion, precio, stock)
        {
            Autor = autor;
            CantPaginas = cantPaginas;
        }

        public override decimal AplicarDescuento()
        {
            return Precio*0.15m;
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Autor: {Autor}");
            sb.AppendLine($"Cantidad de páginas: {CantPaginas}");
            return sb.ToString();
        }
    }
}
