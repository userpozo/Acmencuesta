using ACMEncuenta.ddd.Dominio.Entidades;
using ACMEncuenta.ddd.Dominio.Respositorios;
using ACMEncuesta.ddd.Infraestructura.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACMEncuesta.ddd.Infraestructura.Repositorios
{
    public class RepositorioEncuesta : IRepositorioEncuesta<Encuesta, int, int>
    {
        private readonly ApplicationDbContext _context;

        public RepositorioEncuesta(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task Actualizar(Encuesta entidad, int entidadID)
        {
            this._context.Entry(entidad).State = EntityState.Modified;
            await this._context.SaveChangesAsync();
        }

        public async Task Agregar(Encuesta entidad)
        {
            await this._context.Encuestas.AddAsync(entidad);
            await this._context.SaveChangesAsync();
        }

        public async Task Eliminar(int entidadID)
        {
            this._context.Encuestas.Remove(new Encuesta() { Id = entidadID });
            await this._context.SaveChangesAsync();
        }

        public Encuesta ObtenerPadreConHijosPorId(int entidadID, List<int> entidadIDMany)
        {
            var resultado = this._context.Encuestas
                .Include(x => x.ListaDeCampos.Where(y => entidadIDMany.Contains(y.Id)))
                .FirstOrDefault(xxl => xxl.Id == entidadID);
            return resultado;
        }
        
        public async Task<Encuesta> ObtenerPorIdConCampos(int entidadID)
        {
            return await this._context.Encuestas
                .Include(x => x.ListaDeCampos)
                .FirstOrDefaultAsync(x => x.Id == entidadID);
        }

        public async Task<Encuesta> ObtenerPorIdConCodigos(int entidadID)
        {
            return await this._context.Encuestas
                .Include(y => y.ListaDeCodigos)
                .FirstOrDefaultAsync(x => x.Id == entidadID);
        }

        public async Task<List<Encuesta>> ObtenerTodos()
        {
            return await this._context.Encuestas
                .Include(x => x.ListaDeCampos)
                .Include(y => y.ListaDeCodigos)
                .ToListAsync();
        }

    }
}
