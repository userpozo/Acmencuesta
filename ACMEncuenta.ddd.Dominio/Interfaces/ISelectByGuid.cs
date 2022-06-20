using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACMEncuenta.ddd.Dominio.Interfaces
{
    public interface ISelectByGuid<TEntidad, TEntidadGuid>
    {
        Task<List<TEntidad>> ObtenerPorGuid(TEntidadGuid entidadGuid);
    }
}
