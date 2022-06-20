using ACMEncuenta.ddd.Dominio.Interfaces;

namespace ACMEncuenta.ddd.Dominio.Servicios
{
    public interface IServicioEncuesta<TEntidad, TEntidadID, TEntidadIDMany>
        : IAdd<TEntidad>, IUpdate<TEntidad, TEntidadID>, IDelete<TEntidadID>, ISelectWithListFields<TEntidad, TEntidadID>,
        ISelectOneToManyById<TEntidad, TEntidadID, TEntidadIDMany>, ISelectWithListSecret<TEntidad, TEntidadID>
    {
    }
}
