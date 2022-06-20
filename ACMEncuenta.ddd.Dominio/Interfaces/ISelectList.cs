using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACMEncuenta.ddd.Dominio.Interfaces
{
    public interface ISelectList<TEntidad>
    {
        Task<List<TEntidad>> ObtenerTodos();
    }
}
