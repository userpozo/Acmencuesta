using System.Collections.Generic;

namespace ACMEncuenta.ddd.Dominio.Interfaces
{
    public interface ISelectOneToManyById<TEntidad, TEntidadID, TEntidadIDMany>
    {
        TEntidad ObtenerPadreConHijosPorId(TEntidadID entidadID, List<TEntidadIDMany> entidadIDMany);
    }
}
