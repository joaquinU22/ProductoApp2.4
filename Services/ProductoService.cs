using ProductoApp.Models;
using System.Data.Common;

namespace ProductoApp.Services
{
    public class ProductoService : IAplicacion
    {
        public static List<Producto> lstProducto 
            = new List<Producto>();
      
        public bool AgregarOEditarProducto(Producto producto)
        {
            //buscar el producto existente en la listausando el codigo
            var productoExistente = lstProducto.Find(p=>p.Codigo == producto.Codigo);

            if (productoExistente != null) 
            {
                //actualizar el producto existente con los nuevos valores
                productoExistente.Nombre = producto.Nombre;
                productoExistente.Precio = producto.Precio;
                return true;
            }
            else 
            {
                lstProducto.Add(producto);
                return true;
            }
            
        }

        public bool BorrarProducto(int codigo)
        {
            var producto = lstProducto
                .Find(p => p.Codigo == codigo);

            if(producto != null)
            {
                lstProducto.Remove(producto);
                return true;
            }
            return false;
        }

        public List<Producto> GetProductos()
        {
            return lstProducto;
        }
    }
}
