using ExamenPOOAgosto2025Alt.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOOAgosto2025Alt.Datos
{
    public interface IRepositorioProducto
    {
        List<Producto> ObtenerPorTipo(Type tipo);
    }
}
