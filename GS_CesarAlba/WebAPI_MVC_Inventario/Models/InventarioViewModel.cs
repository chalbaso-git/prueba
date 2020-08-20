using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_MVC_Inventario.Models
{
    public class InventarioViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string FechaCaducidad { get; set; }
        public string Estado { get; set; }
        public string Disponible { get; set; }
    }
}