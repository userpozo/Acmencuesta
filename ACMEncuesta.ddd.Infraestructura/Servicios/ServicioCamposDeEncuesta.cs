using ACMEncuenta.ddd.Dominio.Entidades;
using ACMEncuenta.ddd.Dominio.Respositorios;
using ACMEncuenta.ddd.Dominio.Servicios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACMEncuesta.ddd.Infraestructura.Servicios
{
    public class ServicioCamposDeEncuesta : IServicioCamposDeEncuesta<EncuestaCampos, Guid>
    {

        private readonly IRepositorioCamposDeEncuesta<EncuestaCampos, Guid> _repositorioCamposDeEncuesta;

        public ServicioCamposDeEncuesta(IRepositorioCamposDeEncuesta<EncuestaCampos, Guid> repositorioCamposDeEncuesta)
        {
            this._repositorioCamposDeEncuesta = repositorioCamposDeEncuesta;
        }

        public async Task<List<EncuestaCampos>> ObtenerPorGuid(Guid entidadGuid)
        {
            return await this._repositorioCamposDeEncuesta.ObtenerPorGuid(entidadGuid);
        }
    }
}
