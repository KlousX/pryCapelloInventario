using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCapelloInventario
{
    public class Producto
    {
        public string Código { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public string Categoria { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
    }
}

