using ACMEncuenta.ddd.Dominio.Interfaces;

namespace ACMEncuenta.ddd.Dominio.Respositorios
{
    public interface IRepositorioResultadoEncuesta<TEntidad, TEntidadID> : ISelectByGuid<TEntidad, TEntidadID>
    {
    }
}
