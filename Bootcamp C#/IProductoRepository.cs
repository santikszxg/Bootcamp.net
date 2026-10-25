using System;

namespace Bootcamp_C_;
    public interface IProductoRepository
{
     void Agregar(Producto producto);
    List<Producto> ObtenerTodos();
    Producto? ObtenerPorId(int id);
    List<Producto> BuscarPorCategoria(string categoria);
}
