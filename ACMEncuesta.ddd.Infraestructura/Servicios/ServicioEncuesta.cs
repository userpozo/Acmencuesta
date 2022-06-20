using ACMEncuenta.ddd.Dominio.Entidades;
using ACMEncuenta.ddd.Dominio.Respositorios;
using ACMEncuenta.ddd.Dominio.Servicios;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACMEncuesta.ddd.Infraestructura.Servicios
{
    public class ServicioEncuesta : IServicioEncuesta<Encuesta, int, int>
    {
        private readonly IRepositorioEncuesta<Encuesta, int, int> _repositorioEncuesta;

        public ServicioEncuesta(IRepositorioEncuesta<Encuesta, int, int> repositorioEncuesta)
        {
            this._repositorioEncuesta = repositorioEncuesta;
        }

        public async Task Actualizar(Encuesta entidad, int entidadID)
        {
            await this._repositorioEncuesta.Actualizar(entidad, entidadID);
        }
        
        public async Task Agregar(Encuesta entidad)
        {
            await this._repositorioEncuesta.Agregar(entidad);
        }

        public async Task Eliminar(int entidadID)
        {
            await this._repositorioEncuesta.Eliminar(entidadID);
        }

        public Encuesta ObtenerPadreConHijosPorId(int entidadID, List<int> entidadIDMany)
        {
            return this._repositorioEncuesta.ObtenerPadreConHijosPorId(entidadID, entidadIDMany);
        }

        public async Task<Encuesta> ObtenerPorIdConCampos(int entidadID)
        {
            return await this._repositorioEncuesta.ObtenerPorIdConCampos(entidadID);
        }

        public async Task<Encuesta> ObtenerPorIdConCodigos(int entidadID)
        {
            return await this._repositorioEncuesta.ObtenerPorIdConCodigos(entidadID);

        }

        public async Task<List<Encuesta>> ObtenerTodos()
        {
            return await this._repositorioEncuesta.ObtenerTodos();
        }
    }
}
