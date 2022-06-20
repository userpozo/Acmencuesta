using ACMEncuenta.ddd.Dominio.Entidades;
using ACMEncuesta.ddd.Api.Dtos;
using ACMEncuesta.ddd.Infraestructura.Data;
using ACMEncuesta.ddd.Infraestructura.Repositorios;
using ACMEncuesta.ddd.Infraestructura.Servicios;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACMEncuesta.ddd.Api.Controllers
{
    [ApiController]
    [Route("api/LlenarEncuesta/")]
    public class LlenarEncuestaController : ControllerBase
    {
        private readonly ServicioCamposDeEncuesta _servicioCamposDeEncuesta;
        private readonly ServicioLlenarEncuesta _servicioLlenarEncuesta;
        private readonly IMapper _mapper;
        
        public LlenarEncuestaController(ApplicationDbContext context, IMapper mapper)
        {
            this._servicioCamposDeEncuesta = new ServicioCamposDeEncuesta(new RepositorioCamposDeEncuesta(context));
            this._servicioLlenarEncuesta = new ServicioLlenarEncuesta(new RepositorioLlenarEncuesta(context));
            this._mapper = mapper;
        }
        
        // Validar el codigo
        [HttpGet("validarSecret/{codigoGuid}")]
        public async Task<bool> Get_ValidarCodigoEncuesta([FromRoute] Guid codigoGuid)
        {
            return await this._servicioLlenarEncuesta.ValidarCodigoEncuesta(codigoGuid);
        }

        [HttpGet("{codigoGuid}")]
        public async Task<List<EncuestaCamposDto>> Get([FromRoute] Guid codigoGuid)
        {
            var resultado = await this._servicioCamposDeEncuesta.ObtenerPorGuid(codigoGuid);
            return this._mapper.Map<List<EncuestaCamposDto>>(resultado);
        }
        
        // Route: EncuestaId, CodigoPK
        // Values: Valor []
        [HttpPost("{EncuestaId:int}/{CodigoGuid}")]
        public async Task Post([FromRoute] int EncuestaId, [FromRoute] Guid codigoGuid, [FromBody] List<EncuestaCamposValorAlmacenarDto> entidad)
        {
            var resultado = this._mapper.Map<List<EncuestaCamposValor>>(entidad);
            resultado.ForEach(fk =>
            {
                fk.EncuestaCodigosEncuestaId = EncuestaId;
                fk.EncuestaCodigosCodigoPK = codigoGuid;
            });
            await this._servicioLlenarEncuesta.AgregarLista(resultado);
        }
    }
}
