using System.Threading.Tasks;

namespace ACMEncuenta.ddd.Dominio.Interfaces
{
    public interface IValidateSecret<TEntidadAtributoValidar>
    {
        Task<bool> ValidarCodigoEncuesta(TEntidadAtributoValidar entidadAtributoValidar);
    }
}
