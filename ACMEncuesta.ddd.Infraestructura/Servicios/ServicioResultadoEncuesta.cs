using ACMEncuenta.ddd.Dominio.Entidades;
using ACMEncuenta.ddd.Dominio.Respositorios;
using ACMEncuenta.ddd.Dominio.Servicios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACMEncuesta.ddd.Infraestructura.Servicios
{
    public class ServicioResultadoEncuesta : IServicioResultadoEncuesta<EncuestaCamposValor, Guid>
    {
        private readonly IRepositorioResultadoEncuesta<EncuestaCamposValor, Guid> _repositorioResultadoEncuesta;

        public ServicioResultadoEncuesta(IRepositorioResultadoEncuesta<EncuestaCamposValor, Guid> repositorioResultadoEncuesta)
        {
            this._repositorioResultadoEncuesta = repositorioResultadoEncuesta;
        }

        public async Task<List<EncuestaCamposValor>> ObtenerPorGuid(Guid entidadGuid)
        {
            return await this._repositorioResultadoEncuesta.ObtenerPorGuid(entidadGuid);
        }
    }
}
