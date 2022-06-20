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
    public class RepositorioResultadoEncuesta : IRepositorioResultadoEncuesta<EncuestaCamposValor, Guid>
    {
        private readonly ApplicationDbContext _context;

        public RepositorioResultadoEncuesta(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<List<EncuestaCamposValor>> ObtenerPorGuid(Guid entidadGuid)
        {
            var resultado = await this._context.EncuestaCamposValor
                .Include(ec => ec.EncuestaCampos)
                .Where(s => s.EncuestaCampos.Encuesta.Guid == entidadGuid)
                .ToListAsync();

            return resultado;
        }
    }
}
