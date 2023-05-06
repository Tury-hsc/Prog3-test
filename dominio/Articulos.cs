using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulos
    {
        public int Id { get; set; }
        [DisplayName("Número")]
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }
        public Datos Marca { get; set; }
        public Datos Categoria { get; set; }
        public Double Precio { get; set; }
        public string Codigo { get; set; }


    }
}
