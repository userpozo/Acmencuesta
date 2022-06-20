using System.Threading.Tasks;

namespace ACMEncuenta.ddd.Dominio.Interfaces
{
    public interface ISelectWithListSecret<TEntidad, TEntidadID>
    {
        Task<TEntidad> ObtenerPorIdConCodigos(TEntidadID entidadID);
    }
}
