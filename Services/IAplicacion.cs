using ProductoApp.Models;

namespace ProductoApp.Services
{
    public interface IAplicacion
    {
        List<Producto> GetProductos();
        bool AgregarOEditarProducto(Producto producto);
        bool BorrarProducto(int codigo);


    }
}
