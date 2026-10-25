using System;
using System.Collections.Generic;
namespace Bootcamp_C_;
class Program
{
    static void Main(string[] args)
    {
        IProductoRepository repo = new ProductoRepository();
        Console.WriteLine("Todos los productos:");
        foreach(Producto product in repo.ObtenerTodos())
        {
            Console.WriteLine(product.Id + " - " + product.Nombre + " - " + product.Precio + " - " + product.Categoria + " - " + product.Activo);
        }

        Producto? productoBuscado = repo.ObtenerPorId(2);
        Console.WriteLine("Producto buscado por ID:");
        if(productoBuscado != null)
        {
            Console.WriteLine(productoBuscado.Id + " - " + productoBuscado.Nombre + " - " + productoBuscado.Precio + " - " + productoBuscado.Categoria + " - " + productoBuscado.Activo);
        }else{
            Console.WriteLine("Producto no encontrado");
        }

        Console.WriteLine("Producto de Categoria Materiales:");
        foreach(Producto producto in repo.BuscarPorCategoria("Materiales"))
        {
            Console.WriteLine(producto.Id + " - " + producto.Nombre + " - " + producto.Precio + " - " + producto.Categoria + " - " + producto.Activo);
        }
        Producto nuevoProducto = new Producto(4, "Teclado", 120.00m, "Periféricos", true);
        repo.Agregar(nuevoProducto);
        Console.WriteLine("Todos los productos después de agregar uno nuevo:");
        foreach(Producto product in repo.ObtenerTodos())
        {
            Console.WriteLine(product.Id + " - " + product.Nombre + " - " + product.Precio + " - " + product.Categoria + " - " + product.Activo);
        }
    }

}
