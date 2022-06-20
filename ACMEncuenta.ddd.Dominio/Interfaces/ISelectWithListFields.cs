using System.Threading.Tasks;

namespace ACMEncuenta.ddd.Dominio.Interfaces
{
    public interface ISelectWithListFields<TEntidad, TEntidadID>
    {
        Task<TEntidad> ObtenerPorIdConCampos(TEntidadID entidadID);
    }
}
