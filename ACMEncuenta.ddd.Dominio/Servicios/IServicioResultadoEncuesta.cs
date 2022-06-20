using ACMEncuenta.ddd.Dominio.Interfaces;

namespace ACMEncuenta.ddd.Dominio.Servicios
{
    public interface IServicioResultadoEncuesta<TEntidad, TEntidadID> : ISelectByGuid<TEntidad, TEntidadID>
    {
    }
}
