using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioIIPrograIII
{
    public class Categoria
    {
        private string nombreCategoria;

        public Categoria(string nombreCategoria)
        {
            this.nombreCategoria = nombreCategoria;
        }

        public string Nombre { get; set; }
    }

    public class Area
    {
        public string Nombre { get; set; }
    }

    public class Producto
    {
        public string Nombre { get; set; }
        public Categoria Categoria { get; set; }
        public Area Area { get; set; }
        public string Proveedor { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string Detalles { get; set; }
        public decimal Precio { get; set; }
        public int UnidadesExistencia { get; set; }
    }

    


}
