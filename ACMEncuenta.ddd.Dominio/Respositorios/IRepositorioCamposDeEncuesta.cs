using ACMEncuenta.ddd.Dominio.Interfaces;

namespace ACMEncuenta.ddd.Dominio.Respositorios
{
    public interface IRepositorioCamposDeEncuesta<TEntidad, TEntidadGuid>
        : ISelectByGuid<TEntidad, TEntidadGuid>
    {
    }
}
