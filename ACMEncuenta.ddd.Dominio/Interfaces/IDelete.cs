using System.Threading.Tasks;

namespace ACMEncuenta.ddd.Dominio.Interfaces
{
    public interface IDelete<TEntidadID>
    {
        Task Eliminar(TEntidadID entidadID);
    }
}
