using ACMEncuenta.ddd.Dominio.Interfaces;

namespace ACMEncuenta.ddd.Dominio.Servicios
{
    public interface IServicioLLenarEncuesta<TEntidad, TEntidadAtributoValidar>
        : IAddList<TEntidad>, IValidateSecret<TEntidadAtributoValidar>
    {
    }
}
