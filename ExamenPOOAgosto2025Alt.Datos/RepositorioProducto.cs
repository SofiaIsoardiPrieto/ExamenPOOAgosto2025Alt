using ExamenPOOAgosto2025Alt.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOOAgosto2025Alt.Datos
{
    public class RepositorioProducto : IRepositorio<Producto>, IRepositorioProducto
    {
        private Dictionary<int,Producto> _productos;
        public RepositorioProducto()
        {
            _productos=new Dictionary<int, Producto>();
        }
        public int ObtenerCantidad()
        {
            return _productos.Count;
        }

        public Producto ObtenerPorId(int id)
        {
            if (_productos.ContainsKey(id))
            {
                return _productos[id];
            }
            else
            {
                throw new ArgumentException("no se entontro el producto");
            }
           
        }

        public Producto ObtenerPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Producto> ObtenerPorTipo(Type tipo)
        {
            List<Producto> lista = new();
            foreach (var p in _productos.Values)
            {
                if (p.GetType()==tipo)
                {
                    lista.Add(p);
                }
                
            }
            return lista;
        }

        

        public Dictionary<int, Producto> ObtenerTodos()
        {
            return _productos;
        }
    }
}
