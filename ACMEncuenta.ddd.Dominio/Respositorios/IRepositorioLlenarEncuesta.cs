using ACMEncuenta.ddd.Dominio.Interfaces;

namespace ACMEncuenta.ddd.Dominio.Respositorios
{
    public interface IRepositorioLlenarEncuesta<TEntidad, TEntidadAtributoValidar>
        : IAddList<TEntidad>, IValidateSecret<TEntidadAtributoValidar>
    {
    }
}
