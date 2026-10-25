using System.Linq;

namespace Bootcamp_C_;

public class ProductoRepository : IProductoRepository
{
    private List<Producto> productos;

    public ProductoRepository()
    {
        productos = new List<Producto>()
        {
            new Producto(1, "Mouse", 1200.00m, "Periféricos", true),
            new Producto(2, "Monitor", 1.00m, "Periféricos", false),
            new Producto(3, "Clavos", 10.00m, "Materiales", true)
        };
    }

    public void Agregar(Producto producto)
    {
        productos.Add(producto);
    }
    public List<Producto> ObtenerTodos()
    {
        return productos.ToList();
    }
    public Producto? ObtenerPorId(int id)
    {
        return productos.FirstOrDefault(p => p.Id == id);
    }
    public List<Producto> BuscarPorCategoria(String categoria)
    {
        return productos.Where(p => p.Categoria == categoria).ToList();
    }
}
