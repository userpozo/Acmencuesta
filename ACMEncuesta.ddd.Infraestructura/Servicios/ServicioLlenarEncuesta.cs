using ACMEncuenta.ddd.Dominio.Entidades;
using ACMEncuenta.ddd.Dominio.Respositorios;
using ACMEncuenta.ddd.Dominio.Servicios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACMEncuesta.ddd.Infraestructura.Servicios
{
    public class ServicioLlenarEncuesta : IServicioLLenarEncuesta<EncuestaCamposValor, Guid>
    {
        private readonly IRepositorioLlenarEncuesta<EncuestaCamposValor, Guid> _repositorioLlenarEncuesta;

        public ServicioLlenarEncuesta(IRepositorioLlenarEncuesta<EncuestaCamposValor, Guid> repositorioLlenarEncuesta)
        {
            this._repositorioLlenarEncuesta = repositorioLlenarEncuesta;
        }

        public async Task AgregarLista(List<EncuestaCamposValor> entidad)
        {
            await this._repositorioLlenarEncuesta.AgregarLista(entidad);
        }

        public async Task<bool> ValidarCodigoEncuesta(Guid entidadAtributoValidar)
        {
            return await this._repositorioLlenarEncuesta.ValidarCodigoEncuesta(entidadAtributoValidar);
        }
    }
}
