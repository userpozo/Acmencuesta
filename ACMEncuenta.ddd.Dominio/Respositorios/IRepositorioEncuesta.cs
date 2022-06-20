using ACMEncuenta.ddd.Dominio.Interfaces;

namespace ACMEncuenta.ddd.Dominio.Respositorios
{
    public interface IRepositorioEncuesta<TEntidad, TEntidadID, TEntidadIDMany>
        : IAdd<TEntidad>,IUpdate<TEntidad, TEntidadID>, IDelete<TEntidadID>, ISelectWithListFields<TEntidad, TEntidadID>, ISelectList<TEntidad>,
            ISelectOneToManyById<TEntidad, TEntidadID, TEntidadIDMany>, ISelectWithListSecret<TEntidad, TEntidadID>
    {
    }
}
