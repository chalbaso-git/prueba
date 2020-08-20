using System;
using System.Collections.Generic;
using ServicesInventario.Models;

namespace ServicesInventario.Repository
{
    public class RPInventario
    {
        public static List<InventarioViewModels> _listaProducto = new List<InventarioViewModels>()
        {           
            new InventarioViewModels() { Id = 1, Nombre = "Producto 1" , FechaCaducidad = "17/08/2020", Estado = "", Disponible = "SI" },
            new InventarioViewModels() { Id = 2, Nombre = "Producto 2" , FechaCaducidad = "30/08/2020", Estado = "", Disponible = "SI" },
            new InventarioViewModels() { Id = 3, Nombre = "Producto 3" , FechaCaducidad = "18/08/2020", Estado = "", Disponible = "SI" }
        };

        public IEnumerable<InventarioViewModels> ObtenerProducto()
        {
            foreach (var item in _listaProducto)
            {
                if(Convert.ToDateTime(item.FechaCaducidad) < DateTime.Now)
                {
                    item.Estado = "Caducado";
                }
                else
                {
                    item.Estado = "Vigente";
                }
            }
            return _listaProducto;
        }

        public void EliminarProducto(int id)
        {
            var inventario = _listaProducto.Find(inv => inv.Id == id);  

            _listaProducto.Remove(inventario);
        }

        public void AgregarProducto(InventarioViewModels nuevoProducto)
        {
            _listaProducto.Add(new InventarioViewModels
            {
                Id = _listaProducto.Count + 1,
                Nombre = nuevoProducto.Nombre,
                FechaCaducidad = nuevoProducto.FechaCaducidad,
                Disponible = "SI"               
            });
        }      
    }
}
