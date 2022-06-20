using ACMEncuenta.ddd.Dominio.Entidades;
using ACMEncuenta.ddd.Dominio.Respositorios;
using ACMEncuesta.ddd.Infraestructura.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACMEncuesta.ddd.Infraestructura.Repositorios
{
    public class RepositorioCamposDeEncuesta : IRepositorioCamposDeEncuesta<EncuestaCampos, Guid>
    {
        private readonly ApplicationDbContext _context;

        public RepositorioCamposDeEncuesta(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<List<EncuestaCampos>> ObtenerPorGuid(Guid entidadGuid)
        {
            var resultado = await this._context.EncuestaCampos
                .Include(x => x.Encuesta)
                .Where(y => y.Encuesta.Guid == entidadGuid).ToListAsync();
            return resultado;
        }
    }
}
