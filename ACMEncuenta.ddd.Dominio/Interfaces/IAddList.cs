using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACMEncuenta.ddd.Dominio.Interfaces
{
    public interface IAddList<TEntidad>
    {
        Task AgregarLista(List<TEntidad> entidad);

    }
}
