using ACMEncuenta.ddd.Dominio.Interfaces;

namespace ACMEncuenta.ddd.Dominio.Servicios
{
    public interface IServicioCamposDeEncuesta<TEntidad, TEntidadGuid>
        : ISelectByGuid<TEntidad, TEntidadGuid>
    {
    }
}
