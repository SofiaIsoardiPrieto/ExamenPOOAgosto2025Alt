using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOOAgosto2025Alt.Datos
{
    public interface IRepositorio<T> where T : class
    {
        Dictionary<int, T> ObtenerTodos();
        T ObtenerPorId(Guid id);
        int ObtenerCantidad();
    }
}
