using System.Threading.Tasks;

namespace ACMEncuenta.ddd.Dominio.Interfaces
{
    public interface IUpdate<TEntidad, TEntidadID>
    {
        Task Actualizar(TEntidad entidad, TEntidadID entidadID);
    }
}
