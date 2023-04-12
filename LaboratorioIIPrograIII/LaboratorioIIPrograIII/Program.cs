using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace LaboratorioIIPrograIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Supermercado supermercado = new Supermercado();

            //Mostrar aviso
            Console.WriteLine("Bienvenido al supermercado");

            //Crear categorías
            Categoria categoria1 = new Categoria() { Nombre = "Electrónicos" };
            Categoria categoria2 = new Categoria() { Nombre = "Comestibles" };
            Categoria categoria3 = new Categoria() { Nombre = "Ropa" };
            supermercado.Categorias.Add(categoria1);
            supermercado.Categorias.Add(categoria2);
            supermercado.Categorias.Add(categoria3);

            //Crear áreas
            Area area1 = new Area() { Nombre = "Área de electrónicos" };
            Area area2 = new Area() { Nombre = "Área de comestibles" };
            supermercado.Areas.Add(area1);
            supermercado.Areas.Add(area2);

            //Crear productos
            Producto producto1 = new Producto()
            {
                Nombre = "Televisor",
                Categoria = categoria1,
                Area = area1,
                Proveedor = "Samsung",
                FechaCaducidad = DateTime.Parse("2024-12-31"),
                FechaEntrada = DateTime.Now,
                Detalles = "55 pulgadas, resolución 4K",
                Precio = 15000,
                UnidadesExistencia = 10
            };
            Producto producto2 = new Producto()
            {
                Nombre = "Leche",
                Categoria = categoria2,
                Area = area2,
                Proveedor = "Mailky",
                FechaCaducidad = DateTime.Parse("2024-12-31"),
                FechaEntrada = DateTime.Now,
                Detalles = "Leche Deslactosada",
                Precio = 100,
                UnidadesExistencia = 4
            };
            // Iniciar la aplicación
            Console.WriteLine("Bienvenido al Supermercado");
            Console.WriteLine("-------------------------");

            while (true)
            {
                // Mostrar el menú de opciones
                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Crear Categoría");
                Console.WriteLine("2. Crear Área");
                Console.WriteLine("3. Crear Producto");
                Console.WriteLine("4. Crear Usuario");
                Console.WriteLine("5. Realizar Venta");
                Console.WriteLine("6. Salir");

                // Leer la opción seleccionada por el usuario
                Console.Write("\nSeleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Crear una nueva categoría
                        Console.Write("\nIngrese el nombre de la categoría: ");
                        string nombreCategoria = Console.ReadLine();
                        Categoria nuevaCategoria = new Categoria(nombreCategoria);
                        Console.WriteLine($"Se creó la categoría '{nuevaCategoria.Nombre}'");
                        break;

                    case "2":
                        // Crear una nueva área
                        Console.Write("\nIngrese el nombre del área: ");
                        string nombreArea = Console.ReadLine();
                        Area nuevaArea = new Area(nombreArea);
                        Console.WriteLine($"Se creó el área '{nuevaArea.Nombre}'");
                        break;

                    case "3":
                        // Crear un nuevo producto
                        Console.Write("\nIngrese el nombre del producto: ");
                        string nombreProducto = Console.ReadLine();

                        // Mostrar las categorías disponibles
                        Console.WriteLine("\nCategorías:");
                        foreach (Categoria categoria in area1.Categorias)
                        {
                            Console.WriteLine($"- {categoria.Nombre}");
                        }
                        foreach (Categoria categoria in area2.Categorias)
                        {
                            Console.WriteLine($"- {categoria.Nombre}");
                        }

                        // Leer la categoría seleccionada por el usuario
                        Console.Write("\nIngrese el nombre de la categoría del producto: ");
                        string nombreCategoriaProducto = Console.ReadLine();
                        Categoria categoriaProducto = null;

                        // Buscar la categoría en las áreas
                        foreach (Categoria categoria in area1.Categorias)
                        {
                            if (categoria.Nombre == nombreCategoriaProducto)
                            {
                                categoriaProducto = categoria;
                                break;
                            }
                        }
                        if (categoriaProducto == null)
                        {
                            foreach (Categoria categoria in area2.Categorias)
                            {
                                if (categoria.Nombre == nombreCategoriaProducto)
                                {
                                    categoriaProducto = categoria;
                                    break;
                                }
                            }
                        }
                }
            }
        }
    }

}



