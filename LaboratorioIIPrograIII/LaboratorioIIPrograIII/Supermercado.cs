using System.Collections.Generic;

namespace LaboratorioIIPrograIII
{
    internal class Supermercado
    {
        public List<Categoria> Categorias { get; set; }
        public List<Area> Areas { get; set; }
        public List<Producto> Productos { get; set; }
        public List<Usuario> Usuarios { get; set; }

        public Supermercado()
        {
            Categorias = new List<Categoria>();
            Areas = new List<Area>();
            Productos = new List<Producto>();
            Usuarios = new List<Usuario>();
        }
    }
}