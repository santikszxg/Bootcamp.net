using System;
using System.Collections.Generic;
namespace Bootcamp_C_;

public class Producto
{
    public int Id {get; private set;}
    public string Nombre {get; private set;}
    public decimal Precio {get; private set;}
    public string Categoria {get; private set;}
    public bool Activo {get; private set;}

public Producto(int id, string nombre, decimal precio, string categoria, bool activo)
{
    Id = id;
    Nombre = nombre;
    Precio = precio;
    Categoria = categoria;
    Activo = activo;
}
}

