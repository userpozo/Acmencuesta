using ACMEncuenta.ddd.Dominio.Entidades;
using ACMEncuenta.ddd.Dominio.Respositorios;
using ACMEncuesta.ddd.Infraestructura.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACMEncuesta.ddd.Infraestructura.Repositorios
{
    public class RepositorioLlenarEncuesta : IRepositorioLlenarEncuesta<EncuestaCamposValor, Guid>
    {
        private readonly ApplicationDbContext _context;

        public RepositorioLlenarEncuesta(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task AgregarLista(List<EncuestaCamposValor> entidad)
        {
            await this._context.EncuestaCamposValor.AddRangeAsync(entidad);
            await this._context.SaveChangesAsync();
        }

        public async Task<bool> ValidarCodigoEncuesta(Guid entidadAtributoValidar)
        {
            return await this._context.EncuestaCodigos.AnyAsync(x => x.CodigoPK == entidadAtributoValidar);
        }
    }
}
