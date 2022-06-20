using System.Threading.Tasks;

namespace ACMEncuenta.ddd.Dominio.Interfaces
{
    public interface IAdd<TEntidad>
    {
        Task Agregar(TEntidad entidad);
    }
}
